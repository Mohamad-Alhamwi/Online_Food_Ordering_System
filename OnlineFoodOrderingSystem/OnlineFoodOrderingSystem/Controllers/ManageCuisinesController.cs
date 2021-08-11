﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineFoodOrderingSystem.Controllers
{
    public class ManageCuisinesController : Controller
    {
        // GET: ManageCuisines
        public ActionResult Index()
        {
            ViewBag.SubTitle = "Cuisines";
            ViewBag.Path = "/ManageCuisines/Index/";

            return View();
        }
    }
}