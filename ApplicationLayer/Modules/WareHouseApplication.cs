using AutoMapper;
using BusinessObjects.Models;
using DataLayer.Interface;

namespace ApplicationLayer.Modules.WareHouseApplication
{
    public class WareHouseApplication
    {
        private readonly IWareHouseRepository _wareHouseRepository;
        private readonly IMapper _mapper;

        public WareHouseApplication(IWareHouseRepository wareHouseRepository, IMapper mapper)
        {
            _wareHouseRepository = wareHouseRepository;
            _mapper = mapper;
        }

        public async Task<List<WareHouse>> GetAllAsync()
        {
            var wareHouses = await _wareHouseRepository.GetAllAsync();
            var res = (from wareHouse in wareHouses select _mapper.Map<WareHouse>(wareHouse)).ToList();
            return res;
        }
        public async Task<WareHouse> GetByIdAsync(int id)
        {
            return _mapper.Map<WareHouse>(await _wareHouseRepository.GetByIdAsync(id)); 
        }
    }
}
