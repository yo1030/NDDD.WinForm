using NDDD.Infrastructure;
using NDDD.WinForm.BackgroundWorkers;
using NDDD.WinForm.Views;

namespace NDDD.WinForm
{
    /// <summary>
    /// Program
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            _logger.Debug("デバッグのログ");
            _logger.Info("informationのログ");
            _logger.Warn("warningのログ");
            _logger.Error("Errorのログ");
            _logger.Fatal("fatalのログ");

            LatestTimer.SetInterface(Factories.CreateMeasure());
            LatestTimer.Start();
            Application.Run(new LoginView());
        }
    }
}