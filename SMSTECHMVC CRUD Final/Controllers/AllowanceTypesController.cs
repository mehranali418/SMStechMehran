using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AllowanceTypesController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AllowanceTypes
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(AllowanceType data)
        {

            AllowanceType Allowancetypess = new AllowanceType();
 
            Allowancetypess.Name = data.Name;
            Allowancetypess.Recurring = data.Recurring;
            Allowancetypess.AllowanceType1 = data.AllowanceType1;
            Allowancetypess.SequenceNumber = data.SequenceNumber;          
            db.AllowanceTypes.Add(Allowancetypess);
            db.SaveChanges();
            db.Entry(Allowancetypess).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}
