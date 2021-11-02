using System;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using squadmanager.Models.Validator;
using SquadManager.Models;

namespace SquadManager.Controllers
{
    public class LoginController:Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();


            UserValidator validator =  new UserValidator();

            ValidationResult results = validator.Validate(user);

            if(!results.IsValid)
            {
                foreach( var failure in results.Errors)
                {
                    Console.WriteLine("Property" + failure.PropertyName + "failed validate");
                }
            }

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