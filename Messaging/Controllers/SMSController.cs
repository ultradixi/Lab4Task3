using Messaging.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messaging.Controllers
{
    public class SMSController : Controller
    {


        // GET: SMSController/Details/5
        public ActionResult Details(TextMessage msg)
        {
            return View(msg);
        }

        // GET: SMSController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SMSController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TextMessage sms)
        {
            try
            {
                return RedirectToAction("Details",sms);
            }
            catch
            {
                return View();
            }
        }

    }
}
