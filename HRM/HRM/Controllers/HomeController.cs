using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{

    public class HomeController : Controller

    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var numofDept = db.Depts.Count();
            ViewBag.TotalDepts = numofDept;

            var numofDivision = db.Divisions.Count();
            ViewBag.TotalDivisions = numofDivision;

            var numofDesignation = db.Designations.Count();
            ViewBag.TotalDesignations = numofDesignation;

            var numofEmployee = db.Employees.Count();
            ViewBag.TotalEmployees = numofEmployee;

            var numofSection = db.Sections.Count();
            ViewBag.TotalSections = numofSection;



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}