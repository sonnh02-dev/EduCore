using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Application.DTOs.Response;

namespace EduCore.BackEnd.Application.Module.Certificates
{
    public class CertificateMapping : Profile
    {
        public CertificateMapping()
        {
            //CreateMap<Certificate, CertificateResponse>()
            //     .ForMember(dest => dest.IssuerName, config => config.MapFrom(src => src.Course.InstructorProfile.FullName))
            //     .ForMember(dest => dest.IssuerImageUrl, config => config.MapFrom(src => src.Course.InstructorProfile.UrlImage))
            //      .ReverseMap();

            //CreateMap<Certificate, CertificateDetailDTO>()
            //    .IncludeBase<Certificate, CertificateDTO>()
            //   .ForMember(dest => dest.CompletedAt, config => config.MapFrom(src => src.StudentCertificates.FirstOrDefault(st => st.CertificateId == src.CertificateId).CompletionDate))
            //          .ReverseMap();
        }
    }
}
