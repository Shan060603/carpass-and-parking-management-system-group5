using Carpass_Profilling.Data;
using Carpass_Profilling.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Carpass_Profilling.Service
{
    public class ApplicantService : IApplicantService
    {
        private readonly DataContext _context;
        public ApplicantService(DataContext context)
        {
            _context = context;
        }

        public async Task AddApplicantsAsync(Applicant applicant)
        {
            applicant.facefile_Date = DateOnly.FromDateTime(DateTime.Now);
            _context.Applicants.Add(applicant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteApplicantsAsync(int id)
        {
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant != null)
            {
                _context.Applicants.Remove(applicant);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Applicant>> GetAllApplicantsAsync()
        {
            var result = await _context.Applicants.ToListAsync();
            return result;
        }

        public async Task<Applicant> GetApplicantsByIdAsync(int id)
        {
            var applicant = await _context.Applicants.FindAsync(id);
            return applicant;
        }

        public async Task UpdateApplicantsAsync(Applicant applicant, int id)
        {
            var dbApplicant = await _context.Applicants.FindAsync(id);
            if (dbApplicant != null)
            {
                dbApplicant.fullName = applicant.fullName;
                dbApplicant.type_Applicant = applicant.type_Applicant;
                dbApplicant.type_Carpass = applicant.type_Carpass;
                dbApplicant.name_Student = applicant.name_Student;
                dbApplicant.course_Grade = applicant.course_Grade;
                dbApplicant.app_Relation = applicant.app_Relation;
                dbApplicant.home_Ad = applicant.home_Ad;
                dbApplicant.app_Contact = applicant.app_Contact;
                dbApplicant.ve_Owner = applicant.ve_Owner;
                dbApplicant.ve_Relation = applicant.ve_Relation;
                dbApplicant.ve_PlateNO = applicant.ve_PlateNO;
                dbApplicant.ve_Brand = applicant.ve_Brand;
                dbApplicant.ve_Type = applicant.ve_Type;
                dbApplicant.ve_Series = applicant.ve_Series;
                dbApplicant.ve_Color = applicant.ve_Color;
                dbApplicant.Doc1 = applicant.Doc1;
                dbApplicant.Doc2 = applicant.Doc2;
                dbApplicant.Doc3 = applicant.Doc3;
                dbApplicant.Doc4 = applicant.Doc4;
                dbApplicant.Doc5 = applicant.Doc5;
                dbApplicant.Doc6 = applicant.Doc6;
                dbApplicant.Doc7 = applicant.Doc7;

                dbApplicant.facefile_Date = DateOnly.FromDateTime(DateTime.Now);
                await _context.SaveChangesAsync();
            }
        }
    }
}
