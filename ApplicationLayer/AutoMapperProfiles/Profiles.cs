using AutoMapper;
using BusinessObjects.DTO;
using BusinessObjects.RequestObjects;
using DataLayer.Models;

namespace ApplicationLayer.AutoMapperProfiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            // WareHouse Mapper
            CreateMap<WareHouse, WareHouseDto>().ReverseMap();
            CreateMap<WareHouseRequest, WareHouse>().ReverseMap();
        }
    }
}
