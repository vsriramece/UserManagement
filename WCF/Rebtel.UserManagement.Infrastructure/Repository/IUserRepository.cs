using Rebtel.UserManagement.Domain.Entities;
using System;

namespace Rebtel.UserManagement.Infrastructure.Repository
{
    public interface IUserRepository: IRepository<User>
    {
        Subscription GetSubscriptionById(Guid id);
    }
}