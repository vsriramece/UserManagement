using Rebtel.UserManagement.Infrastructure.Services.Interfaces;
using System;
using System.Threading.Tasks;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.ExternalServices.Interface;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class SubscriptionCommandService : ISubscriptionCommandService
    {
        private readonly IRebtelSubscriptionDomainService SubscriptionDomainService;
        public SubscriptionCommandService(IRebtelSubscriptionDomainService subscriptionDomainService)
        {
            SubscriptionDomainService = subscriptionDomainService;
        }

        public async Task<CreateSubscriptionResponse> CreateSubscription(CreateSubscription createSubscription)
        {
            return await SubscriptionDomainService.CreateSubscription(createSubscription);
        }

        public async Task DeleteSubscription(Guid subscriptionId)
        {
            await SubscriptionDomainService.DeleteSubscription(subscriptionId);
        }

        public async Task UpdateSubscription(Guid subcriptionId, UpdateSubscription updateSubscription)
        {
            await SubscriptionDomainService.UpdateSubscription(subcriptionId, updateSubscription);
        }
    }
}
