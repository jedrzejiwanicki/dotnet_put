using FluentValidation;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Validators
{
    public class RegisterViewModelValidator: AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator(UserService userService)
        {
            RuleFor(model => model.Username).NotEmpty().WithMessage("Username is required");
            RuleFor(model => model.Password).NotEmpty().WithMessage("Password is required");

            RuleFor(model => model.Email)
                .NotEmpty()
                .WithMessage("Email is required");
                
            RuleFor(model => model.Email)
                .EmailAddress()
                .WithMessage("Email is not correct");

            RuleFor(model => model.Username)
                .Must(username => !userService.UserAlreadyExists(username))
                .WithMessage("User with that email already exists");

        }
    }
}