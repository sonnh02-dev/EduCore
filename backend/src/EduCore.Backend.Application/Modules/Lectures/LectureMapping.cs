﻿using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Lectures
{
    internal class LectureMapping : Profile
    {

        public LectureMapping()
        {
            //CreateMap<Lecture, LectureDTO>().
            //    ForMember(dest => dest.LectureId, opt => opt.MapFrom(opt => opt.LectureId)).
            //                    ForMember(dest => dest.Title, opt => opt.MapFrom(opt => opt.Title))
            //                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src =>
            //                     src.Duration.HasValue ? src.Duration.Value.ToString(@"hh\:mm") : "")).ReverseMap();

            //     CreateMap<Lecture, LectureDetailDTO>()
            //    .IncludeBase<Lecture, LectureDTO>()

            //      .ForMember(dest => dest.SectionId, opt => opt.MapFrom(opt => opt.SectionId))
            //      .ForMember(dest => dest.SectionTitle, opt => opt.MapFrom(opt => opt.Section.Title))
            //      .ForMember(dest => dest.Content, opt => opt.MapFrom(opt => opt.Content))
            //      .ForMember(dest => dest.VideoUrl, opt => opt.MapFrom(opt => opt.VideoUrl))
            //      .ForMember(dest => dest.Comments, opt => opt.MapFrom(opt => opt.Comments))
            //      .ForMember(dest => dest.Exercises, opt => opt.MapFrom(opt => opt.Exercises)).
            //      ReverseMap();







        }

    }
}
