using Microsoft.AspNetCore.Mvc;

namespace LizardWizard.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}