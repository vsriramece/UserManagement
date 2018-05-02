using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Services.Interfaces;
using Rebtel.UserManagement.Infrastructure.ExternalServices.Interface;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IRebtelUserDomainService UserDomainService;
        public UserQueryService(IRebtelUserDomainService userDomainService)
        {
            UserDomainService = userDomainService;
        }
        public async Task<UserData> GetUserById(Guid userId)
        {
            return await UserDomainService.GetUserById(userId);
        }

        public async Task<IEnumerable<UserData>> GetUsers()
        {
            return await UserDomainService.GetUsers();
        }
    }
}
