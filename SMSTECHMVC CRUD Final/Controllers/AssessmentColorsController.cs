﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AssessmentColorsController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AssessmentColors
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(AssessmentColor data)
        {
            AssessmentColor Assessmentcolor = new AssessmentColor();
            Assessmentcolor.ColorName = data.ColorName;
            Assessmentcolor.ColorCode = data.ColorCode;
            Assessmentcolor.ColorMeaning = data.ColorMeaning;
            Assessmentcolor.Is_Active = data.Is_Active;
            db.AssessmentColors.Add(Assessmentcolor);
            db.SaveChanges();
            db.Entry(Assessmentcolor).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}