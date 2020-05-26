using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Solidario.GeneradorEncuestas.Servicio.Entidades;

namespace Solidario.GeneradorEncuestas.Servicio.Datos
{
    public class DALCDatos
    {
        #region Formulario
        public Formulario GetFormularioPorCodigo(string codigoFormulario)
        {
            using (var con = new GeneradorEncuestasEntidades())
            {
                return con.Formularios.Where(f => f.Codigo.Equals(codigoFormulario)).FirstOrDefault();
            }
        }
        #endregion

        #region Pregunta
        public List<Pregunta> GetPreguntasVisiblesPorIdFormulario(int idFormulario)
        {
            using (var con = new GeneradorEncuestasEntidades())
            {
                return con.Preguntas.Where(p => p.IdFormulario.Equals(idFormulario) && p.EsVisible.Equals(true)).OrderBy(o => o.Orden).ToList();
            }

        }
        #endregion

        #region Tipo Pregunta
        public List<TipoPregunta> GetListaTipoPreguntas()
        {
            using (var con = new GeneradorEncuestasEntidades())
            {
                return con.TipoPreguntas.ToList();
            }
        }
        #endregion

        #region Valores Pregunta
        public List<ValoresPregunta> GetListaValoresPreguntasVisiblesPorIdPregunta(int idPregunta)
        {
            using (var con = new GeneradorEncuestasEntidades())
            {
                return con.ValoresPreguntas.Where(vp => vp.IdPregunta.Equals(idPregunta) && vp.EsVisible.Equals(true)).OrderBy(o => o.Orden).ToList();
            }
        }
        #endregion
    }
}