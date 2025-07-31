using EduCore.BackEnd.Application.Modules.SubCategories;
using System.ComponentModel.DataAnnotations;

namespace EduCore.BackEnd.Application.Module.Categories
{
    public  class CategoryResponse
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SubCategoryResponse>? SubCategories { get; set; }
    }
}
