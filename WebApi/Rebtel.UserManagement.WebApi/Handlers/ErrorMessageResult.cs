using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Rebtel.UserManagement.WebApi.Handlers
{
    internal class ErrorMessageResult : IHttpActionResult
    {
        private ExceptionHandlerContext context;

        public ErrorMessageResult(ExceptionHandlerContext context)
        {
            this.context = context;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var exception = context?.Exception;
            // Can be fine tuned to throw a general exception instead of sending the server exception
            return Task.FromResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError, exception?.ToString()));
        }
    }
}