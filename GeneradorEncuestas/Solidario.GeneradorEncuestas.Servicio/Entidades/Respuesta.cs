//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solidario.GeneradorEncuestas.Servicio.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Respuesta
    {
        public int IdRespuesta { get; set; }
        public int IdPregunta { get; set; }
        public int IdCliente { get; set; }
        public Nullable<int> IdValoresPregunta { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Pregunta Pregunta { get; set; }
        public virtual ValoresPregunta ValoresPregunta { get; set; }
    }
}
