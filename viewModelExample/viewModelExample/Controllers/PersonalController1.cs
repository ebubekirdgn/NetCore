using Microsoft.AspNetCore.Mvc;

namespace viewModelExample.Controllers
{
    public class PersonalController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
