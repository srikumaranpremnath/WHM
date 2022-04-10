using AutoMapper;
using BusinessObjects.Models;
using BusinessObjects.RequestObjects;

namespace ApplicationLayer.AutoMapperProfiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<WareHouse, DataLayer.Models.WareHouse>().ReverseMap();
            CreateMap<DataLayer.Models.WareHouse, CreateWareHouse>().ReverseMap();
        }
    }
}
