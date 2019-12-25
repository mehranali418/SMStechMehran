﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AcademicClassRoutineDaysController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert(string ClassRoutineID, string DaysID)
        {
            Academic_ClassRoutine_Days acd = new Academic_ClassRoutine_Days();

            acd.ClassRoutineID  = Convert.ToInt32(ClassRoutineID);
            acd.DaysID = Convert.ToInt32(DaysID);
            db.Academic_ClassRoutine_Days.Add(acd);
            db.SaveChanges();
            return Json("Save Successfully", JsonRequestBehavior.AllowGet);
        }
    }
}