using EduCore.Frontend.Shared.ViewModels;


namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryViewModel> GetCategoryByCateId(int cateId);
        public Task<List<CategoryViewModel>> GetListCategory();
        Task<bool> UpdateCategory(CategoryViewModel category);
        Task DeleteCategory(int categoryId);
        Task AddCategory(CategoryViewModel category);
        public  Task<int> GetNumberCategories();

    }
}
