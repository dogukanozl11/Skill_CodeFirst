using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirst.Models.siniflar;

namespace Skill_CodeFirst.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            CONTEXT c = new CONTEXT();
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
    }
}