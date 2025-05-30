using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace Filters.Filters
{
    public class MyAuthorizationAttribute: Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var username = context.HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }

    }
}
