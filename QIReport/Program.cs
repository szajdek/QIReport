using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QualityShims.Forms;

namespace QualityShims
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<LoginForm>();
                    var provider = services.BuildServiceProvider();
                }).Build();

            var loginForm = host.Services.GetRequiredService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}