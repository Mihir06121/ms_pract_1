using Microsoft.AspNetCore.Mvc;
using pract_1.Models;

namespace pract_1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Name = "Mihir",
                Id = 1,
                Gender = "Male"
            };

            return View(student);
        }

    }
}
