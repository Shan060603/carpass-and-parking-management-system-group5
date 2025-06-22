using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carpass_Profilling.Models
{
    public class Pending
    {
        [Key]
        public int pending_ID { get; set; }
        public int? kiosk_Id { get; set; }
        public string? fullName { get; set; }
        public string? type_Applicant { get; set; }
        public string? type_Carpass { get; set; }
        public string? name_Student { get; set; }
        public string? course_Grade { get; set; }
        public string? app_Relation { get; set; }
        public string? home_Ad { get; set; }
        public string? app_Contact { get; set; }
        public string? ve_Owner { get; set; }
        public string? ve_Relation { get; set; }
        public string? ve_PlateNO { get; set; }
        public string? ve_Brand { get; set; }
        public string? ve_Type { get; set; }
        public string? ve_Series { get; set; }
        public string? ve_Color { get; set; }
        public string? schoolyear { get; set; }
        public DateOnly? facefile_Date { get; set; }
        public bool IsDoc1Submitted { get; set; }
        public bool IsDoc2Submitted { get; set; }
        public bool IsDoc3Submitted { get; set; }
        public bool IsDoc4Submitted { get; set; }
        public bool IsDoc5Submitted { get; set; }
        public bool IsDoc6Submitted { get; set; }
        public bool IsDoc7Submitted { get; set; }

        public byte[]? Doc1 { get; set; }
        public byte[]? Doc2 { get; set; }
        public byte[]? Doc3 { get; set; }
        public byte[]? Doc4 { get; set; }
        public byte[]? Doc5 { get; set; }
        public byte[]? Doc6 { get; set; }
        public byte[]? Doc7 { get; set; }

        public Applicant Applicant { get; set; }
    }
}
