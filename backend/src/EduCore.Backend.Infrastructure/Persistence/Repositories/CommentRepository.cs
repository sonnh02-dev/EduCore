using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(EduCoreDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddComment(Comment comment)
        {
            this.Add(comment);
        }

        public async Task<Comment> GetCommentById(int CommentId)
        {
            return await GetCommentListByInclude().FirstOrDefaultAsync(c => c.Id == CommentId);
        }

        public IQueryable<Comment> GetCommentListByInclude()
        {
            return _entitySet.Include(co => co.CreatorProfile).Include(co => co.Lecture)
                .Include(co => co.Replies);
        }

        public async Task<List<Comment>> GetListRepliedCommentByLectureId(int lectureId)
        {

            var replidComments = GetCommentListByInclude().Where(co => co.LectureId == lectureId && co.ParentCommentId == null).ToList();


            return replidComments;
        }


    }
}
