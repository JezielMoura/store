namespace Mobnet.Store.Application.Validations;

using FluentValidation;
using Mobnet.Store.Application.Products.Commands;

public class DeleteProductValidation : AbstractValidator<DeleteProduct>
{
    public DeleteProductValidation()
    {
        RuleFor(v => v.Code)
            .NotEmpty()
            .OverridePropertyName("Identificador")
            .WithMessage("O Identificador é obrigatório");
    }
}