namespace Solicitudes_DGM.Application.Solicitud
{
    using FluentValidation;

    public class SolicitudValidator : AbstractValidator<Domain.Entities.Solicitud.Solicitud>
    {
        public SolicitudValidator()
        {
            this.RuleFor(x => x.PersonaId)
                .NotNull().WithMessage("La persona no puede estar vacia");
            this.RuleFor(x => x.Persona)
                .NotNull()
                .WithMessage("La persona no puede estar vacia");
            this.RuleFor(x => x.Estado)
                .NotNull()
                .WithMessage("El estado no puede estar vacio");
            this.RuleFor(x => x.EstadoId)
                .NotNull()
                .WithMessage("El estado no puede estar vacio");
            this.RuleFor(x => x.FechaCreacion)
                .NotNull()
                .WithMessage("La fecha de creacion no puede estar vacia");
        }
    }
}
