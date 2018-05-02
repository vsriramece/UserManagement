using System;
using System.Collections.Generic;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Repository;
using Rebtel.UserManagement.Domain.Entities;
using System.Linq;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class UserQueryService : IUserQueryService
    {
        private readonly IUserRepository Repository;
        public UserQueryService(IUserRepository repository)
        {
            Repository = repository;
        }

        public UserData GetUserById(Guid userId)
        {
            var user = Repository.GetById(userId);
            if (user == null)
            {
                // This can be a custom exception
                throw new Exception($"User:{userId} not found");
            }
            return MapUserFields(user);
        }

        public IEnumerable<UserData> GetUsers()
        {
            var users = Repository.GetAll();
            return users.Select(user=>MapUserFields(user)).ToList();
        }

        private UserData MapUserFields(User user)
        {
            // This can be simplified by using Automapper
            var userData = new UserData();
            userData.Id = user.Id;
            userData.FirstName = user.FirstName;
            userData.Lastname = user.Lastname;
            userData.Email = user.Email;
            userData.Totalcallminutes = user.Totalcallminutes;
            userData.TotalPriceIncVatAmount = user.TotalPriceIncVatAmount;
            userData.Subscriptions = user.Subscriptions?.Select(s => MapSubscriptionFields(s)).ToList();
            return userData;
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
