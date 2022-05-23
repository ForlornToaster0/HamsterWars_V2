using WebApi.Models;

namespace WebApi.Repository
{
    public interface IHamsterRepository
    {
        Task<IEnumerable<Hamster>> GetHamsters();
        Task<Hamster> GetRandomHamster();
        Task<Hamster> CreateHamster(Hamster hamster);
        Task<Hamster> DeleteHamster(int id);
        Task<Hamster> GetHamster(int id);
        Task<Hamster> UpdateHamster(int id);

        
    }
}
