﻿

namespace EduCore.Frontend.Web.Services.Interfaces
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message);

    }
}