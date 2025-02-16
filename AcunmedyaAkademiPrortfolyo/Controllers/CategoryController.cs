using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPrortfolyo.Models;

namespace AcunmedyaAkademiPrortfolyo.Controllers
{
    public class CategoryController : Controller
    {
        dbAcunMedyaAkademi1Entities db = new dbAcunMedyaAkademi1Entities();

        public ActionResult CategoryList()
        {
            var values = db.Table_Category.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CreateCategory(Table_Category category)
        {   
            db.Table_Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        

        public ActionResult DeleteCategory(int id)
        {
            var value = db.Table_Category.Find(id);
            db.Table_Category.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet] 
        public ActionResult UpdateCategory(int id)
        {
            var value = db.Table_Category.Find(id);
            return View(value);
        }
        [HttpPost]

        public ActionResult UpdateCategory(Table_Category p)
        {
            var value = db.Table_Category.Find(p.Categoryıd);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}