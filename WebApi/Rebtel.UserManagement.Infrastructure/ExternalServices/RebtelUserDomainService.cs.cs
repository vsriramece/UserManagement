using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Dto=Rebtel.UserManagement.Infrastructure.DTO;
using DtoResponse=Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.ExternalServices.Interface;
using Rebtel.UserManagement.Infrastructure.UserManagementService;

namespace Rebtel.UserManagement.Infrastructure.ExternalServices
{
    public class RebtelUserDomainService : IRebtelUserDomainService
    {
        public async Task<DtoResponse.CreateUserResponse> CreateUser(Dto.CreateUser user)
        {
            using (var client = new UserManagementClient())
            {
                var requestData = new CreateUser() { FirstName = user.FirstName, Lastname = user.Lastname, Email = user.Email };
                var response =await client.CreateUserAsync(requestData);
                return new DtoResponse.CreateUserResponse() { Id = response.Id };
            }
        }

        public async Task  AddSubscriptionToUser(Guid userId, Guid subscriptionId)
        {
            using (var client = new UserManagementClient())
            {
                var requestData = new AddSubcriptionToUser() { UserId= userId, SubscriptionId= subscriptionId };
                await client.AddSubscriptionToUserAsync(requestData);
            }
        }

        public async Task DeleteUser(Guid userId)
        {
            using (var client = new UserManagementClient())
            {
                await client.DeleteUserAsync(userId);
            }
        }


        public async Task<DtoResponse.UserData> GetUserById(Guid userId)
        {
            using (var client = new UserManagementClient())
            {
                var user =await client.GetUserByIdAsync(userId);
                return MapUserFields(user);
            }
        }

        public async Task<IEnumerable<DtoResponse.UserData>> GetUsers()
        {
            using (var client = new UserManagementClient())
            {
                var users = await client.GetUsersAsync();
                return users.Select(user => MapUserFields(user));
            }
        }

        private DtoResponse.UserData MapUserFields(UserData user)
        {
            // This can be simplified by using Automapper
            var userData = new DtoResponse.UserData();
            userData.Id = user.Id;
            userData.FirstName = user.FirstName;
            userData.Lastname = user.Lastname;
            userData.Email = user.Email;
            userData.Totalcallminutes = user.Totalcallminutes;
            userData.TotalPriceIncVatAmount = user.TotalPriceIncVatAmount;
            userData.Subscriptions = user.Subscriptions?.Select(s => MapSubscriptionFields(s)).ToList();
            return userData;
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
