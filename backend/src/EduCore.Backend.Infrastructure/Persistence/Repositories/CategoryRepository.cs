using AutoMapper;
using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> IsExistingCategory(int? cateId)
        {
            return await _entitySet.AnyAsync(c => c.Id == cateId);

        }
        public IQueryable<Category> GetAllCategory()
        {
            return _entitySet.Include(c => c.SubCategories);
        }
        public async Task<Category> GetCategoryByCateId(int cateId)
        {
            return await GetAllCategory().FirstOrDefaultAsync(c => c.Id == cateId);

        }


        public void Delete(Category category)
        {
            _dbContext.Categories.Remove(category);
        }

    }
}
