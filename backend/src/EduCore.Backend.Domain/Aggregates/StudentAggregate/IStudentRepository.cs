using EduCore.BackEnd.Domain.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Aggregates.StudentAggregate
{
    public interface IStudentRepository : IGenericRepository<Student>

    {
        //public IQueryable<Student> GetListStudent();
    }
}
