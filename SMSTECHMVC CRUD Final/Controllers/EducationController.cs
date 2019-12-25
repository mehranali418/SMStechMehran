using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class EducationController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string Name)
        {
            Education ed = new Education();
            ed.Name = Name;
            db.Educations.Add(ed);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}