using Inventory_Managment.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Inventory_Management_be.Filters
{
    /// <summary>
    /// Action filter that wraps successful API responses in a standardized ApiResponse envelope.
    /// </summary>
    public class ApiResponseWrapperFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (resultContext.Result is ObjectResult objectResult && objectResult.StatusCode >= 200 && objectResult.StatusCode < 300)
            {
                var responseType = objectResult.Value?.GetType();
                
                // Don't wrap if already wrapped
                if (responseType != null && responseType.IsGenericType && responseType.GetGenericTypeDefinition() == typeof(ApiResponse<>))
                {
                    return;
                }

                if (responseType != null && responseType == typeof(ApiResponse))
                {
                    return;
                }

                // Wrap the response
                var wrappedResponse = new ApiResponse<object?>(objectResult.Value, null);
                
                if (objectResult.StatusCode.HasValue)
                {
                    resultContext.Result = new ObjectResult(wrappedResponse) { StatusCode = objectResult.StatusCode };
                }
                else
                {
                    resultContext.Result = new ObjectResult(wrappedResponse);
                }
            }
            else if (resultContext.Result is CreatedAtActionResult createdResult)
            {
                var wrappedResponse = new ApiResponse<object?>(createdResult.Value, null);
                resultContext.Result = new CreatedAtActionResult(createdResult.ActionName, createdResult.ControllerName, createdResult.RouteValues, wrappedResponse);
            }
        }
    }
}
