using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;

namespace fundimetal_core
{
     public class HelperString
    {
        public  static String  GetFechaDocumento()
        {

            String fechaRetorna = String.Format("Cali, {0} {1}/{2}", GetNombreMes(),DateTime.Now.ToString("dd"), DateTime.Now.ToString("yyyy"));

            return fechaRetorna;
        }

        private static String  GetNombreMes()
        {
            string  MesNumero = DateTime.Now.ToString("MM");
            string MesNombre="";


            switch (MesNumero)
            {
                case "01":
                    MesNombre= "Enero";
                    break;
                case "02":
                    MesNombre = "Febrero";
                    break;
                case "03":
                    MesNombre = "Marzo";
                    break;

                case "04":
                    MesNombre = "Abril";
                    break;

                case "05":
                    MesNombre = "Mayo";
                    break;

                case "06":
                    MesNombre = "Junio";
                    break;

                case "07":
                    MesNombre = "Julio";
                    break;

                case "08":
                    MesNombre = "Agosto";
                    break;

                case "09":
                    MesNombre = "Septiembre";
                    break;

                case "10":
                    MesNombre = "Octubre";
                    break;
                case "11":
                    MesNombre = "Noviembre";
                    break;
                case "12":
                    MesNombre = "Diciembre";
                    break;
                default:
                    break;
                   
            }
            return MesNombre;
          
        }
    }

   
}
