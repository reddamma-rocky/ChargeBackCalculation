using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChargeBackCalculation.Controllers
{
    public class UserLoginsController : Controller
    {
        // GET: UserLogins
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserRole)
        {

            if (UserRole == "Admin")
            {
                return RedirectToAction("AdminLogin", "AdminRegisters");
            }
            else if (UserRole == "Customer")
            {
                return RedirectToAction("CustomerLogin","CustomerRegisters");
            }
            else if (UserRole == "Employee")
            {
                return RedirectToAction("EmployeeLogin","EmployeeRegisters");
            }

            return View();
        }
    }
}