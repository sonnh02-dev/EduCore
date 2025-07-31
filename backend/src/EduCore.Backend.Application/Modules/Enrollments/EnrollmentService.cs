﻿using AutoMapper;
using EduCore.BackEnd.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Application.Module.Enrollments.DTOs;
using EduCore.BackEnd.Domain.Common.Repositories;
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;

namespace EduCore.BackEnd.Application.Module.Enrollments
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public EnrollmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task AddEnrollment(CreateEnrollmentRequest e)
        {
            Enrollment enrollment = mapper.Map<Enrollment>(e);

            if (!unitOfWork.EnrollmentRepository.IsExitEnrollment(enrollment))
            {
                unitOfWork.EnrollmentRepository.Add(enrollment);
                await unitOfWork.CommitAsync();

            }
            else
            {
                await unitOfWork.RollbackAsync();
                throw new Exception("Enrollment is exits!");
            }

        }
        //public async Task<List<EnrollmentDetailDTO>> GetListEnrollment()
        //{
        //    return mapper.Map<List<EnrollmentDetailDTO>>(await unitOfWork.EnrollmentRepository.GetListEnrollmentByInclude().ToListAsync());

        //}

        //public async Task<List<RevenueDTO>> GetMonthlyRevenueByInstructorId(int revenueSharePercentage, int instructorId, int year)
        //{
        //    return await unitOfWork.EnrollmentRepository.GetMonthlyRevenueByInstructorId(revenueSharePercentage ,instructorId, year);
        //}
        //public async Task<List<RevenueDTO>> GetMonthlyRevenueBySoldedCourses(int revenueSharePercentage, int year)
        //{
        //    return await unitOfWork.EnrollmentRepository.GetMonthlyRevenueBySoldCourses(revenueSharePercentage, year);
        //}
    }
}
