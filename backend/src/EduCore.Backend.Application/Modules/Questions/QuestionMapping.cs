﻿using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Questions
{
    public class QuestionMapping : Profile
    {
        public QuestionMapping()
        {
            //CreateMap<Question, QuestionDTO>()
            //              .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(opt => opt.QuestionId))
            //              .ForMember(dest => dest.Text, opt => opt.MapFrom(opt => opt.Text))
            //              .ForMember(dest => dest.Answers, opt => opt.MapFrom(opt => opt.Answers))
            //              .ForMember(dest => dest.CorrectAnswer, opt => opt.MapFrom(opt => opt.Answers.FirstOrDefault(a => a.IsCorrect).Text))
            //             .ReverseMap();
        }
    }
}
