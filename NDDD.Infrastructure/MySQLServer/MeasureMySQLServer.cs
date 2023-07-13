using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace NDDD.Infrastructure.MySQLServer
{
    internal sealed class MeasureMySQLServer : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            throw new NotImplementedException();
        }
    }
}
