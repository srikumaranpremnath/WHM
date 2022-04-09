using AutoMapper;
using BusinessObjects.Models;

namespace ApplicationLayer.AutoMapperProfiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<WareHouse, DataLayer.Models.WareHouse>().ReverseMap();
        }
    }
}
