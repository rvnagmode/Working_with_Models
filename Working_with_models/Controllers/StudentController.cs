using System;
using Microsoft.AspNetCore.Mvc;
using Working_with_models.Models;

namespace Working_with_models.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Students stud)
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Students stud)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Students stud)
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
        [HttpPost]
        public IActionResult List(Students stud)
        {
            return View();
        }
    }
}
