using EduCore.BackEnd.Domain.Aggregates.CourseAggregate.Entities;
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
    public class LectureRepository : GenericRepository<Lecture>, ILectureRepository
    {
        public LectureRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }
        //public IQueryable<Lecture> GetListLectureByInclude()
        //{
        //    return _entitySet.Include(l => l.Section).Include(l => l.Comments).ThenInclude(c => c.User)
        //         .Include(l => l.Exercises).ThenInclude(ex => ex.Questions).ThenInclude(q => q.Answers);
        //}

        //public async Task<Lecture> GetLectureDetailById(int id)
        //{
        //    return GetListLectureByInclude().FirstOrDefault(l => l.LectureId.Equals(id));
        //}
    }


}
