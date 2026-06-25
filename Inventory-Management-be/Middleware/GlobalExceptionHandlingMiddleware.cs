using System.Text.Json;
using Inventory_Managment.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management_be.Middleware
{
    /// <summary>
    /// Middleware that handles unhandled exceptions and returns standardized error responses.
    /// </summary>
    public class GlobalExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandlingMiddleware> _logger;

        public GlobalExceptionHandlingMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            
            var errorResponse = new ErrorResponse
            {
                Message = exception.Message
            };

            switch (exception)
            {
                case FluentValidation.ValidationException validationEx:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    errorResponse.Message = "Validation failed";
                    errorResponse.Errors = validationEx.Errors?.Select(e => e.ErrorMessage) ?? Enumerable.Empty<string>();
                    break;

                case KeyNotFoundException:
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                    errorResponse.Message = exception.Message;
                    break;

                case UnauthorizedAccessException:
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    errorResponse.Message = "Unauthorized";
                    break;

                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    errorResponse.Message = "An internal server error occurred.";
                    break;
            }

            var jsonResponse = JsonSerializer.Serialize(errorResponse);
            await context.Response.WriteAsync(jsonResponse);
        }
    }
}

