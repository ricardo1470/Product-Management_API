using NetCoreAPIPostgreSQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIPostgreSQL.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Task<bool> DeleteCard(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCard(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCard(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
