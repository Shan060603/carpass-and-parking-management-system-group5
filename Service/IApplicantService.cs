using Carpass_Profilling.Models;

namespace Carpass_Profilling.Service
{
	public interface IApplicantService
	{
		Task<List<Applicant>> GetAllApplicantsAsync();
        Task<Applicant> GetApplicantsByIdAsync(int id);
        Task AddApplicantsAsync(Applicant applicant);
        Task UpdateApplicantsAsync(Applicant applicant, int id);
        Task DeleteApplicantsAsync(int id);


    }
}
