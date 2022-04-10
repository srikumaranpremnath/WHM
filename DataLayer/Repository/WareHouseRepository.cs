using DataLayer.Context;
using DataLayer.Interface;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
{
    public class WareHouseRepository : IWareHouseRepository
    {
        private readonly WHMDbContext _context;

        public WareHouseRepository(WHMDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(WareHouse entity)
        {
            await _context.WareHouse.AddAsync(entity);
            _context.SaveChanges();
        }

        public Task DeleteAsync(WareHouse entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<WareHouse>> GetAllAsync() => await _context.WareHouse.ToListAsync();

        public async Task<WareHouse> GetByIdAsync(int id) => await _context.WareHouse.FirstOrDefaultAsync(x => x.WareHouseId == id);

        public Task<WareHouse> GetWareHouseByCode(string code) => _context.WareHouse.FirstOrDefaultAsync(x => x.WareHouseCode == code);

        public Task UpdateAsync(WareHouse entity)
        {
            throw new NotImplementedException();
        }
    }
}
