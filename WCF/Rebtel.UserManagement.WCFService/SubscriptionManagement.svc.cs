using System;
using System.Collections.Generic;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System.Threading.Tasks;
using Rebtel.UserManagement.Infrastructure.Services;
using Rebtel.Common.Logging;
using System.ServiceModel;

namespace Rebtel.UserManagement.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SubscriptionManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SubscriptionManagement.svc or SubscriptionManagement.svc.cs at the Solution Explorer and start debugging.
    public class SubscriptionManagement : ISubscriptionManagement
    {
        private readonly ISubscriptionCommandService CommandService;
        private readonly ISubscriptionQueryService QueryService;

        public SubscriptionManagement(ISubscriptionCommandService commandService, ISubscriptionQueryService queryService)
        {
            this.CommandService = commandService;
            this.QueryService = queryService;
        }
        public CreateSubscriptionResponse CreateSubscription(CreateSubcription createSubscription)
        {
            try
            {
                return CommandService.CreateSubscription(createSubscription);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteSubscription(Guid subscriptionId)
        {
            try
            {
                CommandService.DeleteSubscription(subscriptionId);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public void UpdateSubscription(UpdateSubscription updateSubscription)
        {
            try
            {
                CommandService.UpdateSubscription(updateSubscription);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public SubscriptionData GetSubscriptionById(Guid subscriptionId)
        {
            try
            {
                return QueryService.GetSubscriptionById(subscriptionId);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<SubscriptionData> GetSubscriptions()
        {
            try
            {
               return QueryService.GetSubscriptions();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }
    }
}
