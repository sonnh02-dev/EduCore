using EduCore.BackEnd.Domain.Aggregates.CategoryAggregate;
using EduCore.BackEnd.Domain.Aggregates.CertificateAggregate;
using EduCore.BackEnd.Domain.Aggregates.CommentAggregate;
using EduCore.BackEnd.Domain.Aggregates.CourseAggregate;
using EduCore.BackEnd.Domain.Aggregates.EnrollmentAggregate;
using EduCore.BackEnd.Domain.Aggregates.ReviewAggregate;
using EduCore.BackEnd.Domain.Aggregates.StudentAggregate;
using EduCore.BackEnd.Domain.Contracts;

namespace EduCore.BackEnd.Domain.Common.Repositories
{
    public interface IUnitOfWork
    {     
        IProfileRepository ProfileRepository { get; }

        ICourseRepository CourseRepository { get; }

        IReviewRepository ReviewRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        IPaymentRepository CheckoutRepository { get; }

        IStudentCourseRepository StudentCourseRepository { get; }

        ILectureRepository LectureRepository { get; }

        IEnrollmentRepository EnrollmentRepository { get; }

        ISectionRepository SectionRepository { get; }

        ISubCategoryRepository SubCategoryRepository {  get; }

        IInstructorRepository  InstructorRepository { get; }

         ICertificateRepositoty CertificateRepositoty {  get; }

        ICommentRepository CommentRepository { get; }

        IStudentRepository StudentRepository { get; }

        ICompletionStatusRepository CompletionStatusRepository { get; }

        void Commit();

        void Rollback();

        Task CommitAsync();

        Task RollbackAsync();


    }
}
