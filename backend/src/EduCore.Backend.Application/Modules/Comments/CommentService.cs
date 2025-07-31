﻿using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Application.Module.Comments.DTOs;
using EduCore.BackEnd.Domain.Common.Repositories;
using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;

namespace EduCore.BackEnd.Application.Module.Comments
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task AddComment(CreateCommentRequest comment)
        {
            try
            {
                var c = mapper.Map<Comment>(comment);
                unitOfWork.CommentRepository.Add(c);
                unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
            }
        }

        //public async Task<CommentResponse> GetCommentById(int id)
        //{

        //    return mapper.Map<CommentResponse>(await unitOfWork.CommentRepository.GetCommentById(id));
        //}
    }
}
