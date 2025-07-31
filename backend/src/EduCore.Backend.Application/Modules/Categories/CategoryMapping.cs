using Profile = AutoMapper.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;

namespace EduCore.BackEnd.Application.Module.Categories
{
    public class CategoryMapping : Profile

    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryResponse>().ReverseMap();
                           

        }
    }
}
