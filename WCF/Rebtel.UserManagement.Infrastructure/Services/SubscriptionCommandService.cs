using System;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Repository;
using Rebtel.UserManagement.Infrastructure.UnitOfWork;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class SubscriptionCommandService : ISubscriptionCommandService
    {
        private readonly ISubscriptionRepository Repository;
        private readonly IUnitOfWork UnitOfWork;
        public SubscriptionCommandService(ISubscriptionRepository repository, IUnitOfWork unitofWork)
        {
            Repository = repository;
            UnitOfWork = unitofWork;
        }
        public CreateSubscriptionResponse CreateSubscription(CreateSubcription createSubscription)
        {
            var subscription = Repository.Create();
            subscription.Initialize(createSubscription.Name, createSubscription.Price, createSubscription.PriceIncVatAmount, createSubscription.Callminutes);
            UnitOfWork.Commit();
            return new CreateSubscriptionResponse { Id = subscription.Id };
        }

        public void DeleteSubscription(Guid subscriptionId)
        {
            var subscription = Repository.GetById(subscriptionId);
            if (subscription == null)
            {
                // This can be a custom exception
                throw new Exception($"Subscription:{subscriptionId} not found");
            }
            subscription.Delete();
            Repository.Delete(subscription);
            UnitOfWork.Commit();
        }

        public void UpdateSubscription(UpdateSubscription updateSubscription)
        {
            var subscription = Repository.GetById(updateSubscription.SubcriptionId);
            if (subscription == null)
            {
                // This can be a custom exception
                throw new Exception($"Subscription:{updateSubscription.SubcriptionId} not found");
            }
            subscription.Update(updateSubscription.Name, updateSubscription.Price, updateSubscription.PriceIncVatAmount, updateSubscription.Callminutes);
            UnitOfWork.Commit();
        }
    }
}
