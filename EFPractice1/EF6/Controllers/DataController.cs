using EF6.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace EF6.Controllers
{
    [LogActionFilter]
    public class DataController : Controller
    {
        [OutputCache(Duration = 10,Location = OutputCacheLocation.Client,VaryByParam ="*")]
        public string Index()
        {
            return DateTime.Now.ToString("T");
        }
    }
}