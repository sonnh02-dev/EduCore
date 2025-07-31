﻿
using EduCore.BackEnd.Domain.Aggregates.UserProfileAggregate;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class ProfileRepository : GenericRepository<UserProfile>, IProfileRepository
    {
        public ProfileRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }
       
        
        
        
        
        //public async Task DeleteUserById(int userId)
        //{
        //    var userCourses = _entitySet.FirstOrDefault(u => u.UserId == userId).Courses;
        //    if (userCourses != null)
        //    {
        //        foreach (var c in userCourses)
        //        {
        //            c.InstructorId = null;
        //        }
        //        _dbContext.UpdateRange(userCourses);
        //    }


        //        _dbContext.Remove(_entitySet.Include(u => u.StudentCertificates)
        //            .Include(u => u.Reviews)
        //            .Include(u => u.StudentCourses)
        //            .Include(u => u.SystemSettings)
        //            .Include(u => u.Enrollments)
        //            .Include(u => u.Checkouts).FirstOrDefaultAsync(u => u.UserId == userId));



        //}


    }
}
