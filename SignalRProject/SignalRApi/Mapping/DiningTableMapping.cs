using AutoMapper;
using SignalR.DtoLayer.DiningTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class DiningTableMapping : Profile
    {
        public DiningTableMapping()
        {
            CreateMap<DiningTable, ResultDiningTableDto>();
            CreateMap<DiningTable, CreateDiningTableDto>();
            CreateMap<DiningTable, UpdateDiningTableDto>();
        }
    }
}
