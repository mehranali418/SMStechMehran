using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSTECHMVC_CRUD_Final.Controllers
{
    public class StudentController : Controller
    {
        SMST4MEntities db = new SMST4MEntities();
        public ActionResult Index()
        {
            ViewBag.ReligionID = new SelectList(db.Religions, "ID", "Name");
            ViewBag.NationalityID = new SelectList(db.Nationalities, "ID", "Name");          
            ViewBag.SectionID = new SelectList(db.Sections, "ID", "Name");
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            ViewBag.StuGroupID = new SelectList(db.Student_Groups, "ID", "Name");
            ViewBag.Status = new SelectList(db.Users, "ID", "Name");
            return View();
        }
        [HttpPost]
        public void Upload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);
                file.SaveAs(path);
                Session["Imageurl"] = path;

            }

        }
        [HttpPost]
        public ActionResult Insert(Student data)
        {


            Student st = new Student();
            st.SectionID = data.SectionID;
            st.UserID = data.UserID;
            st.StuCNIC = data.StuCNIC;
            st.Status = data.Status;
            st.sDate = data.sDate;
            st.RollNo = data.RollNo;
            st.ReligionID = data.ReligionID;
            st.registration_no = data.registration_no;
            st.NationalityID = data.NationalityID;
            st.Name = data.Name;
            st.JoiningClassID = data.JoiningClassID;
            st.LeavingDate = data.LeavingDate;
            st.StuGroupID = data.StuGroupID;
            st.Gender = data.Gender;
            st.Email = data.Email;
            st.BirthDate = data.BirthDate;
            st.FamilyID = data.FamilyID;
            string path = Session["Imageurl"].ToString();
            Image img = Image.FromFile(path);
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, ImageFormat.Png);
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes = new byte[800000];
            tmpStream.Read(imgBytes, 0, 800000);
            st.image = imgBytes;
            db.Students.Add(st);
            db.SaveChanges();
            db.Entry(st).State = System.Data.Entity.EntityState.Modified;
            return Json("Saved Successfully");

        }
       
    }
}