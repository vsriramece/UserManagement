using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public interface IUserQueryService
    {
        IEnumerable<UserData> GetUsers();
        UserData GetUserById(Guid userId);
    }
}