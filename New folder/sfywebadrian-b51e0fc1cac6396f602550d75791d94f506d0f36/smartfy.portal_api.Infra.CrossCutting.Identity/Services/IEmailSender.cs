﻿using System.Threading.Tasks;

namespace smartfy.portal_api.Infra.CrossCutting.Identity.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
