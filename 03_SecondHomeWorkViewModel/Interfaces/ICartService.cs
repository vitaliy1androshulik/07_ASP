using _03_SecondHomeWorkViewModel.MapperProfiles;

namespace _03_SecondHomeWorkViewModel.Interfaces
{
    public interface ICartService
    {
         List<MercedesDto> GetProducts();
         int GetCount();
         void Add(int id);
         void Remove(int id);
    }
}
