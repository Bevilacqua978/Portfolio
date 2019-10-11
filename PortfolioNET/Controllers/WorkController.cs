using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortfolioNET.Models;

namespace PortfolioNET.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Work()
        {
            var work = new Work() { Name = "My Work" };

            return View(work);
        }
    }
}