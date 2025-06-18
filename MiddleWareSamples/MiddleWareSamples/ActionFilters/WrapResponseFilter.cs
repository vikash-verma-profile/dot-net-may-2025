using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Filters;
using MiddleWareSamples.Models;
using System.Diagnostics;

namespace MiddleWareSamples.ActionFilters
{
    public class WrapResponseFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            // post processing
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                if (objectResult.Value is ApiResponse)
                    return;

                if (objectResult.StatusCode is >= 200 and < 300 || objectResult.StatusCode is null)
                {
                    var wrapped = new ApiResponse
                    {
                        Data = objectResult.Value

                    };
                    context.Result = new ObjectResult(wrapped)
                    {
                        StatusCode = objectResult.StatusCode ?? 200
                    };
                }
            }
        }
    }
}
