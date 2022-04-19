using Microsoft.AspNetCore.Mvc;

namespace Working_with_models.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
