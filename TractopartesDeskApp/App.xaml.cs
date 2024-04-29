using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using TractopartesDeskApp.Views;

namespace TractopartesDeskApp
{
    
    public partial class App : Application
    {

        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostservices, services) =>
                {
                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {

            await AppHost!.StartAsync();
            var startupform = AppHost.Services.GetRequiredService<MainWindow>();
            startupform.Show();
            base.OnStartup(e);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();

            base.OnExit(e);
        }
    }

}
