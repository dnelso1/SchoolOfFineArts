using Microsoft.Extensions.Configuration;

namespace SchoolOfFineArts
{
    public static class Program
    {
        public static IConfigurationRoot _configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();

            Application.Run(new Form1());
        }
    }
}