using Microsoft.AspNetCore.Mvc;
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
    }
}
