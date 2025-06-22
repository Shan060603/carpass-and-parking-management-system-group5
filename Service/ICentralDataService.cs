using Carpass_Profilling.Models;

namespace Carpass_Profilling.Service
{
    public interface ICentralDataService
    {
        Task<List<Central_Data>> GetAllCentral_DatasAsync();
        Task<Central_Data> GetCentral_DatasByIdAsync(int id);
        Task AddCentral_DatasAsync(Central_Data central_data);
        Task UpdateCentral_DatasAsync(Central_Data central_data, int id);
        Task DeleteCentral_DatasAsync(int id);
    }
}
