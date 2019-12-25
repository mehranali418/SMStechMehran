﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AcademicPeriodsController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AcademicPeriods
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Academic_Periods data)
        {
            Academic_Periods Academicperiod = new Academic_Periods();
            Academicperiod.Name = data.Name;
            Academicperiod.TimeStart = data.TimeStart;
            Academicperiod.TimeEnd = data.TimeEnd;
            Academicperiod.PeriodNumber = data.PeriodNumber;
            db.Academic_Periods.Add(Academicperiod);
            db.SaveChanges();
            db.Entry(Academicperiod).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}