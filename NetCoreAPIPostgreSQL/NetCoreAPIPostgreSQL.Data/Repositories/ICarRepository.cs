using NetCoreAPIPostgreSQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIPostgreSQL.Data.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCars();
        Task<Car> GetCarDetails(int id);
        Task<bool> InsertCard(Car car);
        Task<bool> UpdateCard(Car car);
        Task<bool> DeleteCard(Car car);

    }
}
