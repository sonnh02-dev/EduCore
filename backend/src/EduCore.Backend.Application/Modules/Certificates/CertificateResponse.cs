using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace EduCore.BackEnd.Application.Module.Certificates
{
    public class CertificateResponse
    {
     
        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string CertificateUrl { get; set; } = null!;

        public string IssuerName { get; set; } = null!;

        public string IssuerImageUrl { get; set; } = null!;

    }
}
