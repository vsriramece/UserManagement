using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public interface ISubscriptionCommandService
    {
        CreateSubscriptionResponse CreateSubscription(CreateSubcription createSubscription);

        void UpdateSubscription(UpdateSubscription updateSubscription);

        void DeleteSubscription(Guid subscriptionId);

    }

}