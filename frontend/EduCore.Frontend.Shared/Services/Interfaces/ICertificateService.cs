using EduCore.Frontend.Shared.ViewModels;

﻿

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface ICertificateService
    {
        public Task<List<CertificateViewModel>> GetCertificates();
        public Task<int> GetNumberCertificates();

    }
}
