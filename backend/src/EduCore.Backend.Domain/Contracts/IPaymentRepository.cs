using EduCore.BackEnd.Domain.Common.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Contracts
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        //public IQueryable<Payment > GetListCheckoutByInclude();

    }
}
