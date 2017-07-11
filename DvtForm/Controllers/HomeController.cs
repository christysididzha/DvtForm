using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DvtForm.Controllers
{
    public class HomeController : Controller

    {

        public ActionResult LForm()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult LForm(LForm b)

        {
            using (LFormEntities dc = new LFormEntities())
            {

                if (ModelState.IsValid)

                {

                    dc.LForms.Add(b);

                    dc.SaveChanges(b);

                    //ModelState.Clear();

                    //U = null;

                    ViewBag.Message = "Successfully Applied";

                }
                return View();
            }

        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult EndUser()
        {
            return View();
        }

        public ActionResult Essentials()
        {
            return View();
        }

        public ActionResult Fundamentals()
        {
            return View();
        }

        public ActionResult Programming()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Tools()
        {
            return View();
        }
        public ActionResult SoftSkills()
        {
            return View();
        }

        public ActionResult Vacancy()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

         



        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //  
        // GET: /User/ 
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Register(SignUp U)

        {
            using (SignUpEntities dc = new SignUpEntities())
            {

                if (ModelState.IsValid)

                {

                    dc.SignUps.Add(U);

                    dc.SaveChanges();

                    ViewBag.Message = "Successfully Registered!!";



                    //ModelState.Clear();

                    //U = null;


                }

            }

            //return Register();
            return RedirectToAction("index");

        }

       

    }

}