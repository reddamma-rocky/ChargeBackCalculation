﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChargeBackCalculation.Controllers
{
    public class AdminsController : Controller
    {
        // GET: Admins
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}