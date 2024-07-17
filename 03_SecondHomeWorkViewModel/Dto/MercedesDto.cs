using _03_SecondHomeWorkViewModel.Entities;
using _03_SecondHomeWorkViewModel.Models;
using AutoMapper;
namespace _03_SecondHomeWorkViewModel.MapperProfiles
{
    public class MercedesDto : Profile
    {
        public MercedesDto()
        {
            CreateMap<MercedesModel, Mercedes>().ReverseMap();
        }
    }
}
