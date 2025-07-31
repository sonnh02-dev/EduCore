using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    internal class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<SubCategory>> GetAllSubCategory()
        {
            return _entitySet.ToListAsync();
        }

        public async Task<bool> IsExistingSubCategory(int? cateId)
        {
            return await _entitySet.AnyAsync(c => c.CategoryId == cateId);

        }
    }
}
