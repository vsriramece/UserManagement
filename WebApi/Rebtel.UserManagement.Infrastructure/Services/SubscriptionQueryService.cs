using Rebtel.UserManagement.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.ExternalServices.Interface;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class SubscriptionQueryService : ISubscriptionQueryService
    {
        private readonly IRebtelSubscriptionDomainService SubscriptionDomainService;
        public SubscriptionQueryService(IRebtelSubscriptionDomainService subscriptionDomainService)
        {
            SubscriptionDomainService = subscriptionDomainService;
        }
        public async Task<SubscriptionData> GetSubscriptionById(Guid id)
        {
            return await SubscriptionDomainService.GetSubscriptionById(id);
        }

        public async Task<IEnumerable<SubscriptionData>> GetSubscriptions()
        {
            return await SubscriptionDomainService.GetSubscriptions();
        }
    }
}
