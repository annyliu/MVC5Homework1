using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CustomerDataController : Controller
    {
        private 客戶資料Entities db = new 客戶資料Entities();

        // GET: CustomerData
        public ActionResult Index()
        {
            //return View(db.客戶資料.ToList());
            return View();
        }
    }
}