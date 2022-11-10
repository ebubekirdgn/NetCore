using Microsoft.AspNetCore.Mvc;
using viewModelExample.Models;
using viewModelExample.Models.ViewModels;

namespace viewModelExample.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonalCreateVM personal)
        {
            //.. ilgili islemler burada yapılır.
            return View();
        }

        public IActionResult List()
        {
            List<PersonalListVM> personals = new List<Personal>
            {
                new Personal {Name = "A" ,Surname ="B" },
                new Personal {Name = "A" ,Surname ="B" },
                new Personal {Name = "A" ,Surname ="B" },
                new Personal {Name = "A" ,Surname ="B" },
                new Personal {Name = "A" ,Surname ="B" },
                new Personal {Name = "A" ,Surname ="B" },
            }.Select(p => new PersonalListVM
            {
                Name = p.Name,
                Surname = p.Surname,
                Position = p.Position
            }).ToList();

            return View(personals);
        }
    }
}
