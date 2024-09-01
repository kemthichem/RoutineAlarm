namespace RoutineAlarm
{
    using Serilog;
    internal static class Program
    {

        public static RoutineAlarm globalForm;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Set up Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logfile.txt", rollingInterval: RollingInterval.Month)
                .CreateLogger();

            Log.Information("Application starting up");

            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            globalForm = new RoutineAlarm();
            Application.Run(globalForm);

            GC.KeepAlive(mutex);

            // Ensure to flush and close log
            Log.CloseAndFlush();

        }
    }
}