﻿using Profile = AutoMapper.Profile;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Modules.Payments
{
    public  class PaymentMapping:Profile
    {
        public PaymentMapping()
        {
            //CreateMap<StudentPayment, CheckoutDTO>()
            // .ForMember(dest => dest.CheckoutId, opt => opt.MapFrom(src => src.CheckoutId))
            // .ForMember(dest => dest.StudentId, opt => opt.MapFrom(src => src.StudentId))
            // .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.FullName))
            // .ForMember(dest => dest.PaymentMethod, opt => opt.MapFrom(src => src.PaymentMethod))
            // .ForMember(dest => dest.PaymentStatus, opt => opt.MapFrom(src => src.PaymentStatus))
            // .ForMember(dest => dest.PaymentDate, opt => opt.MapFrom(src => src.PaymentDate))
            // .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId))
            // .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Title))
            // .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
             
            // .ReverseMap();
        }
    }
}
