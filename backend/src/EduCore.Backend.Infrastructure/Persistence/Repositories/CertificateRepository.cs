using EduCore.BackEnd.Domain.Aggregates.CertificateAggregate;
using EduCore.BackEnd.Infrastructure.Persistence;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories

{
    internal class CertificateRepository : GenericRepository<Certificate>, ICertificateRepositoty
    {
        public CertificateRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }

        public Task<IEnumerable<Certificate>> GetListCertificate()
        {
            throw new NotImplementedException();
        }
    }
}
