using FluentValidation;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Validators
{
    public class LoginViewModelValidator: AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator(UserService userService)
        {
            RuleFor(model => model.Password).NotEmpty().WithMessage("Password is required.");
            RuleFor(model => model.Username).NotEmpty().WithMessage("Username is required.");

            RuleFor(model => model.Username)
                .Must(username => userService.UserAlreadyExists(username))
                .WithMessage("Incorrect credentials or user does not exits");
            
        }
    }
}