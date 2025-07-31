using EduCore.BackEnd.Domain.Aggregates.InstructorAggregate;
using EduCore.BackEnd.Domain.Common.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Contracts
{
    public interface IInstructorRepository : IGenericRepository<Instructor>
    {
        //public IQueryable<Instructor> GetListInstructor();
        //public Task<Instructor> GetInstructorDetailById(int instructorId);

    }
}
