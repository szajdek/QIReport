using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QIReport.Factories;
using QIReport.Reporting;
using QualityShims.Forms;
using System.Configuration;

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
                    services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString));
                    services.AddAutoMapper(typeof(Program));
                    services.AddTransient<IReportService, ReportService>();
                    services.AddTransient<MainForm>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<AddShimInspectionReportForm>();
                    services.AddTransient<ManageInspectionReportsForm>();
                    services.AddTransient<InspectionReportViewerForm>();
                    var provider = services.BuildServiceProvider();
                }).Build();

            var serviceProvider = host.Services;

            var formFactory = new FormFactory();
            formFactory.SetServiceProvider(serviceProvider);

            var loginForm = formFactory.CreateForm<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(formFactory.CreateForm<MainForm>());
            }
        }
    }
}