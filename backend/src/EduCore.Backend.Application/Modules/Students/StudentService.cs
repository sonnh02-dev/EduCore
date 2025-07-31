using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using EduCore.BackEnd.Domain.Common.Repositories;

namespace EduCore.BackEnd.Application.Modules.Students
{
    public class StudentService : IStudentService

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapperConfig;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _mapperConfig = mapper.ConfigurationProvider;
        }
        //public async Task <IEnumerable<StudentDTO>> GetListStudent()
        //{
        //    return  _unitOfWork.StudentRepository.GetListStudent().ToListAsync();
        //}
        //public async Task AddStudentCourse(StudentCourseDTO scDTO)
        //{
        //    var sc = _mapper.Map<StudentCourse>(scDTO);
        //    if (await _unitOfWork.StudentCourseRepository.Get(sc => sc.StudentProfileId.Equals() && sc.CourseId == scDTO.CourseId) == null)
        //    {
        //        _unitOfWork.StudentCourseRepository.Add(sc);
        //        _unitOfWork.Commit();
        //    }
        //}
    }
}
