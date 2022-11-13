using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace secretManagerExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Index()
        {
            var user = _configuration["MailBilgileri:User"];
            var password = _configuration["MailBilgileri:Password"];
        }
    }


}
