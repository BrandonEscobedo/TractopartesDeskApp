using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuestPDF.Fluent;
using System.Windows;
using TractopartesDeskApp.Views;

namespace TractopartesDeskApp
{
    public partial class App : Application
    {     
        public static IHost? AppHost { get; private set; }
        protected void Application_Startup(object sender, StartupEventArgs e)
        {
            var startupform = new LoginView();
            startupform.Show();
            startupform.IsVisibleChanged += (s, ev) =>
            {
                if (startupform.IsVisible == false && startupform.IsLoaded)
                {
                    
                    var mainview = new Dashboard();
                    mainview.Show();
                    startupform.Close();
                }
            };
        }
    }

}
