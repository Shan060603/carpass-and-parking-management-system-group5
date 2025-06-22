using Carpass_Profilling.Models;

namespace Carpass_Profilling.Service
{
    public interface IPendingService
    {
        Task<List<Pending>> GetAllPendingsAsync();
        Task<Pending> GetPendingsByIdAsync(int id);
        Task AddPendingsAsync(Pending pending);
        Task UpdatePendingsAsync(Pending pending, int id);
        Task DeletePendingsAsync(int id);
    }
}
