﻿using EduCore.BackEnd.Application.Modules.Students;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace EduCore.BackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        //[HttpGet("getListStudent")]
        //[EnableQuery]
        //public async Task<IActionResult> Get()
        //{
        //    var listUser = await _studentService.GetListStudent();
        //    return Ok(listUser);
        //}
        //[HttpPost("api/student-courses")]
        //public IActionResult AddStudentCourse([FromBody] AddCourseToCartViewMo model)
        //{
        //}

    }
}
