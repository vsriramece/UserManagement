using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace Rebtel.UserManagement.WebApi.Handlers
{
    public class WebAPIExceptionHandler : IExceptionHandler
    {
        public async Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        {
            // To do
            var exception = context.Exception;
            Trace.Write(exception, TraceEventType.Error.ToString());

            // ErrorMessageResult is a helper which creates a IHttpActionResult from Exception context
            context.Result = new ErrorMessageResult(context);
        }
    }
}