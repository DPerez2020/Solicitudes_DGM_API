namespace Solicitudes_DGM.Application.Persona
{
    using FluentValidation;

    public class PersonaValidator : AbstractValidator<Domain.Entities.Persona.Persona>
    {
        public PersonaValidator()
        {
            this.RuleFor(x => x.Nombre)
                .NotEmpty()
                .NotNull()
                .WithMessage("El nombre no puede estar vacio.")
                .MaximumLength(50)
                .WithMessage("La cantidad maxima de caracteres para el nombre es de 50.");

            this.RuleFor(x => x.Apellido)
                .NotEmpty()
                .NotNull()
                .WithMessage("El apelido no puede estar vacio.")
                .MaximumLength(50)
                .WithMessage("La cantidad maxima de caracteres para el apellido es de 50.");

            this.RuleFor(x => x.Direccion)
                .NotEmpty()
                .NotNull()
                .WithMessage("La direccion no puede estar vacia.")
                .MaximumLength(70)
                .WithMessage("La cantidad maxima de caracteres para el nombre es de 70.");

            this.RuleFor(x => x.Sexo)
                 .NotNull()
                 .NotEmpty()
                 .WithMessage("El sexo no puede estar vacio.");

            this.RuleFor(x => x.Pasaporte)
                .NotNull()
                .NotEmpty()
                .WithMessage("El pasaporte no puede estar vacio.")
                .Length(9)
                .WithMessage("El numero de caracteres validos para un pasaporte es de 9");

            this.RuleFor(x => x.FechaNacimiento)
                .NotNull()
                .WithMessage("Debe Ingresar la fecha de nacimiento");

            this.RuleFor(x => x.Estatus)
                .NotNull()
                .WithMessage("El estatus no puede estar vacio");
        }
    }
}
