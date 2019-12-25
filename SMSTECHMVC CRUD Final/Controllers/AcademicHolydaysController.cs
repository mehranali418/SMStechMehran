using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AcademicHolydaysController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AcademicHolydays
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Academic_Holydays data)
        {
            Academic_Holydays AcademicHolydays = new Academic_Holydays();
            AcademicHolydays.Name = data.Name;
            AcademicHolydays.S_Date = data.S_Date;
            db.Academic_Holydays.Add(AcademicHolydays);
            db.SaveChanges();
            db.Entry(AcademicHolydays).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}