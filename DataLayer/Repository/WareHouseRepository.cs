using DataLayer.Context;
using DataLayer.Interface;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
    public class WareHouseRepository : IWareHouseRepository
    {
        private readonly WHMDbContext _context;

        public WareHouseRepository(WHMDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(WareHouse entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(WareHouse entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<WareHouse>> GetAllAsync()
        {
            return await _context.WareHouse.ToListAsync();
        }

        public async Task<WareHouse> GetByIdAsync(int id)
        {
            return await _context.WareHouse.FirstOrDefaultAsync(x => x.WareHouseId == id);
        }

        public Task UpdateAsync(WareHouse entity)
        {
            throw new NotImplementedException();
        }
    }
}
