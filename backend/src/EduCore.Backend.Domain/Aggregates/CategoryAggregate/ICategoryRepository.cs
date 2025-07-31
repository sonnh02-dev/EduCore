using EduCore.BackEnd.Domain.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.CategoryAggregate
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public Task<bool> IsExistingCategory(int? cateId);
        public IQueryable<Category> GetAllCategory();
        public Task<Category> GetCategoryByCateId(int cateId);



    }
}