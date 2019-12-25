﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class AcademicSubjectsController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        // GET: AcademicSubjects
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Academic_Subjects data)
        {
            Academic_Subjects AcademicSubjects = new Academic_Subjects();
            AcademicSubjects.Name = data.Name;
            AcademicSubjects.ShortName = data.ShortName;
            AcademicSubjects.Status = data.Status;
            db.Academic_Subjects.Add(AcademicSubjects);
            db.SaveChanges();
            db.Entry(AcademicSubjects).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");
        }
    }
}