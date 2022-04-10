using ApplicationLayer.Responses;
using AutoMapper;
using BusinessObjects.Models;
using BusinessObjects.RequestObjects;
using DataLayer.Interface;
using System.Net;
using DomainWareHouse = DataLayer.Models.WareHouse;

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

        public async Task<ActionResultResponse<List<WareHouse>>> GetAllAsync()
        {
            var wareHouses = await _wareHouseRepository.GetAllAsync();
            var res = (from wareHouse in wareHouses select _mapper.Map<WareHouse>(wareHouse)).ToList();
            return new ActionResultResponse<List<WareHouse>>(res);
        }

        public async Task<ActionResultResponse<WareHouse>> GetByIdAsync(int id)
        {
            var entity = _mapper.Map<WareHouse>(await _wareHouseRepository.GetByIdAsync(id));
            return entity == null
                ? new ActionResultResponse<WareHouse>(new ResponseErrors(HttpStatusCode.NotFound, $"WareHouse {id} was not found."))
                : new ActionResultResponse<WareHouse>(entity);
        }

        public async Task<ActionResultResponse<WareHouse>> Create(CreateWareHouse wareHouse)
        {
            var entity = await _wareHouseRepository.GetWareHouseByCode(wareHouse.WareHouseCode);
            if (entity != null)
                return new ActionResultResponse<WareHouse>(new ResponseErrors(HttpStatusCode.Conflict, $"WareHouse Code{wareHouse.WareHouseCode} already exists."));
            entity = _mapper.Map<DomainWareHouse>(wareHouse);
            entity.CreatedBy = string.Empty;
            entity.CreatedAt = DateTime.Now;
            await _wareHouseRepository.AddAsync(entity);
            var result = _mapper.Map<WareHouse>(await _wareHouseRepository.GetWareHouseByCode(wareHouse.WareHouseCode));
            return new ActionResultResponse<WareHouse>(result);

        }
    }
}
