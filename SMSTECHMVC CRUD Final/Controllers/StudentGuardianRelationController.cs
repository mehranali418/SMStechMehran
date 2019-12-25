using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class StudentGuardianRelationController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string StudentID, string GuardianID, string RelationID)
        {
            Student_Guardian_Relation sgr = new Student_Guardian_Relation();

            sgr.StudentID = Convert.ToInt32(StudentID);
            sgr.GuardianID = Convert.ToInt32(GuardianID);
            sgr.RelationID= Convert.ToInt32(RelationID);
            db.Student_Guardian_Relation.Add(sgr);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}