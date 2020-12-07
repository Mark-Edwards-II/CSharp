using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!";
        }
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects.";
        }
        [HttpGet("contact")]
        public string contact()
        {
            return "This is my Contact!";
        }
    }
}