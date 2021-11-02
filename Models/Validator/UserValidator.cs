using System;
using FluentValidation;
using SquadManager.Models;

namespace squadmanager.Models.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
       public UserValidator()
       {
           RuleFor(user => user.Email).NotNull().WithMessage("E-mail está vazio");
           RuleFor(user => user.Email).EmailAddress().WithMessage("E-mail invalido!");
           RuleFor(User => User.Password).NotNull().WithMessage("Digite a senha");
       }
    }
}