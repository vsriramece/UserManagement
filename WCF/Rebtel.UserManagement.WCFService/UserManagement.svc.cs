using System;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using System.Collections.Generic;
using Rebtel.UserManagement.Infrastructure.Services;
using System.Threading.Tasks;
using System.ServiceModel;
using Rebtel.Common.Logging;

namespace Rebtel.UserManagement.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserManagement : IUserManagement
    {
        private readonly IUserCommandService CommandService;
        private readonly IUserQueryService QueryService;
        
        public UserManagement(IUserCommandService commandService, IUserQueryService queryService)
        {
            this.CommandService = commandService;
            this.QueryService = queryService;
        }

        public CreateUserResponse CreateUser(CreateUser user)
        {
            try
            {
                return CommandService.CreateUser(user);
            }
            catch(Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public void AddSubscriptionToUser(AddSubcriptionToUser addSubcriptionToUser)
        {
            try
            {
                CommandService.AddSubscriptionToUser(addSubcriptionToUser);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public void DeleteUser(Guid userId)
        {
            try
            {
                CommandService.DeleteUser(userId);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public UserData GetUserById(Guid userId)
        {
            try
            {
                return QueryService.GetUserById(userId);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }

        public IEnumerable<UserData> GetUsers()
        {
            try
            {
                return QueryService.GetUsers();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                throw new FaultException(ex.Message);
            }
        }
    }
}
