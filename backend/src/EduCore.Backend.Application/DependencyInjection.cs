using Microsoft.Extensions.DependencyInjection;
using EduCore.BackEnd.Application.Interfaces.Services;
using EduCore.BackEnd.Application.Services;
using EduCore.BackEnd.Application.Module.Courses;
using EduCore.BackEnd.Application.Module.Comments;
using EduCore.BackEnd.Application.Module.Certificates;
using EduCore.BackEnd.Application.Module.Categories;
using EduCore.BackEnd.Application.Module.Enrollments;
using EduCore.BackEnd.Application.Modules.Lectures;
using EduCore.BackEnd.Application.Modules.Instructors;
using EduCore.BackEnd.Application.Modules.Payments;
using EduCore.BackEnd.Application.Modules.Reviews;
using EduCore.BackEnd.Application.Modules.Students;
using EduCore.BackEnd.Application.Modules.SubCategories;
using EduCore.BackEnd.Application.Modules.Sections;

namespace EduCore.BackEnd.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddScoped<IPaymentGatewayService, VnPayGatewayService>();

        // Register scoped services
       services.AddScoped<ICourseService, CourseService>();
       services.AddScoped<ISectionService, SectionService>();
       services.AddScoped<ISubCategoryService, SubCategoryService>();
       services.AddScoped<ICategoryService, CategoryService>();
       services.AddScoped<IReviewService, ReviewService>();
       services.AddScoped<IInstructorService, InstructorService>();
       services.AddScoped<ICertificateService, CertificateService>();
       services.AddScoped<IStudentService, StudentService>();
       services.AddScoped<IUserService, UserService>();
       services.AddScoped<ILectureService, LectureService>();
       services.AddScoped<ICommentService, CommentService>();
        //builder.Services.AddScoped<IAIService, AIService>();
       services.AddScoped<IEnrollmentService, EnrollmentService>();
       services.AddScoped<ICheckoutService, CheckoutService>();
       //services.AddScoped<IEmailService, EmailService>();
       //services.AddScoped<IVnPayService, VnPayService>();
       //services.AddScoped<ICompletionStatusService, CompletionStatusServicec>();


        return services;

    }
}
