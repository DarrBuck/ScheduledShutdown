using NUTDotNetClient;
using System.Data.Common;

//GET commands to retrieve information from the server
//LIST commands for listing information from a server or UPS
//SET VAR command, to change a variable on a UPS
//INSTCMD to run a command on a UPS
//USERNAME and PASSWORD to run commands and retrieve information that are privileged
//LOGIN and LOGOUT to indicate dependency on a UPS
//VER and NETVER to retrieve basic information from the NUT server

namespace ScheduledShutdown.Services
{
    public class WinNUTService : IDisposable
    {
        public NUTClient UpsClient { get; private set; }

        readonly string? _hostName;
        readonly string? _userName;
        readonly string? _password;
        readonly int _port = 3493;
        //readonly string? _upsName;

        public WinNUTService(string? hostName, string? userName, string? password)
        {
            _hostName = hostName;
            _userName = userName;
            _password = password;

            try
            {
                UpsClient = new NUTClient(_hostName, _port);
                UpsClient.Connect();
                UpsClient.SetUsername(_userName);
                UpsClient.SetPassword(_password);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (UpsClient != null)
                {
                    if (UpsClient.IsConnected)
                    {
                        UpsClient.Disconnect();
                        UpsClient.Dispose();
                    }
                }
            }
        }
    }
}
