using Rebtel.Common.Logging;
using Rebtel.UserManagement.Infrastructure.DTO;
using Rebtel.UserManagement.Infrastructure.DTO.Response;
using Rebtel.UserManagement.Infrastructure.Services.Interfaces;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Rebtel.UserManagement.WebApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserCommandService CommandService;
        private readonly IUserQueryService QueryService;
        public UserController(IUserCommandService commandService, IUserQueryService queryService)
        {
            CommandService = commandService;
            QueryService = queryService;
        }

        #region Commands
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(CreateUserResponse))]
        [HttpPost, Route("users")]
        public async Task<IHttpActionResult> CreateUser([FromBody] CreateUser request)
        {
            try
            {
                return Ok(await CommandService.CreateUser(request));
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }

        [SwaggerResponse(System.Net.HttpStatusCode.OK)]
        [HttpPut, Route("users/{id}")]
        public async Task<IHttpActionResult> AddSubscriptionToUser([FromUri]Guid id, [FromBody] AddSubcriptionToUser request)
        {
            try
            {
                await CommandService.AddSubscriptionToUser(id, request.SubscriptionId);
                return Ok();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }

        [SwaggerResponse(System.Net.HttpStatusCode.OK)]
        [HttpDelete, Route("users/{id}")]
        public async Task<IHttpActionResult> DeleteUser([FromUri]Guid id)
        {
            try
            {
                await CommandService.DeleteUser(id);
                return Ok();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }
        #endregion

        #region Query
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<UserData>))]
        [HttpGet, Route("users")]
        public async Task<IHttpActionResult> GetAllUsers()
        {
            try
            {
                return Ok(await QueryService.GetUsers());
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }

        [HttpGet, Route("users/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(UserData))]
        public async Task<IHttpActionResult> GetuserById(Guid id)
        {
            try
            {
                return Ok(await QueryService.GetUserById(id));
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }
        #endregion
    }
}
