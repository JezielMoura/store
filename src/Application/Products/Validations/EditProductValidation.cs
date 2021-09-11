namespace Mobnet.Store.Application.Products.Validations;

using FluentValidation;
using Mobnet.Store.Application.Products.Commands;

public class UpdateProductValidation : AbstractValidator<EditProduct>
{
    public UpdateProductValidation()
    {
        RuleFor(v => v.Id)
            .NotEmpty()
            .OverridePropertyName("Identificador")
            .WithMessage("Campo obrigatório");

        RuleFor(v => v.Name)
            .NotEmpty()
            .OverridePropertyName("Nome")
            .WithMessage("Campo obrigatório");
    }
}