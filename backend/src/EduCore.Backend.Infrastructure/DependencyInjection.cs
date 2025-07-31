using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using EduCore.BackEnd.Application.Module.Courses;
using EduCore.BackEnd.Domain.Common.Repositories;

namespace EduCore.BackEnd.Infrastructure
{

    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IPaymentGatewayService, VnPayGatewayService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<EduCoreDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("MyDatabase")));
            services.AddAutoMapper(typeof(CourseMapping).Assembly);

            services.AddIdentity<UserAccount, IdentityRole<int>>()
             .AddEntityFrameworkStores<EduCoreDbContext>()
             .AddDefaultTokenProviders();


        }
    }
}