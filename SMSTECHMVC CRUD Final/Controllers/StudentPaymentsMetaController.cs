using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class StudentPaymentsMetaController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string PaymentID, string KeyName, string KeyValue)
        {
            StudentPaymentsMeta spm = new StudentPaymentsMeta();

           spm.PaymentID = Convert.ToInt32(PaymentID);
            spm.KeyName = KeyName;
            spm.KeyValue = KeyValue;
            db.StudentPaymentsMetas.Add(spm);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}