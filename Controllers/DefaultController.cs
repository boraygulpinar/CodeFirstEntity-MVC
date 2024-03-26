using Skill_CodeFirstEntity.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context context = new Context();
            var degerler = context.Skills.ToList();
            return View (degerler);
        }
    }
}