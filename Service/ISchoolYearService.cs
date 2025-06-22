using Carpass_Profilling.Data;
using Carpass_Profilling.Models;
using Microsoft.EntityFrameworkCore;

namespace Carpass_Profilling.Service
{
    public interface ISchoolYearService
    {
        Task<string> GetSchoolYearAsync();
        Task SaveSchoolYearAsync(string schoolYear);
    }

    public class SchoolYearService : ISchoolYearService
    {
        private readonly DataContext _context;

        public SchoolYearService(DataContext context)
        {
            _context = context;
        }

        public async Task<string> GetSchoolYearAsync()
        {
            var schoolYear = await _context.Syear.FirstOrDefaultAsync();
            return schoolYear?.Year ?? string.Empty; // Assuming 'Year' is the property of the Schoolyear model
        }

        public async Task SaveSchoolYearAsync(string schoolYear)
        {
            var existingSchoolYear = await _context.Syear.FirstOrDefaultAsync();

            if (existingSchoolYear != null)
            {
                existingSchoolYear.Year = schoolYear; // Assuming 'Year' is the property of the Schoolyear model
                _context.Syear.Update(existingSchoolYear);
            }
            else
            {
                var newSchoolYear = new Schoolyear { Year = schoolYear }; // Assuming 'Year' is the property of the Schoolyear model
                await _context.Syear.AddAsync(newSchoolYear);
            }

            await _context.SaveChangesAsync();
        }
    }
}
