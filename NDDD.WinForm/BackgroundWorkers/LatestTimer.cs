using NDDD.Domain.StaticValues;
using NDDD.Infrastructure;

namespace NDDD.WinForm.BackgroundWorkers
{
    internal static class LatestTimer
    {
        private static System.Threading.Timer _timer;
        private static bool _isWork = false;

        static LatestTimer()
        {
            _timer = new System.Threading.Timer(Callback);
        }

        internal static void Start()
        {
            _timer.Change(0, 10000);
        }

        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private static void Callback(object o)
        {
            //_timer.Change(Timeout.Infinite, Timeout.Infinite);

            if (_isWork)
            {
                return;
            }

            try
            {
                _isWork = true;
                Measures.Create(Factories.CreateMeasure());
            }
            finally
            {
                _isWork = false;
                //_timer.Change(10000, 10000);
            }
        }
    }
}
