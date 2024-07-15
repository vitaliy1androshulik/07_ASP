using _03_SecondHomeWorkViewModel.Entities;
using _03_SecondHomeWorkViewModel.Models;
using AutoMapper;
namespace _03_SecondHomeWorkViewModel.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MercedesModel, Mercedes>().ReverseMap();
        }
    }
}
