using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;

namespace SquadManager.Controllers
{
    public class LoginController:Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
             
            user.Email = "email enviado";

            return View("Index", user);
        }
    }
}