using Microsoft.AspNetCore.Mvc;

namespace WebApiCICD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mobile : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Mobile()
        {
                
        }

        [HttpGet(Name = "GetMobiles")]
        public IEnumerable<string> Get()
        {
            return Summaries;
        }
    }
}
