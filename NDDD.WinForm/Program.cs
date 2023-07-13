using NDDD.WinForm.BackgroundWorkers;
using NDDD.WinForm.Views;

namespace NDDD.WinForm
{
    internal static class Program
    {
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

            _logger.Debug("�f�o�b�O�̃��O");
            _logger.Info("information�̃��O");
            _logger.Warn("warning�̃��O");
            _logger.Error("Error�̃��O");
            _logger.Fatal("fatal�̃��O");

            LatestTimer.Start();
            Application.Run(new LoginView());
        }
    }
}