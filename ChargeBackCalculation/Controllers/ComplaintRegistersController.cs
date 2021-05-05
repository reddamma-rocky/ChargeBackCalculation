using ChargeBackCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChargeBackCalculation.Controllers
{
    public class ComplaintRegistersController : Controller
    {
        private UserLoginDbContext db = new UserLoginDbContext();
        // GET: ComplaintRegisters
        public ActionResult Index()
        {
            return View(db.ComplaintRegisters.ToList());
        }


        public ActionResult Create()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerId,FirstName,LastName,PhoneNumber,Email,BankAccountNo,BankBranch,ChargeBackAmount,Reason,DateOfTransaction")] ComplaintRegister complaintregister, int customerid)
        {
            if (ModelState.IsValid)
            {

                var user = db.CustomerRegisters.Where(x => x.UserId == customerid).FirstOrDefault();
                if (user != null)
                {
                    var user1 = db.Employees.Where(x => x.CustomerId == customerid).FirstOrDefault();
                    if (user1 != null)
                    {
                        db.ComplaintRegisters.Add(complaintregister);
                        db.SaveChanges();
                        TempData["Message"] = "Complaint Lodged Successfully ";
                        //return RedirectToAction("Index");
                    }
                    else
                    {

                        return View(complaintregister);


                    }
                }
            }

            return View(complaintregister);
        }
    }
}