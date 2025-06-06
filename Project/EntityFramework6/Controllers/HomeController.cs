﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using(var context = new AppDbContext())
            {
                var books = context.books.Include("author").ToList();
                //For executing raw sql quries or store prdure
                //context.Database.ExecuteSqlCommand()
                return View(books);
            }
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}