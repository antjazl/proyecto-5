using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using Datos;
using Logica;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        LogicaTaxa logic = new LogicaTaxa();

        [WebMethod]
        public List<taxa> seleccionarTaxa()
        {
            return logic.seleccionarTaxa();
        }
        [WebMethod]
        public List<taxa> seleccionarTaxaPorId(int IdTaxa)
        {
            return logic.SeleccionarTaxaPorId(IdTaxa);
        }
        [WebMethod]
        public List<TaxaPublicacion> SeleccionarTaxaPublicacion(long taxaid)
        {
            return logic.seleccionarTaxaPublicaciones(taxaid);
        }
    }
}