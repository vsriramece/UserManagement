using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.ExternalServices.Interface
{
    public interface IRebtelSubscriptionDomainService
    {
        Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscription createSubscription);

        Task UpdateSubscription(Guid subcriptionId,UpdateSubscription updateSubscription);

        Task DeleteSubscription(Guid subscriptionId);

        Task<IEnumerable<SubscriptionData>> GetSubscriptions();
        Task<SubscriptionData> GetSubscriptionById(Guid id);
    }
}
