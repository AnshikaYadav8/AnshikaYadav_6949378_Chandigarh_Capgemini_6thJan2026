using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers
{
    public class StudentController : Controller
    {
        // Static counter (shared across requests)
        private static int studentCounter = 0;

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                // Auto-increment ID
                student.Id = ++studentCounter;

                return RedirectToAction("Details", new
                {
                    id = student.Id,
                    name = student.Name,
                    age = student.Age
                });
            }

            return View(student);
        }

        public IActionResult Details(int id, string name, int age)
        {
            ViewBag.Id = id;
            ViewBag.Name = name;
            ViewBag.Age = age;

            return View();
        }
    }
}