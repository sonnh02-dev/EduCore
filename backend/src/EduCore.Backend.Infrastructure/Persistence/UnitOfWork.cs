using AutoMapper;
using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Domain.Aggregates.CertificateAggregate;
using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using EduCore.BackEnd.Domain.Aggregates.ReviewAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Domain.Common.Repositories;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;

namespace EduCore.BackEnd.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EduCoreDbContext _dbContext;

        private IProfileRepository _profileRepository;

        private ICourseRepository _courseRepository;

        private IReviewRepository _reviewRepository;

        private IEnrollmentRepository _enrollmentRepository;

        private IPaymentRepository _checkoutRepository;

        private ICategoryRepository _categoryRepository;

        private ISectionRepository _sectionRepository;

        private ILectureRepository _lectureRepository;

        private ISubCategoryRepository _subCategoryRepository;

        private IInstructorRepository _instructorRepository;

        private IStudentCourseRepository _studentCourseRepository;

        private IStudentRepository _studentRepository;

        private ICommentRepository _commentRepository;

        private ICertificateRepositoty _certificateRepositoty;

        private ICompletionStatusRepository _completionStatusRepository;

        public UnitOfWork(EduCoreDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public ILectureRepository LectureRepository => _lectureRepository ?? new LectureRepository(_dbContext);

        public ICertificateRepositoty CertificateRepositoty => _certificateRepositoty ?? new CertificateRepository(_dbContext);

        public IInstructorRepository InstructorRepository => _instructorRepository ?? new InstructorRepository(_dbContext);

        public ISubCategoryRepository SubCategoryRepository => _subCategoryRepository ?? new SubCategoryRepository(_dbContext);

        public IProfileRepository ProfileRepository => _profileRepository ?? new ProfileRepository(_dbContext);

        public ICourseRepository CourseRepository => _courseRepository ?? new CourseRepository(_dbContext);

        public IReviewRepository ReviewRepository => _reviewRepository ?? new ReviewRepository(_dbContext);

        public IPaymentRepository CheckoutRepository => _checkoutRepository ?? new PaymentRepository(_dbContext);

        public IEnrollmentRepository EnrollmentRepository => _enrollmentRepository ?? new EnrollmentRepository(_dbContext);

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_dbContext);

        public ISectionRepository SectionRepository => _sectionRepository ?? new SectionRepository(_dbContext);

        public IStudentCourseRepository StudentCourseRepository => _studentCourseRepository ?? new StudentCourseRepository(_dbContext);

        public IStudentRepository StudentRepository => _studentRepository ?? new StudentRepository(_dbContext);

        public ICommentRepository CommentRepository => _commentRepository ?? new CommentRepository(_dbContext);

        public ICompletionStatusRepository CompletionStatusRepository => _completionStatusRepository ?? new CompletionStatusRepository(_dbContext);

        public void Commit() => _dbContext.SaveChanges();

        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();

        public void Rollback() => _dbContext.Dispose();

        public async Task RollbackAsync() => await _dbContext.DisposeAsync();


    }
}
