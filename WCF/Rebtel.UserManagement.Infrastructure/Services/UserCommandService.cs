using System;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Repository;
using Rebtel.UserManagement.Infrastructure.UnitOfWork;

namespace Rebtel.UserManagement.Infrastructure.Services
{
    public class UserCommandService : IUserCommandService
    {
        private readonly IUserRepository Repository;
        private readonly IUnitOfWork UnitOfWork;
        public UserCommandService(IUserRepository repository, IUnitOfWork unitofWork)
        {
            Repository = repository;
            UnitOfWork = unitofWork;
        }
        public CreateUserResponse CreateUser(CreateUser createUser)
        {
            var user = Repository.Create();
            user.Initialize(createUser.FirstName, createUser.Lastname, createUser.Email);
            UnitOfWork.Commit();
            return new CreateUserResponse { Id = user.Id };
        }

        public void AddSubscriptionToUser(AddSubcriptionToUser addSubcriptionToUser)
        {
            var user = Repository.GetById(addSubcriptionToUser.UserId);
            if (user == null)
            {
                // This can be a custom exception
                throw new Exception($"User:{addSubcriptionToUser.UserId} not found");
            }
            var subscription = Repository.GetSubscriptionById(addSubcriptionToUser.SubscriptionId);
            if (subscription == null)
            {
                // This can be a custom exception
                throw new Exception($"Subscription:{addSubcriptionToUser.SubscriptionId} not found");
            }
            user.AddSubscription(subscription);
            UnitOfWork.Commit();
        }

        public void DeleteUser(Guid userId)
        {
            var user = Repository.GetById(userId);
            if(user == null)
            {
                // This can be a custom exception
                throw new Exception($"User:{userId} not found");
            }
            user.Delete();
            Repository.Delete(user);
            UnitOfWork.Commit();
        }
    }
}
