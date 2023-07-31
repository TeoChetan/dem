using TMS_API.Models.DTO;
using TMS_API.Models;
using AutoMapper;


namespace TMS_API.Profiles
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrdersDTO>().ReverseMap();
            CreateMap<Order, OrdersPatchDTO>().ReverseMap();
        }
    }
}
