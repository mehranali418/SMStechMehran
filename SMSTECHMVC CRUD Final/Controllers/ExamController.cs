using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class ExamController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string TestID, string ExamDate, string IsActive, string ShortName)
        {
            Exam ex = new Exam();
            Boolean Active = true;

            ex.TestID = Convert.ToInt32(TestID);
            ex.ExamDate = Convert.ToDateTime(ExamDate);
            ex.IsActive  = Active;
            ex.ShortName = ShortName;
            db.Exams.Add(ex);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}