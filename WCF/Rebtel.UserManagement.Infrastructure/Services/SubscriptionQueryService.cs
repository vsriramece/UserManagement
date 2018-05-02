using System;
using System.Collections.Generic;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Repository;
using Rebtel.UserManagement.Domain.Entities;
using System.Linq;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class SubscriptionQueryService : ISubscriptionQueryService
    {
        private readonly ISubscriptionRepository Repository;
        public SubscriptionQueryService(ISubscriptionRepository repository)
        {
            Repository = repository;
        }
        public SubscriptionData GetSubscriptionById(Guid id)
        {
            var subscription = Repository.GetById(id);
            if (subscription == null)
            {
                // This can be a custom exception
                throw new Exception($"Subscription:{id} not found");
            }
            return MapSubscriptionFields(subscription);
        }

        public IEnumerable<SubscriptionData> GetSubscriptions()
        {
            var subscriptions = Repository.GetAll();
            return subscriptions.Select(subscription => MapSubscriptionFields(subscription)).ToList();
        }

        private SubscriptionData MapSubscriptionFields(Subscription subscription)
        {
            // This can be simplified by using Automapper
            var subscriptionData = new SubscriptionData();
            subscriptionData.Id = subscription.Id;
            subscriptionData.Name = subscription.Name;
            subscriptionData.Price = subscription.Price;
            subscriptionData.PriceIncVatAmount = subscription.PriceIncVatAmount;
            subscriptionData.Callminutes = subscription.Callminutes;
            return subscriptionData;
        }
    }
}
