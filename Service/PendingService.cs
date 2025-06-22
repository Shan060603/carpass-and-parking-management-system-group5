using Carpass_Profilling.Data;
using Carpass_Profilling.Models;
using Microsoft.EntityFrameworkCore;

namespace Carpass_Profilling.Service
{
    public class PendingService : IPendingService
    {
        private readonly DataContext _context;
        public PendingService(DataContext context)
        {
            _context = context;
        }
        public async Task AddPendingsAsync(Pending pending)
        {
            _context.Pendings.Add(pending);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePendingsAsync(int id)
        {
            var pending = await _context.Pendings.FindAsync(id);
            if (pending != null)
            { 
                _context.Pendings.Remove(pending);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Pending>> GetAllPendingsAsync()
        {
            var result = await _context.Pendings.ToListAsync();
            return result;
        }

        public async Task<Pending> GetPendingsByIdAsync(int id)
        {
            var pending = await _context.Pendings.FindAsync(id);
            return pending;
        }

        public async Task UpdatePendingsAsync(Pending pending, int id)
        {
            var dbPending = await _context.Pendings.FindAsync(id);
            if (dbPending != null)
            {
                dbPending.fullName = pending.fullName;
                dbPending.type_Applicant = pending.type_Applicant;
                dbPending.type_Carpass = pending.type_Carpass;
                dbPending.name_Student  = pending.name_Student;
                dbPending.course_Grade = pending.course_Grade;
                dbPending.app_Relation = pending.app_Relation;
                dbPending.home_Ad = pending.home_Ad;
                dbPending.app_Contact = pending.app_Contact;
                dbPending.ve_Owner = pending.ve_Owner;
                dbPending.ve_Relation = pending.ve_Relation;
                dbPending.ve_PlateNO = pending.ve_PlateNO;
                dbPending.ve_Brand = pending.ve_Brand;
                dbPending.ve_Type = pending.ve_Type;
                dbPending.ve_Series = pending.ve_Series;
                dbPending.ve_Color = pending.ve_Color;
                dbPending.facefile_Date = DateOnly.FromDateTime(DateTime.Now);
                dbPending.Doc1 = pending.Doc1;
                dbPending.Doc2 = pending.Doc2;
                dbPending.Doc3 = pending.Doc3;
                dbPending.Doc4 = pending.Doc4;
                dbPending.Doc5 = pending.Doc5;
                dbPending.Doc6 = pending.Doc6;
                dbPending.Doc7 = pending.Doc7;

                await _context.SaveChangesAsync();
            }
        }


    }
}
