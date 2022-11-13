using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

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

            var connection = _configuration.GetConnectionString("SQL");
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connection);
            builder.UserID = _configuration["SQL:Username"];
            builder.Password = _configuration["SQL:Password"];
        }
    }

}
