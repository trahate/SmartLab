using SmartLab.DAL;
using SmartLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartLab.Controllers;
using SmartLab.Models;

namespace SmartLab.Controllers
{
    [Filter]
    public class HomeController : Controller
    {
        //ValuesController apivalue;
        Smart_LabEntities db;
        public GenericUnitWork _unitOfWork = new GenericUnitWork();
        HomeModel homeModel;
        public ActionResult Index()
        {
             

            return View();
        }

     

        public ActionResult Home()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Home(Patient_Tbl Ptbl)
        {
            //// var paname = apivalue.APIpost(Ptbl);
            //if (ModelState.IsValid)
            //{


            _unitOfWork.GetRepositoryInstance<Patient_Tbl>().Add(Ptbl);
            return RedirectToAction("Home");
        }
            //return View();
        //}
            

        [HttpGet]
        public ActionResult PatientDetails()
        {
            return View(_unitOfWork.GetRepositoryInstance<Patient_Tbl>().GetAllRecords());
            
        }

        public ActionResult Doctor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Doctor(Doctor_Tbl Doc)
        {
            //_unitOfWork.GetRepositoryInstance<Doctor_Tbl>().Add(Doc);
            return RedirectToAction("Doctor");
        }

        public ActionResult DoctorName()
        {

            IEnumerable<Doctor_Tbl> doctor_Tbls = _unitOfWork.GetRepositoryInstance<Doctor_Tbl>().GetAllRecords();
            IEnumerable<Patient_Tbl> patient_Tbls = _unitOfWork.GetRepositoryInstance<Patient_Tbl>().GetAllRecords();
            var docName = from d in doctor_Tbls
                          join p in patient_Tbls on d.DoctorID equals p.PatientID into DoctorDetail
                          from p in DoctorDetail.ToList()
                          select new ViewModel { Patient=p,
                              doctor =d};

            ViewBag.value = docName;      
            return View(docName);
        }
    }
}
