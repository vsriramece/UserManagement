using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.ExternalServices.Interface
{
    public interface IRebtelUserDomainService
    {
        Task<CreateUserResponse> CreateUser(CreateUser user);

        Task AddSubscriptionToUser(Guid userId, Guid subscriptionId);

        Task DeleteUser(Guid userId);
        Task<IEnumerable<UserData>> GetUsers();
        Task<UserData> GetUserById(Guid userId);
    }
}
