using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AssessmentCategoriesController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
    // GET: AssessmentCategories
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
        public ActionResult Insert(AssessmentCategory data)
        {
            AssessmentCategory Assessmentcategory = new AssessmentCategory();
            Assessmentcategory.Name = data.Name;
            Assessmentcategory.Detail = data.Detail;
            Assessmentcategory.Status = data.Status;
            db.AssessmentCategories.Add(Assessmentcategory);
            db.SaveChanges();
            db.Entry(Assessmentcategory).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}