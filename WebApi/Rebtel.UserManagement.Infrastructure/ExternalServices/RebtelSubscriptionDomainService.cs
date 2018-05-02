using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Dto = Rebtel.UserManagement.Infrastructure.DTO;
using DtoResponse = Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.ExternalServices.Interface;
using Rebtel.UserManagement.Infrastructure.SubscriptionManagementService;

namespace Rebtel.UserManagement.Infrastructure.ExternalServices
{
    public class RebtelSubscriptionDomainService : IRebtelSubscriptionDomainService
    {
        public async Task<DtoResponse.CreateSubscriptionResponse> CreateSubscription(Dto.CreateSubscription request)
        {
            using (var client = new SubscriptionManagementClient())
            {
                var requestData = new CreateSubcription() {  Name= request.Name, Callminutes = request.Callminutes, Price = request.Price, PriceIncVatAmount= request.PriceIncVatAmount };
                var response = await client.CreateSubscriptionAsync(requestData);
                return new DtoResponse.CreateSubscriptionResponse() { Id = response.Id };
            }
        }

        public async Task DeleteSubscription(Guid subscriptionId)
        {
            using (var client = new SubscriptionManagementClient())
            {
                await client.DeleteSubscriptionAsync(subscriptionId);
            }
        }

        public async Task<DtoResponse.SubscriptionData> GetSubscriptionById(Guid id)
        {
            using (var client = new SubscriptionManagementClient())
            {
                var subscription = await client.GetSubscriptionByIdAsync(id);
                return MapSubscriptionFields(subscription);
            }
        }

        public async Task<IEnumerable<DtoResponse.SubscriptionData>> GetSubscriptions()
        {
            using (var client = new SubscriptionManagementClient())
            {
                var subscriptions = await client.GetSubscriptionsAsync();
                return subscriptions.Select(user => MapSubscriptionFields(user));
            }
        }

        public async Task UpdateSubscription(Guid subcriptionId, Dto.UpdateSubscription request)
        {
            using (var client = new SubscriptionManagementClient())
            {
                var requestData = new UpdateSubscription() {SubcriptionId= subcriptionId, Name = request.Name, Callminutes = request.Callminutes, Price = request.Price, PriceIncVatAmount = request.PriceIncVatAmount };
                await client.UpdateSubscriptionAsync(requestData);
            }
        }

        private DtoResponse.SubscriptionData MapSubscriptionFields(SubscriptionData subscription)
        {
            // This can be simplified by using Automapper
            var subscriptionData = new DtoResponse.SubscriptionData();
            subscriptionData.Id = subscription.Id;
            subscriptionData.Price = subscription.Price;
            subscriptionData.PriceIncVatAmount = subscription.PriceIncVatAmount;
            subscriptionData.Callminutes = subscription.Callminutes;
            return subscriptionData;
        }
    }
}
