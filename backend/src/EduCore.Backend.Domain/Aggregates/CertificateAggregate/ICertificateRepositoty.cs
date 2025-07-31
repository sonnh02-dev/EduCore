using EduCore.BackEnd.Domain.Common.Repositories;
using System;

namespace EduCore.BackEnd.Domain.Aggregates.CertificateAggregate
{
    public  interface ICertificateRepositoty:IGenericRepository<Certificate>
    {
        public Task<IEnumerable<Certificate>> GetListCertificate();
    }
}
