﻿using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Students
{
    public class StudentMapping : Profile
    {
        public StudentMapping()
        {
            //CreateMap<User, StudentDTO>()
            //             .IncludeBase<User, UserDTO>()
            //                .ForMember(dest => dest.NumberEnrolledCourses, opt => opt.MapFrom(opt => opt.Enrollments.Count()))
            //                .ForMember(dest => dest.TuitionFee, opt => opt.MapFrom(opt => opt.Enrollments.Sum(en=>en.Course.Price-(en.Course.Price*en.Course.Sale/100) )))
            //                .ReverseMap();

              }
    }
}
