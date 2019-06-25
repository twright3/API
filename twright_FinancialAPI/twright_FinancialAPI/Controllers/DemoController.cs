using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using twright_FinancialAPI.Models;

namespace twright_FinancialAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class DemoController : Controller
    {
        private TwrightDbContext db = new TwrightDbContext();

        // GET: Demo
        //public ActionResult Index()
        //{
        //    var houseData = db.Households.ToList();
        //    return View(houseData);
        //}

        //public ActionResult Details(int? id)
        //{
        //    Household houseData;
        //    if (id == null)
        //    {
        //        houseData = db.Households.FirstOrDefault();
        //    }
        //    else
        //        houseData = db.Households.Find(id);
        //    return View(houseData);
        //}
    }
}