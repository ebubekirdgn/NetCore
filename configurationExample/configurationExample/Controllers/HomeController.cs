using configurationExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace configurationExample.Controllers
{
    public class HomeController : Controller
    {
        MailInfo _mailInfo;
        public HomeController(IOptions<MailInfo> mailInfo)
        {
            _mailInfo = mailInfo.Value;
        }

        public IActionResult Index()
        { 
            return View();
        }
     
    }
}