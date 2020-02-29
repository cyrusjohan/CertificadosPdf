using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundimetal_core.Model
{
    public class ExportacionModel
    {


        //encabezado   
     
        public String NumeroCertificado { get; set; }
        public String Cliente { get; set; }
        public String  Producto { get; set; }

        public int  PesoNeto { get; set; }
        public int PesoBruto { get; set; }

        public String  NumeroFactura { get; set; }
        public String  MarcaEmbalaje   { get; set; }
        public String  Presentacion   { get; set; }



        // Pie de pagina
        public String Observaciones { get; set; }
        public String  Container { get; set; }

        public String Lingotes { get; set; }

        public String  Embalaje { get; set; }

        public DataTable dtMelts { get; set; }
        public DataTable dtElementos { get; set; }

        public ExportacionModel()
        {

        }




    }
}
