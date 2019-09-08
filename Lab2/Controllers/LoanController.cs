using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class LoanController : Controller
    {
        // GET: Loan
        [HttpGet]
        public ActionResult IndexLoan()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexLoan(double years, double amount, double rate)
        {
            ViewData["years"] = years;
            ViewData["amount"] = amount;
            ViewData["rate"] = rate;
            for (int x = 0; x < years; x++) {
                amount += (rate / 100) * amount;
            }
            ViewData["finalAmount"] = Math.Round(amount,2);
            return View();
        }
    }
}