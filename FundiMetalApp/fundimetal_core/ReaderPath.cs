using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace fundimetal.Core
{
    public class ReaderPath
    {
        #region Vars

        private string _pathXmlConfiguracionRutas = "";
        private string _pathXmlFuente = "";
        private string _pathXmlRutaSalida = "";

        XmlDocument xdocRutas = null;


        #endregion


        public ReaderPath()
        {
            _pathXmlConfiguracionRutas = Path.Combine (Environment.CurrentDirectory, "Referencia\\Rutas.xml");

             xdocRutas = new XmlDocument();
            xdocRutas.Load(_pathXmlConfiguracionRutas);
        }

    
        /// <summary>
        /// Permite retornar la ruta del xml fuente que esta configurada
        /// </summary>
      

        public Dictionary<string,string> getRutaXmlSalida()
        {
            //List<string> archivosXmlFuente = new List<string>();
            Dictionary<string, string> DicArchivosXmlFuente = new Dictionary<string, string>();

            if (xdocRutas != null)
            {
               XmlNodeList nodeFiles = xdocRutas.SelectNodes("/ConfiguracionRutas/RutaXmlFuente/File");

                foreach (XmlNode nodeFile in nodeFiles)
                {
                    DicArchivosXmlFuente.Add(nodeFile.Attributes[0].InnerText, nodeFile.InnerText);
                }
                    
                return DicArchivosXmlFuente;

            }
            return null;
        }


        /// <summary>
        /// Retorna la ruta donde se generan los archivos PDF en la maquina
        /// </summary>
        /// <returns>ruta salida pdf </returns>
        public string getRutaGeneracionCertificados()
        {
            if (xdocRutas != null)
            {
                var xnode = xdocRutas.SelectSingleNode("/ConfiguracionRutas/RutaGeneracionCertificados");

                return xnode.InnerText;

            }
            return "";
        }
    }
}
