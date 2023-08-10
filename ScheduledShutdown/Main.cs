using helloserve.SePush;
using helloserve.SePush.Models;
using NUTDotNetClient;
using NUTDotNetShared;
using ScheduledShutdown.Models;
using ScheduledShutdown.Services;
using System.Data;
using System.Diagnostics;

namespace ScheduledShutdown
{
    public partial class Main : Form
    {
        private readonly NotifyIcon notifyIcon;
        private readonly ContextMenuStrip? trayIconContextMenu;
        private readonly string? testMode = null;//"current"; //set to null for "live" or use "current" or "future" for testing
        private readonly string appName = "ScheduledShutdown";
        private readonly string appPath = Application.ExecutablePath;
        private string? licenseKey = "";
        private string? areaId = "eskde-10-fourwaysext10cityofjohannesburggauteng"; //default to JHB for tetsing
        private bool useEsp = false;
        private bool useNUT = false;
        private bool isShutdownCancelled = false;
        private readonly ISePush espClient;
        private DateTime? nextShutdownDateTime = null;

        private WinNUTService? winNutService = null;
        private string? nutHost;
        private string? nutUserName;
        private string? nutPassword;
        private string? nutStatus;
        private string? nutCharge;
        private int nutShutdownMinutes = 0;
        private ClientUPS? nutUps;

        public Main(ISePush sePushClient)
        {
            InitializeComponent();

            // Create and configure the NotifyIcon
            notifyIcon = new NotifyIcon
            {
                //Icon = new Icon(this.Icon, 40, 40), //trayIcon is your NotifyIcon//new System.Drawing.Icon(@"flash.ico"), // Set the path to your desired icon
                Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath),
                Text = "Scheduled Shutdown"
            };
            notifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;

            // Create the context menu
            trayIconContextMenu = new ContextMenuStrip();
            trayIconContextMenu.Items.Add("Settings", null, new EventHandler(Settings_Click));
            trayIconContextMenu.Items.Add("Exit", null, Exit_Click);
            trayIconContextMenu.Items.Add("Shutdown PC", null, new EventHandler(ShutdownMenuItem_Click));

            // Assign the context menu to the NotifyIcon
            notifyIcon.ContextMenuStrip = trayIconContextMenu;

            // Display the NotifyIcon
            notifyIcon.Visible = true;

            this.espClient = sePushClient;

        }

        #region "Form Events"

        private async void Main_LoadAsync(object sender, EventArgs e)
        {
            //ESP Settings
            useEsp = Utils.GetSettingFromRegistry("espUse") == "True";
            espSettingsGroupBox.Visible = useEsp;
            espUseCheckBox.Checked = useEsp;
            licenseKey = Utils.GetSettingFromRegistry("espToken");
            espTokenTextBox.Text = licenseKey;
            //useEsp = false; //uncomment when api needed
            espTimer.Enabled = useEsp;

            //NUT Settings
            useNUT = Utils.GetSettingFromRegistry("nutUse") == "True";
            nutTimer.Enabled = useNUT;
            nutUseCheckBox.Checked = useNUT;

            nutHost = Utils.GetSettingFromRegistry("nutHost");
            nutHostTextBox.Text = nutHost;
            nutUserName = Utils.GetSettingFromRegistry("nutUserName");
            nutUserNameTextBox.Text = nutUserName;
            nutPassword = Utils.GetSettingFromRegistry("nutPassword");
            nutPasswordTextBox.Text = nutPassword;
            if (int.TryParse(Utils.GetSettingFromRegistry("nutShutdownTime"), out int nutShutdownMinutes))
            {
                nutShutdownTime.Value = nutShutdownMinutes;
            }

            if (useNUT)
            {
                CheckUpsStatus(); //call initial
            }

            if (DateTime.TryParse(Utils.GetSettingFromRegistry("nextShutdownDate"), out DateTime nextShutdownDate))
            {
                shutdownDatePicker.Value = nextShutdownDate;
            }
            else
            {
                shutdownDatePicker.Value = DateTime.Now;
            }

            if (DateTime.TryParse(Utils.GetSettingFromRegistry("nextShutdownTime"), out DateTime nextShutdownTime))
            {
                var shutdownDate = nextShutdownDate.Date;
                nextShutdownTime = new DateTime(shutdownDate.Year, shutdownDate.Month, shutdownDate.Day, nextShutdownTime.Hour, nextShutdownTime.Minute, nextShutdownTime.Second);
                shutdownTimePicker.Value = nextShutdownTime;
                shutdownDatePicker.Value = nextShutdownTime;
            }
            else
            {
                shutdownTimePicker.Value = DateTime.Now;
            }

            if (int.TryParse(Utils.GetSettingFromRegistry("shutdownBeforeAfter"), out int shutdownBeforeAfter))
            {
                shutdownBeforeAfterUpDown.Value = shutdownBeforeAfter;
            }

            shutdownAlertCheckBox.Checked = Utils.GetSettingFromRegistry("shutdownAlert") == "True";
            espLookUpTextBox.Text = Utils.GetSettingFromRegistry("espArea");
            addToStartupCheckBox.Checked = Utils.CheckMachineStartup(appName, appPath);
            disableCheckBox.Checked = Utils.GetSettingFromRegistry("shutdownsDisabled") == "True";

            areaId = espLookUpTextBox.Text;
            isShutdownCancelled = disableCheckBox.Checked;

            CheckShutdown();

            if (useEsp)
            {
                try
                {
                    await UpdateEskomEvents();
                    espToolStripStatusLabel.ForeColor = Color.Green;
                    espToolStripStatusLabel.Text = "Connected to ESP";
                }
                catch (Exception ex)
                {
                    espToolStripStatusLabel.ForeColor = Color.Red;
                    espToolStripStatusLabel.Text = "Error connecting to ESP: " + ex.Message;
                }
            }
            else
            {
                espToolStripStatusLabel.ForeColor = Color.SteelBlue;
                espToolStripStatusLabel.Text = "Not connected to ESP";
            }

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Minimize to system tray instead of closing
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }

            base.OnFormClosing(e);
        }

        protected override void OnResize(EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // Hide the form and show the NotifyIcon
                Hide();
                notifyIcon.Visible = true;
            }

            base.OnResize(e);
        }

        private void NotifyIcon_MouseDoubleClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Restore the form when the NotifyIcon is double-clicked with the left mouse button
                Show();
                WindowState = FormWindowState.Normal;
                //notifyIcon.Visible = false;
            }
        }

        private void Settings_Click(object? sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            //notifyIcon.Visible = false;
            mainTabControl.SelectedIndex = 1;

        }

        private void Exit_Click(object? sender, EventArgs e)
        {
            //shutdown the windows application
            Application.Exit();

        }

        private void ShutdownMenuItem_Click(object? sender, EventArgs e)
        {
            // Confirm the shutdown with the user
            DialogResult? result = MessageBox.Show("Are you sure you want to shut down the computer?", "Confirm Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call the Shutdown Computer method to initiate the shutdown
                ShutdownComputer("Shutdown Menu");
            }
        }

        private void EspTokenTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("espToken", espTokenTextBox.Text);

            licenseKey = espTokenTextBox.Text;
        }

        private void EspUseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            useEsp = espUseCheckBox.Checked;

            Utils.SaveSettingToRegistry("espUse", espUseCheckBox.Checked.ToString());

            espTimer.Enabled = useEsp;
            espSettingsGroupBox.Visible = useEsp;
        }

        private void NutUseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            useNUT = nutUseCheckBox.Checked;

            Utils.SaveSettingToRegistry("nutUse", espUseCheckBox.Checked.ToString());

            nutTimer.Enabled = useNUT;
            nutSettingsGroupBox.Visible = useNUT;

        }

        private void AddToStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var addToStartUp = addToStartupCheckBox.Checked;
            if (addToStartUp)
            {
                Utils.AddToMachineStartup(appName, appPath);
            }
            else
            {
                Utils.RemoveFromMachineStartup(appName);
            }
        }

        private void EspLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ps = new ProcessStartInfo("https://eskomsepush.gumroad.com/l/api")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }

        private async void EspCheckAreaButton_Click(object sender, EventArgs e)
        {
            await UpdateEskomEvents();

            mainTabControl.SelectedIndex = 0;
        }


        private async void EspSearchButton_Click(object sender, EventArgs e)
        {
            //The ESP API throttles these request very quickly so implementing a manual lookup
            string? filter_param = espLookUpTextBox.Text;
            if (filter_param.Length > 4)
            {
                var results = await espClient.AreasSearchAsync(filter_param.ToLower());

                espAreaListBox.DataSource = results;
                espAreaListBox.DisplayMember = "name" + " - " + "region";
                espAreaListBox.ValueMember = "id";
                espAreaListBox.SelectedIndex = -1;
                espAreaListBox.IntegralHeight = true;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Enter at least 4 characters to perform a search on.");
            }
        }

        private void ShutdownDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime nextShutdownTime = shutdownTimePicker.Value;
            var shutdownDate = shutdownDatePicker.Value.Date;
            nextShutdownTime = new DateTime(shutdownDate.Year, shutdownDate.Month, shutdownDate.Day, nextShutdownTime.Hour, nextShutdownTime.Minute, nextShutdownTime.Second);
            shutdownTimePicker.Value = nextShutdownTime;
            shutdownDatePicker.Value = nextShutdownTime;

            var newValue = shutdownDatePicker.Value.ToString("yyyy-MM-dd");
            Utils.SaveSettingToRegistry("nextShutdownDate", newValue);
        }

        private void ShutdownTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var newValue = shutdownTimePicker.Value.ToString("HH:mm");
            Utils.SaveSettingToRegistry("nextShutdownTime", newValue);
            isShutdownCancelled = false;
        }

        private void ShutdownBeforeAfterUpDown_ValueChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("shutdownBeforeAfter", shutdownBeforeAfterUpDown.Value.ToString());
        }

        private void ShutdownAlertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("shutDownAlert", shutdownAlertCheckBox.Checked.ToString());
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            CheckShutdown();

        }

        private async void EskomTimer_Tick(object sender, EventArgs e)
        {
            await UpdateEskomEvents();
        }


        private void EspAreaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set espLookupTextBox equal to the selected item id
            if (espAreaListBox.SelectedIndex != -1)
            {
                var selectedArea = espAreaListBox.SelectedItem as Area;
                espLookUpTextBox.Text = selectedArea?.Id;
                espAreaListBox.SelectedIndex = -1;
                Utils.SaveSettingToRegistry("espArea", espLookUpTextBox.Text ?? "");
                areaId = espLookUpTextBox.Text;
            }
        }
        private void DisableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isShutdownCancelled = disableCheckBox.Checked;
            Utils.SaveSettingToRegistry("shutdownsDisabled", disableCheckBox.Checked.ToString());
            UpdateStatusLabel();
        }

        #endregion

        #region "Private Methods"

        private static void ShutdownComputer(string source)
        {
            //Write to windows event log that this app is shutting down the computer
            var log = new EventLog("Appplication")
            {
                Source = source
            };
            log.WriteEntry("Shutting down the computer", EventLogEntryType.Information, 101, 1);

            // Create a process to execute the shutdown command
            Process? process = new();
            ProcessStartInfo? startInfo = new()
            {
                FileName = "shutdown",
                Arguments = "/s /t 0", // Shutdown with no delay
                CreateNoWindow = true,
                UseShellExecute = false
            };
            process.StartInfo = startInfo;

            try
            {
                // Start the process to shut down the computer
                process.Start();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred while shutting down the computer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if nextShutdownTime has passed by maximum of two minutes
        private bool IsShutdownPassed()
        {
            if (nextShutdownDateTime == null) return false;
            var currentTime = DateTime.Now;
            var diff = nextShutdownDateTime - currentTime;
            UpdateStatusLabel($"Shutdown in: {diff:hh\\:mm} hours");

            return (diff.Value.TotalMinutes <= 0 && diff.Value.TotalMinutes >= -3);
        }

        private void CheckShutdown()
        {
            nextShutdownDateTime = shutdownTimePicker.Value.AddMinutes((double)shutdownBeforeAfterUpDown.Value);

            if (nextShutdownDateTime != null && !isShutdownCancelled)
            {
                if (IsShutdownPassed()) //make allowance for timer only firing every minute 
                {
                    if (shutdownAlertCheckBox.Checked)
                    {
                        if (DateTime.Now >= nextShutdownDateTime)
                        {
                            if (MessageBox.Show("Shutdown time reached", "Shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                            {
                                isShutdownCancelled = true;
                                disableCheckBox.Checked = true;
                            }
                            else
                            {
                                ShutdownComputer("ESP Scheduled Shutdown");
                            }
                        }
                    }
                    else
                    {
                        ShutdownComputer("ESP Scheduled Shutdown");
                    }
                }
                else
                {
                    if (nextShutdownDateTime < DateTime.Now)
                    {
                        UpdateStatusLabel("Schedule time passed");
                    }
                }
            }
            else
            {
                UpdateStatusLabel("No shutdown scheduled");
            }
        }

        private async Task UpdateEskomEvents()
        {

            if (useEsp && !string.IsNullOrEmpty(areaId))
            {
                espGroupBox.Text = $"Eskom schedule for {areaId}";
                try
                {
                    var result = await espClient.AreaInformationAsync(areaId, testMode: testMode);
                    if (result != null && result.Events != null)
                    {
                        var events = result.Events.OrderBy(o => o.Start);
                        //get the first event that is after the current time
                        var nextEvent = events.FirstOrDefault();//(o => o.Start > DateTime.Now);

                        if (nextEvent != null)
                        {
                            //set the next event
                            shutdownDatePicker.Value = nextEvent.Start;
                            shutdownTimePicker.Value = nextEvent.Start;
                            isShutdownCancelled = false; //set it for the next event
                        }
                        else
                        {
                            //leave what was there
                        }
                        espGridView.DataSource = result.Events;

                    }
                }
                catch (Exception ex)
                {
                    espToolStripStatusLabel.ForeColor = Color.Red;
                    espToolStripStatusLabel.Text = "Error connecting to ESP: " + ex.Message;

                    throw;
                }
            }
        }

        private void UpdateStatusLabel(string? status = "")
        {
            if (isShutdownCancelled)
            {
                timerToolStripStatusLabel.Text = "Shutdown cancelled";
            }
            else
            {
                timerToolStripStatusLabel.Text = status;
            }
        }

        #endregion

        private void NutTestButton_Click(object sender, EventArgs e)
        {

            Application.UseWaitCursor = true;
            Cursor.Current = Cursors.WaitCursor;

            winNutService?.Dispose();

            try
            {
                CheckUpsStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NUT Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                espToolStripStatusLabel.ForeColor = Color.Red;
                espToolStripStatusLabel.Text = "UPS: Error";

                winNutService?.Dispose();
            }

            Application.UseWaitCursor = false;
            Cursor.Current = Cursors.Default;

        }

        private void CheckUpsStatus()
        {
            try
            {
                if (winNutService == null)
                {
                    winNutService = new WinNUTService(nutHost, nutUserName, nutPassword);
                    var ServerVersion = winNutService.UpsClient.SendQuery("VER")[0];
                    var ProtocolVersion = winNutService.UpsClient.SendQuery("NETVER")[0];
                    var upses = winNutService.UpsClient.GetUPSes(true);
                    nutUps = upses[0];
                    nutUps.Login();
                }

                if (nutUps != null && nutUps.IsLoggedIn)
                {
                    var comamnds = nutUps.GetCommands();
                    List<UPSVariable> variables = nutUps.GetVariables();
                    nutGridView.DataSource = variables.Select(s => new UpsVariable { NutDescription = s.Name, NutValue = s.Value }).ToList();

                    nutCharge = nutUps.GetVariable("battery.charge", true).Value;
                    nutStatus = nutUps.GetVariable("ups.status", true).Value == "OL" ? "Online" : "Offline";
                    nutToolStripStatusLabel.ForeColor = nutStatus == "Online" ? Color.Green : Color.Red;
                }
                else
                {
                    nutCharge = "0";
                    nutStatus = "Unknown";
                    nutToolStripStatusLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                nutCharge = "0";
                nutStatus = "Unknown";
                nutToolStripStatusLabel.ForeColor = Color.Orange;
            }

            nutToolStripStatusLabel.Text = $"UPS: {nutStatus} - Charge: {nutCharge}%";

            if (nutStatus == "Online")
            {
                nutShutdownTimer.Enabled = false;
            }
            else if (nutStatus == "Offline")
            {
                nutTimer.Enabled = false;
                nutShutdownTimer.Interval = nutShutdownMinutes * 60 * 1000;
                nutShutdownTimer.Enabled = true;
            }
            else
            {
                nutTimer.Enabled = true;
                nutShutdownTimer.Enabled = false;
            }
        }

        private void NutHostTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("nutHost", nutHostTextBox.Text);
            nutHost = nutHostTextBox.Text;
        }

        private void NutUserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("nutUserName", nutUserNameTextBox.Text);
            nutUserName = nutUserNameTextBox.Text;
        }

        private void NutPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("nutPassword", nutPasswordTextBox.Text);
            nutPassword = nutPasswordTextBox.Text;
        }

        private void NutTimer_Tick(object sender, EventArgs e)
        {
            CheckUpsStatus();
        }


        private void NutShutdownTime_ValueChanged(object sender, EventArgs e)
        {
            Utils.SaveSettingToRegistry("nutShutdownTime", nutShutdownTime.Value.ToString());
            nutShutdownMinutes = (int)nutShutdownTime.Value;
        }

        private void NutShutdownTimer_Tick(object sender, EventArgs e)
        {

            if (shutdownAlertCheckBox.Checked)
            {
                if (MessageBox.Show("UPS shutdown time reached", "Shutdown", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    isShutdownCancelled = true;
                    //disableCheckBox.Checked = true;
                    nutShutdownTimer.Enabled = true;
                }
                else
                {
                    ShutdownComputer("UPS Scheduled Shutdown");
                }
            }
        }
    }
}