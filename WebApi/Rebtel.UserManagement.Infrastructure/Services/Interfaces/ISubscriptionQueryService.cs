using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.Infrastructure.Services.Interfaces
{
    public interface ISubscriptionQueryService
    {
        Task<IEnumerable<SubscriptionData>> GetSubscriptions();
        Task<SubscriptionData> GetSubscriptionById(Guid id);
    }
}
