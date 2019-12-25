using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class StudentsMetaController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string StudentID, string KeyName,string KeyValue)
        {
            StudentsMeta sm = new StudentsMeta();

            sm.StudentID = Convert.ToInt32(StudentID);
            sm.KeyName = KeyName;
            sm.KeyValue = KeyValue;
            db.StudentsMetas.Add(sm);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}