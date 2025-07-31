using AutoMapper;
using AutoMapper.QueryableExtensions;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Domain.Common.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduCore.BackEnd.Application.Module.Courses
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapperConfig;

        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _mapperConfig = mapper.ConfigurationProvider;
        }

        //public async Task AddCourse(CourseDTO cDTO)
        //{
        //    try
        //    {
        //        var c = _mapper.Map<Course>(cDTO);

        //        if (!await _unitOfWork.SubCategoryRepository.IsExistingSubCategory(cDTO.SubCategoryId) && cDTO.SubCategoryId != null)
        //        {
        //            var newSubCategory = new SubCategory { Name = $"SubCategory{cDTO.SubCategoryId}" };
        //            _unitOfWork.SubCategoryRepository.Add(newSubCategory);
        //            c.SubCategory = newSubCategory;
        //        }

        //        if (await _unitOfWork.UserRepository.GetAsync(u => u.UserId == cDTO.InstructorId) == null && cDTO.InstructorId != null)
        //        {
        //            var newInstructor = new User { Email = $"user{cDTO.InstructorId}@gmail.com", Password = "123" };
        //            _unitOfWork.UserRepository.Add(newInstructor);
        //            c.Instructor = newInstructor;
        //        }

        //        _unitOfWork.CourseRepository.Add(c);
        //        _unitOfWork.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        _unitOfWork.Rollback();
        //        throw new Exception("Failed to add course.", ex);
        //    }
        //}

        //public async Task UpdateCourse(CourseDTO cDTO, int Id)
        //{
        //    try
        //    {
        //        if (await _unitOfWork.CourseRepository.IsExistingCourse(Id))
        //        {
        //            var c = _mapper.Map<Course>(cDTO);
        //            c.Id = Id;

        //            if (!await _unitOfWork.SubCategoryRepository.IsExistingSubCategory(cDTO.SubCategoryId) && cDTO.SubCategoryId != null)
        //            {
        //                var newSubCategory = new SubCategory { Name = $"SubCategory{cDTO.SubCategoryId}" };
        //                _unitOfWork.SubCategoryRepository.Add(newSubCategory);
        //                c.SubCategory = newSubCategory;
        //            }

        //            if (await _unitOfWork.UserRepository.Get(u => u.UserId == cDTO.InstructorId) == null && cDTO.InstructorId != null)
        //            {
        //                var newInstructor = new User { Email = $"user{cDTO.InstructorId}@gmail.com", Password = "123" };
        //                _unitOfWork.UserRepository.Add(newInstructor);
        //                c.Instructor = newInstructor;
        //            }

        //            _unitOfWork.CourseRepository.Update(c);
        //            _unitOfWork.Commit();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _unitOfWork.Rollback();
        //        throw new Exception("Failed to update course.", ex);
        //    }
        //}

        public async Task DeleteCourse(Course course)
        {
            _unitOfWork.CourseRepository.Remove(course);
            _unitOfWork.Commit();
        }

        //public async Task<IEnumerable<CourseDTO>> GetCoursesInCartByStudentId(int stdId, bool isInCart)
        //{
        //    return await _unitOfWork.CourseRepository
        //        .GetListCourseByStudentId(stdId, isInCart)
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();
        //}

        //public async Task<IEnumerable<CourseDTO>> GetListCourse()
        //{
        //    return await _unitOfWork.CourseRepository
        //        .GetListCourse()
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();
        //}

       

        //public async Task<IEnumerable<CourseDTO>> GetTopSellingCourses()
        //{
        //    return await _unitOfWork.CourseRepository
        //        .GetTopSellingCourses()
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();
        //}

        //public async Task<IEnumerable<CourseDTO>> GetTopSellingCoursesByCateId(int cateId)
        //{
        //    return await _unitOfWork.CourseRepository
        //        .GetTopSellingCoursesByCateId(cateId)
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();
        //}

        //public async Task<IEnumerable<CourseDTO>> GetTopSellingCoursesBySubCateId(int subCateId)
        //{
        //    return await _unitOfWork.CourseRepository
        //        .GetTopSellingCoursesBySubCateId(subCateId)
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();
        //}

        //public async Task<IEnumerable<CourseDTO>> GetListCourseByInstructorId(int instructorId)
        //{
        //    return await _unitOfWork.CourseRepository
        //        .GetListCourseByInstructorId(instructorId)
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();
        //}

        //public async Task<CourseDetailDTO> GetCourseDetailById(int cId)
        //{
        //    return _mapper.Map<CourseDetailDTO>(await _unitOfWork.CourseRepository.GetCourseDetailByCourseId(cId));
        //}

        //public async Task<CourseDetailDTO> GetStatusCourseDetailByStudentIdAndCourseId(int Id, int stdId)
        //{
        //    var courseDetail = await GetCourseDetailByCourseId(Id);

        //    courseDetail.IsCompleted = await IsCourseCompleted(Id, stdId);
        //    foreach (var section in courseDetail.Sections)
        //    {
        //        section.IsCompleted = await IsSectionCompleted(section.SectionId, stdId);
        //        var lectureStatuses = await _unitOfWork.CompletionStatusRepository.GetAllAsync(cs => cs.UserId == stdId && cs.Id == Id && cs.SectionId == section.SectionId);
        //        foreach (var lecture in section.Lectures)
        //        {
        //            lecture.IsCompleted = lectureStatuses.Any(cs => cs.LectureId == lecture.LectureId);
        //        }
        //    }

        //    return courseDetail;
        //}

        //public async Task<bool> IsSectionCompleted(int sectionId, int stdId)
        //{
        //    var lecturesInSection = await _unitOfWork.LectureRepository.GetAll(l => l.SectionId == sectionId);
        //    var completedLectures = await _unitOfWork.CompletionStatusRepository.GetAll(cs => lecturesInSection.Select(l => l.LectureId).Contains(cs.LectureId) && cs.UserId == stdId);

        //    return lecturesInSection.Count() == completedLectures.Count();
        //}

        //public async Task<bool> IsCourseCompleted(int Id, int stdId)
        //{
        //    var sectionsInCourse = await _unitOfWork.SectionRepository.GetAll(s => s.Id == Id);
        //    foreach (var section in sectionsInCourse)
        //    {
        //        if (!await IsSectionCompleted(section.SectionId, stdId))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //public async Task<IEnumerable<CourseDTO>> GetEnrolledCourseListByStudentId(int stdId)
        //{
        //    var enrolledCourses = await _unitOfWork.CourseRepository
        //        .GetEnrolledCourseListByStudentId(stdId)
        //        .ProjectTo<CourseDTO>(_mapperConfig)
        //        .ToListAsync();

        //    foreach (var course in enrolledCourses)
        //    {
        //        course.IsCompleted = await IsCourseCompleted(course.Id, stdId);
        //    }
        //    return enrolledCourses;
        //}
    }
}
