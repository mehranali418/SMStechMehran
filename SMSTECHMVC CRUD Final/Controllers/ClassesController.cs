using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class ClassesController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            ViewBag.LevelID = new SelectList(db.Exams_Grade, "ID", "Level_id");
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string Name,string ClassNumber,string LevelID)
        {
            Class ca = new Class();
            ca.Name = Name;
            int ClassNumbers = Convert.ToInt32(ClassNumber);

            int LevelId = Convert.ToInt32(LevelID);
            db.Classes.Add(ca);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}

