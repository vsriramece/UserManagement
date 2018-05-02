using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.Services.Interfaces
{
    public interface IUserCommandService
    {
        Task<CreateUserResponse> CreateUser(CreateUser user);

        Task AddSubscriptionToUser(Guid userId, Guid subscriptionId);

        Task DeleteUser(Guid userId);
    }
}
