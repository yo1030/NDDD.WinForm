using NDDD.Domain.Repositories;
using NDDD.Domain.StaticValues;
using NDDD.Infrastructure;

namespace NDDD.WinForm.BackgroundWorkers
{
    /// <summary>
    /// 直近値のタイマー
    /// </summary>
    internal static class LatestTimer
    {
        private static IMeasureRepository _repository;
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

        internal static void SetInterface(IMeasureRepository repository)
        {
            _repository = repository;
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
        internal static void Callback(object o)
        {
            //_timer.Change(Timeout.Infinite, Timeout.Infinite);

            if (_isWork)
            {
                return;
            }

            try
            {
                _isWork = true;
                //Measures.Create(Factories.CreateMeasure());
                Measures.Create(_repository);
            }
            finally
            {
                _isWork = false;
                //_timer.Change(10000, 10000);
            }
        }
    }
}
