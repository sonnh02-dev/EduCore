using AutoMapper;
using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Domain.Common.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Categories
{
    public class CategoryService : ICategoryService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        private readonly IMapper _mapper;


        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddCategory(CategoryResponse cDTO)
        {
            var category = _mapper.Map<Category>(cDTO);
            _unitOfWork.CategoryRepository.Add(category);
            await _unitOfWork.CommitAsync();
        }
        public async Task UpdateCategory(CategoryResponse categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            _unitOfWork.CategoryRepository.Update(category);
            await _unitOfWork.CommitAsync();
        }
        public async Task DeleteCategory(int categoryId)
        {
            var category = await _unitOfWork.CategoryRepository.GetCategoryByCateId(categoryId);
            if (category != null)
            {
                _unitOfWork.CategoryRepository.Remove(category);
                await _unitOfWork.CommitAsync();
            }
        }
        public async Task<IEnumerable<CategoryResponse>> GetListCategory()
        {
            return _mapper.Map<IEnumerable<CategoryResponse>>(await _unitOfWork.CategoryRepository.GetAllCategory().ToListAsync());
        }
        public async Task<CategoryResponse> GetCategoryByCateId(int cateId)
        {
            return _mapper.Map<CategoryResponse>(await _unitOfWork.CategoryRepository.GetCategoryByCateId(cateId));
        }

    }
}
