using AutoMapper;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Common.Repositories;

namespace EduCore.BackEnd.Application.Modules.SubCategories
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SubCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<SubCategoryResponse>> GetAllSubCategory()
        {
            var subCategories = await _unitOfWork.SubCategoryRepository.GetAllSubCategory();
            return _mapper.Map<List<SubCategoryResponse>>(subCategories);
        }
    }
}
