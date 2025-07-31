using EduCore.BackEnd.Application.Module.Certificates;
using System.Text.Json.Serialization;

namespace EduCore.BackEnd.Application.Modules.Students.DTOs
{
    public class StudentCertificateResponse : CertificateResponse
    {
        public DateTime CompletedAt { get; set; }
        public string StudentName { get; set; }
        public string StudentImageUrl { get; set; }
      
    }
}
