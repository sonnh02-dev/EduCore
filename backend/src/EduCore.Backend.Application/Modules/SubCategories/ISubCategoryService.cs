﻿using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.SubCategories
{
    public interface ISubCategoryService
    {
        public Task<List<SubCategoryResponse>> GetAllSubCategory();
    }
}
