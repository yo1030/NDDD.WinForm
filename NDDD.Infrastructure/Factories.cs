using NDDD.Domain;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure.Fake;
using NDDD.Infrastructure.MySQLServer;

namespace NDDD.Infrastructure
{
    public static class Factories
    {
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
