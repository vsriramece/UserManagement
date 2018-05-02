using System;
using System.Diagnostics;

namespace Rebtel.Common.Logging
{
    //For now keeping it is as static class. The required logginghandler can be injected to this Eg:ApplicationInsights 
    public static class Logger
    {
        public static void LogError(Exception ex)
        {
            //Do respective custom logging
            // For now using Diagnostics Trace
            Trace.TraceError(ex?.ToString());
        }
    }
}
