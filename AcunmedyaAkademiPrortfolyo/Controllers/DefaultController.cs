using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPrortfolyo.Models;

namespace AcunmedyaAkademiPrortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        
        dbAcunMedyaAkademi1Entities db= new dbAcunMedyaAkademi1Entities();

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
           return PartialView();
        }
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        } 
        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }
    }
}