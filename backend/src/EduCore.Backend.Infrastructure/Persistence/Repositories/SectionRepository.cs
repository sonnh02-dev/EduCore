﻿using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class SectionRepository : GenericRepository<Section>, ISectionRepository
    {
        public SectionRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }
        public IQueryable<Section> GetListSectionByInclude()
        {
            return _entitySet.Include(s => s.Lectures);
                 
        }
        public async Task<IEnumerable<Section>> GetListSectionByCourseId(int courdId)
        {

            return await GetListSectionByInclude().Where(s => s.CourseId == courdId).ToListAsync();
        }
    }
}
