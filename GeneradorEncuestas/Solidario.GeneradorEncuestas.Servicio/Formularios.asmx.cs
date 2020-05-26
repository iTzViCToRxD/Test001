using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Solidario.GeneradorEncuestas.Servicio.Dto;
using Solidario.GeneradorEncuestas.Servicio.Negocio;

namespace Solidario.GeneradorEncuestas.Servicio
{
    /// <summary>
    /// Descripción breve de Formularios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Formularios : System.Web.Services.WebService
    {
        [WebMethod]
        public DtoFormulario GetFormularioPorCodigo(string codigoFormulario)
        {
            return new LNFormulario().GetFormularioPorCodigo(codigoFormulario);
        }
    }
}
