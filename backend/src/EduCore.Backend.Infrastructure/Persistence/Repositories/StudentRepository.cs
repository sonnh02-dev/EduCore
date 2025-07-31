using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    internal class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }

        //public IQueryable<Student> GetListStudent()
        //{
        //    return _entitySet.Include(st => st.Enrollments).ThenInclude(en=>en.Course).Where(st=>st.RoleId==1);
        //}
    }
}
