using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Rebtel.UserManagement.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISubscriptionManagement" in both code and config file together.
    [ServiceContract]
    public interface ISubscriptionManagement
    {
        [OperationContract]
        CreateSubscriptionResponse CreateSubscription(CreateSubcription createSubscription);

        [OperationContract]
        void UpdateSubscription(UpdateSubscription updateSubscription);

        [OperationContract]
        void DeleteSubscription(Guid subscriptionId);

        [OperationContract]
        SubscriptionData GetSubscriptionById(Guid subscriptionId);

        [OperationContract]
        IEnumerable<SubscriptionData> GetSubscriptions(); // Need to use batching(pagination) to avoid database/request throttling as there could many subscriptions
    }
}
