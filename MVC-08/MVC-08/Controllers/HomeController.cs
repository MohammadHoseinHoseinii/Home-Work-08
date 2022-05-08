using Microsoft.AspNetCore.Mvc;
using MVC_08.Models;
using System.Diagnostics;

namespace MVC_08.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(PersonRepository.Persons);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Delete(int Id)
        {
            PersonRepository.Delete(Id);
            return Redirect("Index");
        }

        public IActionResult Edit(int Id)
        {
            var TruePerson = PersonRepository.Finder(Id);
            return View(TruePerson);
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            var TruePerson = PersonRepository.Finder(person.Id);
            TruePerson.Name = person.Name;
            return RedirectToAction("Index");
        }
        public IActionResult _Layout1()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}