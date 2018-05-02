using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.Services.Interfaces
{
    public interface ISubscriptionCommandService
    {
        Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscription createSubscription);

        Task UpdateSubscription(Guid subcriptionId, UpdateSubscription updateSubscription);

        Task DeleteSubscription(Guid subscriptionId);
    }
}
