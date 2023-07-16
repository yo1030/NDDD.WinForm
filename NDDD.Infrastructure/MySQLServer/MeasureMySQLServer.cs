using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace NDDD.Infrastructure.MySQLServer
{
    /// <summary>
    /// 計測MySQLServerクラス
    /// </summary>
    internal sealed class MeasureMySQLServer : IMeasureRepository
    {
        /// <summary>
        /// 直近値の取得
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FakeException"></exception>
        public MeasureEntity GetLatest()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// エリアごとの直近値の取得
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            throw new NotImplementedException();
        }
    }
}
