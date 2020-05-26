using System.Collections.Generic;

namespace Solidario.GeneradorEncuestas.Servicio.Dto
{
    public class DtoFormulario
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public List<DtoPregunta> Preguntas { get; set; }
    }
}