using Solidario.GeneradorEncuestas.Servicio.Datos;
using Solidario.GeneradorEncuestas.Servicio.Dto;
using Solidario.GeneradorEncuestas.Servicio.Entidades;
using System.Collections.Generic;

namespace Solidario.GeneradorEncuestas.Servicio.Negocio
{
    public class LNFormulario
    {
        public DtoFormulario GetFormularioPorCodigo(string codigoFormulario)
        {
            DALCDatos datos = new DALCDatos();


            DtoFormulario retorno = new DtoFormulario();
            
            Formulario formulario = datos.GetFormularioPorCodigo(codigoFormulario);
            retorno.Id = formulario.IdFormulario;
            retorno.Codigo = formulario.Codigo;
            retorno.Descripcion = formulario.Descripcion;

            List<TipoPregunta> leTipoPregunta = datos.GetListaTipoPreguntas();



            List<DtoPregunta> dtoListaPregunta = new List<DtoPregunta>();
            List<Pregunta> lePregunta = datos.GetPreguntasVisiblesPorIdFormulario(formulario.IdFormulario);
            lePregunta.ForEach(lp => {
                TipoPregunta eTipoPregunta = leTipoPregunta.Find(f => f.IdTipoPregunta.Equals(lp.IdTipoPregunta));
                DtoTipoPregunta tipoPregunta = new DtoTipoPregunta { Id = eTipoPregunta.IdTipoPregunta, Codigo = eTipoPregunta.Codigo, Nombre = eTipoPregunta.Nombre };

                List<DtoValoresPregunta> listaValoresPregunta = new List<DtoValoresPregunta>();
                List<ValoresPregunta> leValoresPregunta = datos.GetListaValoresPreguntasVisiblesPorIdPregunta(lp.IdPregunta);
                leValoresPregunta.ForEach(lvp => {
                    listaValoresPregunta.Add(new DtoValoresPregunta {
                        Id = lvp.IdValoresPregunta,
                        Valor = lvp.Valor,
                        Orden = lvp.Orden
                    });
                });

                dtoListaPregunta.Add(new DtoPregunta
                {
                    Id = lp.IdPregunta,
                    Codigo = lp.Codigo,
                    Orden = lp.Orden,
                    Descripcion = lp.Descripcion,
                    EsObligatorio = lp.EsObligatorio,
                    TipoPregunta = tipoPregunta,
                    ValoresPregunta = listaValoresPregunta                    
                });
            });
            retorno.Preguntas = dtoListaPregunta;

            return retorno;
        }
    }
}