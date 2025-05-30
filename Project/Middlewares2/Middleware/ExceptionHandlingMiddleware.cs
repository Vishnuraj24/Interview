using System.Text.Json;

namespace Middlewares2.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next,ILogger<ExceptionHandlingMiddleware> logger)
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
                _logger.LogError(ex, "An Unhandled Exception has occured");
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                var errorResponse = new
                {
                    Message = "Something went wrong!",
                    Details = ex.Message
                };
                var json = JsonSerializer.Serialize(errorResponse);
                await context.Response.WriteAsync(json);
            
            
            }
        }
    }
}
