using AutoMapper;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Common.Repositories;

namespace EduCore.BackEnd.Application.Module.Certificates
{
    public class CertificateService : ICertificateService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;


        public CertificateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        //public async Task<IEnumerable<CertificateDTO>> GetListCertificate()
        //{
        //    return _mapper.Map<IEnumerable<CertificateDTO>>(await _unitOfWork.CertificateRepositoty.GetAll());
        //}
    }
}
