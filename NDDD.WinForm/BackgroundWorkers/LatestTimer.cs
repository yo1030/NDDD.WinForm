using NDDD.Domain.StaticValues;
using NDDD.Infrastructure;

namespace NDDD.WinForm.BackgroundWorkers
{
    /// <summary>
    /// 直近値のタイマー
    /// </summary>
    internal static class LatestTimer
    {
        /// <summary>
        /// タイマー
        /// </summary>
        private static System.Threading.Timer _timer;
        /// <summary>
        /// 処理中のときTrue
        /// </summary>
        private static bool _isWork = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        static LatestTimer()
        {
            _timer = new System.Threading.Timer(Callback);
        }

        /// <summary>
        /// Start
        /// </summary>
        internal static void Start()
        {
            _timer.Change(0, 10000);
        }

        /// <summary>
        /// Stop
        /// </summary>
        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        /// <summary>
        /// コールバック
        /// </summary>
        /// <param name="o">オブジェクト</param>
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
