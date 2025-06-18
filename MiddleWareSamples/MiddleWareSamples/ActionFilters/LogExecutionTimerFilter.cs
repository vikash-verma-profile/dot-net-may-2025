using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MiddleWareSamples.ActionFilters
{
    public class LogExecutionTimerFilter:IActionFilter
    {
        private readonly ILogger<LogExecutionTimerFilter> _logger;
        private Stopwatch _stopwatch=new Stopwatch();
            
        public LogExecutionTimerFilter(ILogger<LogExecutionTimerFilter> logger)
        {
                    _logger=logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            _logger.LogInformation($"Action {context.ActionDescriptor.DisplayName} started at {DateTime.UtcNow}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch.Start();
            _logger.LogInformation($"Action {context.ActionDescriptor.DisplayName} finshed in {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
