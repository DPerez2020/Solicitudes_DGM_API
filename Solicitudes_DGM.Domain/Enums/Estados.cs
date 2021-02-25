namespace Solicitudes_DGM.Domain.Enums
{
    public enum Estados
    {
        /// <summary>
        /// El estado de la solicitud se encuentra abierto y a la espera de ser procesado.
        /// </summary>
        Abiertas,

        /// <summary>
        /// El estado de la solicitud se encuentra aprobado y finalizo su procesamiento.
        /// </summary>
        Aprobadas,

        /// <summary>
        /// El estado de la solicitud se encuentra cancelado y finalizo su procesamiento.
        /// </summary>
        Canceladas,
    }
}
