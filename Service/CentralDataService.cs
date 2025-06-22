using Carpass_Profilling.Data;
using Carpass_Profilling.Models;
using Microsoft.EntityFrameworkCore;

namespace Carpass_Profilling.Service
{
    public class CentralDataService : ICentralDataService
    {
        private readonly DataContext _context;
        public CentralDataService(DataContext context)
        {
            _context = context;
        }
        public async Task AddCentral_DatasAsync(Central_Data central_data)
        {
            _context.Central_Datas.Add(central_data);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCentral_DatasAsync(int id)
        {
            var central_data = await _context.Central_Datas.FindAsync(id);
            if (central_data != null)
            {
                _context.Central_Datas.Remove(central_data);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Central_Data>> GetAllCentral_DatasAsync()
        {
            var result = await _context.Central_Datas.ToListAsync();
            return result;
        }

        public async Task<Central_Data> GetCentral_DatasByIdAsync(int id)
        {
            var central_data = await _context.Central_Datas.FindAsync(id);
            return central_data;
        }

        public async Task UpdateCentral_DatasAsync(Central_Data central_data, int id)
        {
            var dbCentral_Data = await _context.Central_Datas.FindAsync(id);
            if (dbCentral_Data != null)
            {
                dbCentral_Data.fullname = central_data.fullname;
                dbCentral_Data.type_applicant = central_data.type_applicant;
                dbCentral_Data.type_carpass = central_data.type_carpass;
                dbCentral_Data.name_student = central_data.name_student;
                dbCentral_Data.course_grade = central_data.course_grade;
                dbCentral_Data.app_relation = central_data.app_relation;
                dbCentral_Data.home_ad = central_data.home_ad;
                dbCentral_Data.app_contact = central_data.app_contact;
                dbCentral_Data.ve_owner = central_data.ve_owner;
                dbCentral_Data.ve_relation = central_data.ve_relation;
                dbCentral_Data.ve_plateno = central_data.ve_plateno;
                dbCentral_Data.ve_brand = central_data.ve_brand;
                dbCentral_Data.ve_type = central_data.ve_type;
                dbCentral_Data.ve_series = central_data.ve_series;
                dbCentral_Data.ve_color = central_data.ve_color;
                dbCentral_Data.carpass_no = central_data.carpass_no;
                dbCentral_Data.ref_number = central_data.ref_number;
                dbCentral_Data.issued_by = central_data.issued_by;
                dbCentral_Data.sub_Date = central_data.sub_Date;
                dbCentral_Data.app_Date = central_data.app_Date;
                dbCentral_Data.Doc1 = central_data.Doc1;
                dbCentral_Data.Doc1 = central_data.Doc2;
                dbCentral_Data.Doc1 = central_data.Doc3;
                dbCentral_Data.Doc1 = central_data.Doc4;
                dbCentral_Data.Doc1 = central_data.Doc5;
                dbCentral_Data.Doc1 = central_data.Doc6;
                dbCentral_Data.Doc1 = central_data.Doc7;
                await _context.SaveChangesAsync();
            }
        }
    }
}
