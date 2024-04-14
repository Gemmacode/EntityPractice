using Microsoft.AspNetCore.Mvc;

namespace EntityPractice.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
