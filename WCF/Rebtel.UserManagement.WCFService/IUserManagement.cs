using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Rebtel.UserManagement.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserManagement
    {
        [OperationContract]
        CreateUserResponse CreateUser(CreateUser user);

        [OperationContract]
        void AddSubscriptionToUser(AddSubcriptionToUser addSubcriptionToUser);

        [OperationContract]
        void DeleteUser(Guid userId);

        [OperationContract]
        UserData GetUserById(Guid userId);

        [OperationContract]
        IEnumerable<UserData> GetUsers(); // Need to use batching(pagination) to avoid database/request throttling as there could many users
    }
}
