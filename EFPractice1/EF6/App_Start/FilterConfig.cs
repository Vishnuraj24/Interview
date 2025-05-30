using System.Web;
using System.Web.Mvc;

namespace EF6
{
    public class FilterConfig:IActionFilter
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new System.NotImplementedException();
        }
    }
}
