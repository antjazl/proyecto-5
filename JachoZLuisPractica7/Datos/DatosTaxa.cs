using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class DatosTaxa
    {
        BiologiaBdRelacionesEntities contexto;

        public DatosTaxa()
        {
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<taxa> selecionartaxa()
        {
            var consultaRes = from lsttaxa in contexto.taxa
                              select lsttaxa;
            List<taxa> lsttaxaRes = consultaRes.ToList();
            return lsttaxaRes;
        }

        public List<taxa> SeleccionarTaxaPorIDTaxa(long IdTaxa)
        {
            var consulta = from lstTaxa in contexto.taxa
                           where lstTaxa.IdTaxa == IdTaxa
                           select lstTaxa;
            List<taxa> listataxa = consulta.ToList();
            return listataxa;
        }

        public List<TaxaPublicacion> selccionarTaxaporId(long idtaxa)
        {
            var consultarRes = from txataxa in contexto.publicacion
                               join taxaPublicacion in contexto.taxapublicacion on txataxa.IdPublicacion equals taxaPublicacion.IdPublicacion
                               join pPub in contexto.publicacionenlace on txataxa.IdPublicacion equals pPub.IdPublicacion
                               join lstTaxa in contexto.taxa on taxaPublicacion.IdTaxa equals lstTaxa.IdTaxa
                               where lstTaxa.IdTaxa == idtaxa
                               select new TaxaPublicacion
                               {
                                   IdTaxa = lstTaxa.IdTaxa,
                                   IdPublicacion = taxaPublicacion.IdPublicacion,
                                   Principal = taxaPublicacion.Principal,
                                   Nombre = lstTaxa.Nombre,
                                   NombreCorto = lstTaxa.NombreCorto,
                                   Titulo = txataxa.Titulo,
                                   Editor = txataxa.Editor,
                                   
                                   NombreArchivo = pPub.NombreArchivo,
                                   EnlaceArchivo = pPub.EnlaceArchivo,
                                   Descarga = pPub.Descarga,
                               };

            List<TaxaPublicacion> selecRes = consultarRes.ToList();
            return selecRes;
        }
    }
}
