using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.Services.Interfaces
{
    public interface IUserQueryService
    {
        Task<IEnumerable<UserData>> GetUsers();
        Task<UserData> GetUserById(Guid userId);
    }
}
