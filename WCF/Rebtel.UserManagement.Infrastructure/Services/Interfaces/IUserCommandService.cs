using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public interface IUserCommandService
    {
        CreateUserResponse CreateUser(CreateUser user);

        void AddSubscriptionToUser(AddSubcriptionToUser addSubcriptionToUser);

        void DeleteUser(Guid userId);
    }
}