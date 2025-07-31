using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Answers
{

    public class AnswerMapping : Profile
    {
        public AnswerMapping()
        {
            //CreateMap<Answer, AnswerResponse>().ReverseMap();

        }
    }
}