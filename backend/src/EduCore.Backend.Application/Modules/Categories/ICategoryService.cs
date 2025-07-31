using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Categories
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryResponse>> GetListCategory();
        public Task<CategoryResponse> GetCategoryByCateId(int cateId);
        Task AddCategory(CategoryResponse cDTO);
        Task UpdateCategory(CategoryResponse cDTO);
        Task DeleteCategory(int cateId);
    }
}
