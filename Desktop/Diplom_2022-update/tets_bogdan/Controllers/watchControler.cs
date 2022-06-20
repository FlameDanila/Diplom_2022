using Microsoft.AspNetCore.Mvc;

namespace tets_bogdan.Controllers
{
    public class watchControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminView(string login)
        {
            ViewData["Message"] = "Вы успешно авторизировались " + login + "!";
            return View();
        }
        public IActionResult AuthorizeWatch(string login)
        {
            ViewData["Message"] = "Привет " + login + "!";
            return Index();
        }
        public IActionResult vivod()
        {
            ViewData["Message"] = "Привет?!";
            return View();
        }
    }
}
