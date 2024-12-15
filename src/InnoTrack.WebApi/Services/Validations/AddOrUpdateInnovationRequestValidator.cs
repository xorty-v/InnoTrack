using FluentValidation;
using InnoTrack.WebApi.Contracts.Innovations;

namespace InnoTrack.WebApi.Services.Validations;

public class AddOrUpdateInnovationRequestValidator: AbstractValidator<AddOrUpdateInnovationRequest>
{
    public AddOrUpdateInnovationRequestValidator()
    {
        RuleFor(x => x.AuthorName)
            .NotEmpty().WithMessage("Имя автора обязательно для заполнения")
            .Length(3, 150).WithMessage("Имя автора должно содержать от 3 до 150 символов");

        RuleFor(x => x.OrganizationName)
            .NotEmpty().WithMessage("Название организации обязательно для заполнения.")
            .Length(3, 100).WithMessage("Название организации должно содержать от 3 до 150 символов.");

        RuleFor(x => x.OrganizationEmail)
            .NotEmpty().WithMessage("Электронная почта организации обязательна")
            .EmailAddress().WithMessage("Укажите действительный адрес электронной почты");

        RuleFor(x => x.TechnologyName)
            .NotEmpty().WithMessage("Название технологии обязательно для заполнения")
            .Length(3, 100).WithMessage("Название технологии должно содержать от 3 до 100 символов");

        RuleFor(x => x.ProductName)
            .NotEmpty().WithMessage("Название продукта обязательно для заполнения")
            .Length(3, 100).WithMessage("Название продукта должно содержать от 3 до 100 символов");

        RuleFor(x => x.DateTime)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Дата и время не могут быть в будущем");
    }
}