using Microsoft.AspNetCore.Mvc;
using Mtuci.Models;

namespace Mtuci.Controllers
{
    public class TestController : Controller
    {
        static List<TestViewModel> test = new List<TestViewModel>();

        public IActionResult Index()
        {            
            return View(test);
        }

        public IActionResult Create()
        {
            TestViewModel testViewModel = new TestViewModel();
            return View(testViewModel);
        }

        public IActionResult CreateTest(TestViewModel testViewModel)
        {
            test.Add(testViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}
