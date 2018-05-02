using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public interface ISubscriptionQueryService
    {
        IEnumerable<SubscriptionData> GetSubscriptions();
        SubscriptionData GetSubscriptionById(Guid id);
    }
}