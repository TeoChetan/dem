using AutoMapper;
using TMS_API.Models;
using TMS_API.Models.DTO;

namespace TMS_API.Profiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Event, EventPatchDTO>().ReverseMap();
        }
    }
}
