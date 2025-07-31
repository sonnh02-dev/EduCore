using Profile = AutoMapper.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;

namespace EduCore.BackEnd.Application.Modules.SubCategories
{
    public class SubCategoryMapping : Profile

    {
        public SubCategoryMapping()
        {
            CreateMap<SubCategory, SubCategoryResponse>()
            //    .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(opt => opt.SubCategoryId))
            //     .ForMember(dest => dest.SubCategoryName, opt => opt.MapFrom(opt => opt.Name)).ReverseMap();

            //CreateMap<SubCategory, SubCategoryDetailDTO >()
            //    .IncludeBase<SubCategory, SubCategoryDTO>()
            //  .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(opt => opt.Category.CategoryId))
            //   .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(opt => opt.Category.Name))
                        .ReverseMap();
        }
    }
}
