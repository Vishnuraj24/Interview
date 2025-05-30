using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters
{
    public class MyExceptionAttrribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new ContentResult
            {
                Content = "An error occured: " + context.Exception.Message,
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
}
