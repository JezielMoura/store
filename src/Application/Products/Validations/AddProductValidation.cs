using FluentValidation;
using Mobnet.Store.Application.Products.Commands;

namespace Mobnet.Store.Application.Validations;

public class AddProductValidation : AbstractValidator<AddProduct>
{
    public AddProductValidation()
    {
        RuleFor(v => v.Name)
            .NotEmpty()
            .WithName("Nome")
            .WithMessage("Campo obrigatório");
    }
}