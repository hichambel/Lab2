using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        [HttpGet]
        public ActionResult IndexGrades()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexGrades(FormCollection form)
        {
            ViewData["letterGrade"] = "";
            if (form["gradeOne"] == null && form["gradeTwo"] == null && form["gradeThree"] == null) {    
                    ViewData["letterGrade"] = "You must fill out all the form";
            }
            else{
                double firstGrade = double.Parse(form["gradeOne"]);
                double secondGrade = double.Parse(form["gradeTwo"]);
                double thirdGrade = double.Parse(form["gradeThree"]);
                double average = (firstGrade + secondGrade + thirdGrade) / 3;

                if (average >= 90 && average <= 100) {
                    ViewData["letterGrade"] = "Your letter grade is A";
                } else if (average >= 80 && average <= 89) {
                    ViewData["letterGrade"] = "Your letter grade is B";
                } else if (average >= 70 && average <= 79) {
                    ViewData["letterGrade"] = "Your letter grade is C";
                } else if (average >= 60 && average <= 69) {
                    ViewData["letterGrade"] = "Your letter grade is D";
                } else if (average <= 59) {
                    ViewData["letterGrade"] = "Your letter grade is F";
                }
            } 
            return View();
        }
    }
}