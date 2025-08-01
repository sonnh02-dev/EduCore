using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using EduCore.BackEnd.Infrastructure;
using EduCore.BackEnd.Application.Module.Certificates;
using EduCore.BackEnd.Application.Module.Categories;
using EduCore.BackEnd.Application.Module.Courses.DTOs;
using EduCore.BackEnd.Application.Module.Enrollments.DTOs;
using EduCore.BackEnd.Application.Modules.Instructors;
using EduCore.BackEnd.Application.Modules.Reviews;
using EduCore.BackEnd.Application.Modules.Payments.DTOs;
using EduCore.BackEnd.Application.Modules.Students.DTOs;
using EduCore.BackEnd.Application.Modules.Sections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//odata
ODataConventionModelBuilder modelBuilder = new ODataConventionModelBuilder();
modelBuilder.EntitySet<ReviewDTO>("Review");
modelBuilder.EntitySet<CourseResponse>("Course");
modelBuilder.EntitySet<SectionDTO>("Section");
modelBuilder.EntitySet<CategoryResponse>("Category");
modelBuilder.EntitySet<InstructorDTO>("Instructor");
modelBuilder.EntitySet<CertificateResponse>("Certificate");
modelBuilder.EntitySet<PaymentRequest>("Checkout");
modelBuilder.EntitySet<EnrollmentDetailDTO>("Enrollment");
modelBuilder.EntitySet<StudentDTO>("Student");
//modelBuilder.EntitySet<UserDTO>("User");
builder.Services.AddControllers().AddOData(opt => opt.Select().Filter().SetMaxTop(100).Expand().OrderBy().Count().AddRouteComponents("odata", modelBuilder.GetEdmModel()));

DotNetEnv.Env.Load();
builder.Configuration.AddEnvironmentVariables();


//cors
var config = builder.Services.BuildServiceProvider().GetService<IConfiguration>();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins(Environment.GetEnvironmentVariable("FRONTEND_URL")?? "http://localhost:3000") 
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});
//ref services
builder.Services.AddApplicationServices().AddInfrastructureServices(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false)
    .AddUserSecrets<Program>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
