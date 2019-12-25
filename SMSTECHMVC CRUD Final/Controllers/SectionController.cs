using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class SectionController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string Name, string ClassID)
        {
            Section section = new Section();
            section.Name = Name;
            section.ClassID = Convert.ToInt32(ClassID);
            db.Sections.Add(section);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}