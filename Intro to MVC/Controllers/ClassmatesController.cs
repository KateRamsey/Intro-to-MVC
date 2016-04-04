using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intro_to_MVC.Models;

namespace Intro_to_MVC.Controllers
{
    public class ClassmatesController : Controller
    {
        // GET: Classmates
        public ActionResult Index()
        {
            var classmates = new List<Classmate>
            {
                new Classmate {Name = "Kate", HairColor = "Dirty Blonde", Height = 66, Id = 1},
                new Classmate {Name = "Brian", HairColor = "Black", Height = 66, Id = 2},
                new Classmate {Name = "Kevin", HairColor = "Brown", Height = 66, Id = 3},
                new Classmate {Name = "Trey", HairColor = "Brown", Height = 66, Id = 4},
                new Classmate {Name = "Zach", HairColor = "Blonde", Height = 66, Id = 5},
                new Classmate {Name = "Tee", HairColor = "Black", Height = 66, Id = 6},
                new Classmate {Name = "Seth", HairColor = "Brown", Height = 66, Id = 7},
                new Classmate {Name = "Daniel", HairColor = "Brown", Height = 80, Id = 8}
            };
            return View(classmates);
        }
    }
}