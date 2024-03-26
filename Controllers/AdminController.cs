using Skill_CodeFirstEntity.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Skills.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSkill(Skill s)
        {
            c.Skills.Add(s);
            c.SaveChanges();
            return View();
        }
        public ActionResult SkillDelete(int id)
        {
            var deger = c.Skills.Find(id);
            c.Skills.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SkillGet(int id)
        {
            var deger= c.Skills.Find(id);
            return View("SkillGet",deger);
        }
        [HttpPost]
        public ActionResult SkillGet(Skill s)
        {
            //Calismiyor

            var x = c.Skills.Find(s.SkillID);
            x.SkillDescription = s.SkillDescription;
            x.SkillValue = s.SkillValue;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}