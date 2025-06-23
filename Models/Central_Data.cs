using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carpass_Profilling.Models
{
[Table("central_datas")]
	public class Central_Data
	{
        [Key]
        public int central_Id { get; set; }
        public int? pending_ID { get; set; }
        public string? fullname { get; set; }
        public string? type_applicant { get; set; }
        public string? type_carpass { get; set; }
        public string? name_student { get; set; }
        public string? course_grade { get; set; }
        public string? app_relation { get; set; }
        public string? home_ad { get; set; }
        public string? app_contact { get; set; }
        public string? ve_owner { get; set; }
        public string? ve_relation { get; set; }
        public string? ve_plateno { get; set; }
        public string? ve_brand { get; set; }
        public string? ve_type { get; set; }
        public string? ve_series { get; set; }
        public string? ve_color { get; set; }
        public string? carpass_no { get; set; }
        public string? ref_number { get; set; }
        public string? issued_by { get; set; }
        public string? schoolyear { get; set; }
        public DateOnly? sub_Date { get; set; }
        public DateOnly? app_Date { get; set; }
        public DateOnly? expiration_Date { get; set; }

        public byte[]? Doc1 { get; set; }
        public byte[]? Doc2 { get; set; }
        public byte[]? Doc3 { get; set; }
        public byte[]? Doc4 { get; set; }
        public byte[]? Doc5 { get; set; }
        public byte[]? Doc6 { get; set; }
        public byte[]? Doc7 { get; set; }

        public Pending Pending { get; set; }
    }
}
