using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Application.Module.Comments.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Comments
{
    public interface ICommentService
    {
        public Task AddComment(CreateCommentRequest comment);
        //public Task<CommentDTO> GetCommentById(int id);
    }
}
