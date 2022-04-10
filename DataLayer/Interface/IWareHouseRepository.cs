using DataLayer.Models;

namespace DataLayer.Interface
{
    public interface IWareHouseRepository : IGenericRepository<WareHouse>
    {
        Task<WareHouse> GetWareHouseByCode(string code);
    }
}
