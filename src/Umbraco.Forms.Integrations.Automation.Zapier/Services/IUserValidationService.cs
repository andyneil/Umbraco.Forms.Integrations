﻿using System.Threading.Tasks;

namespace Umbraco.Forms.Integrations.Automation.Zapier.Services
{
    public interface IUserValidationService
    {
        Task<bool> Validate(string username, string password, string userGroup);
    }
}
