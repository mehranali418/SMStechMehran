using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AssessmentFindingDetailController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AssessmentFindingDetail
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(AssessmentFindingDetail data)
        {
            AssessmentFindingDetail Assessmentfindingdetail = new AssessmentFindingDetail();
            Assessmentfindingdetail.AssessmentFindingMasterID = data.AssessmentFindingMasterID;
            Assessmentfindingdetail.AssessmentAreaID = data.AssessmentAreaID;
            Assessmentfindingdetail.Finding = data.Finding;
            db.AssessmentFindingDetails.Add(Assessmentfindingdetail);
            db.SaveChanges();
            db.Entry(Assessmentfindingdetail).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}
