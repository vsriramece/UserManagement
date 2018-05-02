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
    public class SubscriptionController : ApiController
    {
        private readonly ISubscriptionCommandService CommandService;
        private readonly ISubscriptionQueryService QueryService;
        public SubscriptionController(ISubscriptionCommandService commandService, ISubscriptionQueryService queryService)
        {
            CommandService = commandService;
            QueryService = queryService;
        }

        #region Commands
        [SwaggerResponse(System.Net.HttpStatusCode.OK, Type = typeof(CreateSubscriptionResponse))]
        [HttpPost, Route("subscriptions")]
        public async Task<IHttpActionResult> CreateSubscription([FromBody] CreateSubscription request)
        {
            try
            {
                return Ok(await CommandService.CreateSubscription(request));
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }

        [SwaggerResponse(System.Net.HttpStatusCode.OK)]
        [HttpPut, Route("subscriptions/{id}")]
        public async Task<IHttpActionResult> UpdateSubscription([FromUri]Guid id, [FromBody] UpdateSubscription request)
        {
            try
            {
                await CommandService.UpdateSubscription(id, request);
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
        [HttpDelete, Route("subscriptions/{id}")]
        public async Task<IHttpActionResult> DeleteSubscription([FromUri]Guid id)
        {
            try
            {
                await CommandService.DeleteSubscription(id);
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
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(IEnumerable<SubscriptionData>))]
        [HttpGet, Route("subscriptions")]
        public async Task<IHttpActionResult> GetAllSubscriptions()
        {
            try
            {
                return Ok(await QueryService.GetSubscriptions());
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                // Can be fine tuned to throw a general exception instead of sending the server exception
                return InternalServerError(ex);
            }
        }

        [HttpGet, Route("subscriptions/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(SubscriptionData))]
        public async Task<IHttpActionResult> GetSubscriptionById(Guid id)
        {
            try
            {
                return Ok(await QueryService.GetSubscriptionById(id));
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
