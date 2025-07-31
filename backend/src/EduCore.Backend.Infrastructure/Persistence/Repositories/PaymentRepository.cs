using AutoMapper;

using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    internal class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }

        

        //public IQueryable<Payment> GetListCheckoutByInclude()
        //{
        //    return _entitySet.Include(c => c.Enrollment).Include(c => c.Student);
        //}

    }
}
