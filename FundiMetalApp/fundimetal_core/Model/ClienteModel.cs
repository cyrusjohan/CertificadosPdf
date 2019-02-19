using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundimetal_core.Model
{
    public class ClienteModel
    {

        public String IdCLiente { get; set; }
        public String NombreCliente { get; set; }
        public String Descripcion { get; set; }
        public List<EspeficiacionElementosCliente> lstEspeficacionesElementos = new List<EspeficiacionElementosCliente>();
    }


    public class EspeficiacionElementosCliente
    {

        public String IdDetalle { get; set; }
        public String Simbolo { get; set; }
        public String Elemento { get; set; }
        public String Min { get; set; }
        public String Max { get; set; }
    }
}
