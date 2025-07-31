﻿using AutoMapper;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }

        public bool IsExitEnrollment(Enrollment enrollment)
        {
            return _entitySet.Any(e => e.StudentProfileId.Equals(enrollment.StudentProfileId) && e.CourseId == enrollment.CourseId);
        }


        //public async Task<List<RevenueDTO>> GetMonthlyRevenueByInstructorId(int revenueSharePercentage, int instructorId, int year)
        //{
        //    var monthlyRevenue = await _entitySet.Include(en => en.Course).
        //      Where(en => en.Course.InstructorProfileId == instructorId && en.CreatedAt.Year == year)
        //      .GroupBy(er => er.CreatedAt.Month)
        //      .Select(gr => new RevenueDTO
        //      {
        //          RevenueId = gr.Key,
        //          Month = gr.Key,
        //          Year = year,
        //          Amount = gr.Sum(en => (en.Course.Price - (en.Course.Price * en.Course.Sale / 100) ) * revenueSharePercentage / 100),
        //      }).ToListAsync();


        //    return monthlyRevenue;
        //} 
        
        //public async Task<List<RevenueDTO>> GetMonthlyRevenueBySoldCourses(int revenueSharePercentage, int year)
        //{
        //    var monthlyRevenue = await _entitySet.Include(en => en.Course).
        //      Where(en => en.EnrollmentDate.Year == year)
        //      .GroupBy(er => er.EnrollmentDate.Month)
        //      .Select(gr => new RevenueDTO
        //      {
        //          RevenueId = gr.Key,
        //          Month = gr.Key,
        //          Year = year,
        //          Amount = gr.Sum(en => (en.Course.Price - (en.Course.Price * en.Course.Sale / 100)) * revenueSharePercentage / 100),
        //      }).ToListAsync();


        //    return monthlyRevenue;
        //}
        //public IQueryable<Enrollment> GetListEnrollmentByInclude()
        //{
        //    return _entitySet.AsSplitQuery().Include(en => en.Course).Include(en => en.Student).AsNoTracking();

        //}
    }
}
