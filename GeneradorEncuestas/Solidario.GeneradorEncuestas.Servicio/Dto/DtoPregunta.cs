using System.Collections.Generic;

namespace Solidario.GeneradorEncuestas.Servicio.Dto
{
    public class DtoPregunta
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public bool EsObligatorio { get; set; }
        public DtoTipoPregunta TipoPregunta { get; set; }
        public List<DtoValoresPregunta> ValoresPregunta { get; set; }
    }
}