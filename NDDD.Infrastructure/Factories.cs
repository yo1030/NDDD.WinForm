using NDDD.Domain;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure.Fake;
using NDDD.Infrastructure.MySQLServer;

namespace NDDD.Infrastructure
{
    /// <summary>
    /// ファクトリー
    /// </summary>
    public static class Factories
    {
        /// <summary>
        /// 計測リポジトリの作成
        /// </summary>
        /// <returns>計測リポジトリ</returns>
        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG
            if (Shared.IsFake)
            {
                return new MeasureFake();
            }
#endif

            return new MeasureMySQLServer();
        }
    }
}
