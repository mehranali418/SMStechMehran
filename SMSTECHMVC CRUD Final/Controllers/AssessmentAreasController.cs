using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AssessmentAreasController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AssessmentAreas
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(AssessmentArea data)
        {
            AssessmentArea Assessmentareas = new AssessmentArea();
            Assessmentareas.AssessmentCategoryID = data.AssessmentCategoryID;
            Assessmentareas.Name = data.Name;
            Assessmentareas.Description = data.Description;
            Assessmentareas.ParentID = data.ParentID;
            Assessmentareas.Sequence = data.Sequence;
            Assessmentareas.Is_Active = data.Is_Active;
            Assessmentareas.Is_SummaryField = data.Is_SummaryField;
            Assessmentareas.Level = data.Level;
            db.AssessmentAreas.Add(Assessmentareas);
            db.SaveChanges();
            db.Entry(Assessmentareas).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}