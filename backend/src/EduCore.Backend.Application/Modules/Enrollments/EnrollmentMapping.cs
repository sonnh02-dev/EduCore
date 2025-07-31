﻿using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Module.Enrollments
{
    public class EnrollmentMapping : Profile
    {
        public EnrollmentMapping()
        {
           // CreateMap<Enrollment, EnrollmentDTO>()
           //        .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
           //        .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId))
           //        .ForMember(dest => dest.EnrollmentDate, opt => opt.MapFrom(src => src.EnrollmentDate)).ReverseMap();

           // CreateMap<Enrollment, EnrollmentDetailDTO>()
           //.IncludeBase<Enrollment, EnrollmentDTO>()
           //.ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.FullName))
           //.ForMember(dest => dest.StudentImage, opt => opt.MapFrom(src => src.Student.UrlImage))
           //.ForMember(dest => dest.CourseTitle, opt => opt.MapFrom(src => src.Course.Title))
           //.ForMember(dest => dest.CourseImage, opt => opt.MapFrom(src => src.Course.Url))
           //.ForMember(dest => dest.CoursePrice, opt => opt.MapFrom(src => src.Course.Price))
           //.ForMember(dest => dest.CourseSale, opt => opt.MapFrom(src => src.Course.Sale))
           //.ForMember(dest => dest.CourseInstructorId, opt => opt.MapFrom(src => src.Course.InstructorId)).ReverseMap();
        }
    }
}
