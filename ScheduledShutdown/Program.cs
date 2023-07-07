using helloserve.SePush;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ScheduledShutdown
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            System.Threading.Thread.Sleep(5000); // Delay for 5 seconds to allow the pc to startup

            Application.Run(ServiceProvider.GetRequiredService<Main>());

            // Application.Run(new Main());
     
        }

        static IHostBuilder CreateHostBuilder()
        {
            var licenseKey = Utils.GetSettingFromRegistry("espToken");
            Action<SePushOptions> config = (options) =>
            {
                options.Token = licenseKey;
            };

            IConfigureOptions<SePushOptions> configureOptions = new ConfigureOptions<SePushOptions>(config);

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.ConfigureOptions(configureOptions);
                    services.AddSingleton<ISePush, SePushClient>();
                    services.AddSingleton<Main>();
                });
        }

    }
}