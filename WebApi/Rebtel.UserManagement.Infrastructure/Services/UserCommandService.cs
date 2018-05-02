using System;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Services.Interfaces;
using System.Threading.Tasks;
using Rebtel.UserManagement.Infrastructure.ExternalServices.Interface;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IRebtelUserDomainService UserDomainService;
        public UserCommandService(IRebtelUserDomainService userDomainService)
        {
            UserDomainService = userDomainService;
        }
        public async Task AddSubscriptionToUser(Guid userId, Guid subscriptionId)
        {
            await UserDomainService.AddSubscriptionToUser(userId, subscriptionId);
        }

        public async Task<CreateUserResponse> CreateUser(CreateUser user)
        {
            return await UserDomainService.CreateUser(user);
        }

        public async Task DeleteUser(Guid userId)
        {
            await UserDomainService.DeleteUser(userId);
        }
    }
}
