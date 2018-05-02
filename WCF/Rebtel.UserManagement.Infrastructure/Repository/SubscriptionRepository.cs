using System;
using System.Collections.Generic;
using System.Linq;
using Rebtel.UserManagement.Domain.Entities;

namespace Rebtel.UserManagement.Infrastructure.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly UserManagementDBContext DbContext;
        public IQueryable<Subscription> AggregateStates => DbContext.Subscriptions.AsQueryable();

        public SubscriptionRepository(UserManagementDBContext dbcontext)
        {
            DbContext = dbcontext;
        }

        public Subscription Create()
        {
            Subscription subscription = new Subscription();
            subscription.Id = Guid.NewGuid();
            DbContext.Subscriptions.Add(subscription);
            return subscription;
        }

        public void Delete(Subscription subscription)
        {
            DbContext.Subscriptions.Remove(subscription);
        }

        public Subscription GetById(Guid id)
        {
            return DbContext.Subscriptions.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Subscription> GetAll()
        {
            // Need to implement batching/pagination to handle large count
            return DbContext.Subscriptions;
        }
    }
}
