using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class LogicaTaxa
    {
        DatosTaxa modelo = new DatosTaxa();

        public List<taxa> seleccionarTaxa()
        {
            return modelo.selecionartaxa();
        }
        public List<taxa> SeleccionarTaxaPorId(long IdTaxa)
        {
            return modelo.SeleccionarTaxaPorIDTaxa(IdTaxa);
        }
        public List<TaxaPublicacion> seleccionarTaxaPublicaciones(long idTaxa)
        {
            return modelo.selccionarTaxaporId(idTaxa);
        }
    }
}