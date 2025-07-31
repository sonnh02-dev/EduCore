using EduCore.BackEnd.Domain.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.SaleAggregate
{
    public interface ISaleRepository : IGenericRepository<Sale>
    {
        Task<IEnumerable<Sale>?> GetSalesByCourseId(int courseId, CancellationToken cancellationToken = default);

        Task<IEnumerable<Sale>> GetActiveSalesAsync(DateTime asOf, CancellationToken cancellationToken = default);
    }
}
