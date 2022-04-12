using ApplicationLayer.Responses;
using AutoMapper;
using BusinessObjects.DTO;
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

        public async Task<ActionResultResponse<List<WareHouseDto>>> GetAllAsync()
        {
            var wareHouses = await _wareHouseRepository.GetAllAsync();
            var res = (from wareHouse in wareHouses select _mapper.Map<WareHouseDto>(wareHouse)).ToList();
            return new ActionResultResponse<List<WareHouseDto>>(res);
        }

        public async Task<ActionResultResponse<WareHouseDto>> GetByIdAsync(int id)
        {
            var entity = _mapper.Map<WareHouseDto>(await _wareHouseRepository.GetByIdAsync(id));
            return entity == null
                ? new ActionResultResponse<WareHouseDto>(new ResponseErrors(HttpStatusCode.NotFound, $"WareHouse {id} was not found."))
                : new ActionResultResponse<WareHouseDto>(entity);
        }

        public async Task<ActionResultResponse<WareHouseDto>> CreateAsync(WareHouseRequest request)
        {
            var wareHouse = await _wareHouseRepository.GetWareHouseByCode(request.WareHouseCode);
            if (wareHouse != null)
                return new ActionResultResponse<WareHouseDto>(new ResponseErrors(HttpStatusCode.Conflict, $"WareHouse Code{request.WareHouseCode} already exists."));

            wareHouse = _mapper.Map<DomainWareHouse>(request);
            wareHouse.SetCreatedColumns();
            await _wareHouseRepository.AddAsync(wareHouse);

            var result = _mapper.Map<WareHouseDto>(await _wareHouseRepository.GetWareHouseByCode(request.WareHouseCode));
            return new ActionResultResponse<WareHouseDto>(result);

        }

        public async Task<ActionResultResponse<object>> UpdateAsync(int id, WareHouseRequest request)
        {
            var wareHouse = await _wareHouseRepository.GetByIdAsync(id);
            if (wareHouse == null)
                return new ActionResultResponse<object>(new ResponseErrors(HttpStatusCode.NotFound, $"WareHouse {id} was not found."));

            wareHouse = _mapper.Map(request, wareHouse);
            wareHouse.SetModifyColumns();
            await _wareHouseRepository.UpdateAsync(wareHouse);

            return new ActionResultResponse<object>(null);
        }

        public async Task<ActionResultResponse<object>> DeleteAsync(int id)
        {

            var wareHouse = await _wareHouseRepository.GetByIdAsync(id);
            if (wareHouse == null)
                return new ActionResultResponse<object>(new ResponseErrors(HttpStatusCode.NotFound, $"WareHouse {id} was not found."));

            wareHouse.Delete();
            await _wareHouseRepository.DeleteAsync(wareHouse);

            return new ActionResultResponse<object>(null);
        }
    }
}
