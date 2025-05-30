using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters
{
    public class LogActionAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Action Method is {context.ActionDescriptor.DisplayName} is executing");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action Method is {context.ActionDescriptor.DisplayName} is executing");
        }

        
    }
}
