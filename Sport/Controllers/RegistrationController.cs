using Microsoft.AspNetCore.Mvc;
using Sport.ViewModels;
using System.Text.Json;


namespace Sport.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CSportsmenViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = model.ToUser();
                var userData = JsonSerializer.Serialize(user);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", $"{user.City}_{user.LastName}.json");

                await System.IO.File.WriteAllTextAsync(filePath, userData);

                return RedirectToAction("Success");
            }

            return View(model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}