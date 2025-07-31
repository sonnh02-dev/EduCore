using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
using EduCore.BackEnd.Domain.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Contracts
{
    public interface ILectureRepository:IGenericRepository<Lecture>
    {
          //public Task< Lecture> GetLectureDetailById(int id);
    }
}
