using fundimetal_core;
using fundimetal_core.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace fundimetal.Core
{
    public class XmlRepository : IRepository
    {

        private string rutaXmlCLiente = "";
        private string rutaXmlInfoCLiente = "";
        private string rutaXmlTipoProducto = "";
        private string rutaXmlTipoLingote = "";



        public XmlRepository()
        {
            rutaXmlCLiente = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\TablaClientes.xml";
            rutaXmlInfoCLiente = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\InfoClientes.xml";
            rutaXmlTipoProducto = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\TipoProducto.xml";
            rutaXmlTipoLingote = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\TipoLingotes.xml";
    }

        /// <summary>
        /// Retorna la informacion completa para el visor 
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="rutaArchivoXmlFuente">Ruta del xml fuente</param>
        /// <returns></returns>
        public DataTable GetAllDataBurns(List<String> errors, string rutaArchivoXmlFuente)
        {
            Boolean errorLoad = false;
            XmlDocument xdoc = this.LoadXml(errorLoad, rutaArchivoXmlFuente);

            if (errorLoad)
            {
                errors.Add("[Error] No existe o la ruta XML fuente no es accesible");
                return null;
            }

            DtInfo dtinfo = new DtInfo();
            DataTable DtInfogrid = dtinfo.Tables["DtInfogrid"];
            XmlNodeList xNodesBurns = xdoc.SelectNodes("/*[local-name() = 'SampleData']/*[local-name() = 'Burns'][*[local-name() = 'IsAvg']='True']");
            int contador = 0;

            #region Recorre todos los nodos AVG = True;

            foreach (XmlNode nodeRow in xNodesBurns)

            {

                contador++;
                var date = nodeRow.SelectSingleNode("*[local-name() = 'Date']");
                var Time = nodeRow.SelectSingleNode("*[local-name() = 'Time']");
                var NombreCliente = nodeRow.SelectSingleNode("*[local-name() = 'HeaderName']");
                var Lote = nodeRow.SelectSingleNode("*[local-name() = 'Label_Value']");

                ///Elementos
                #region Mapeo de los elementos

                var Pb = nodeRow.SelectSingleNode("*[local-name() = 'CH12L1']");

                var Cu = nodeRow.SelectSingleNode("*[local-name() = 'CH13L12']");

                var Sn = nodeRow.SelectSingleNode("*[local-name() = 'CH11L12']");

                var Ag = nodeRow.SelectSingleNode("*[local-name() = 'CH14L12']");

                var Ca = nodeRow.SelectSingleNode("*[local-name() = 'CH17L12']");

                var Al = nodeRow.SelectSingleNode("*[local-name() = 'CH18L12']");

                var Ni = nodeRow.SelectSingleNode("*[local-name() = 'CH15L12']");

                var Fe = nodeRow.SelectSingleNode("*[local-name() = 'CH16L12']");

                var Bi = nodeRow.SelectSingleNode("*[local-name() = 'CH10L12']");

                var Se = nodeRow.SelectSingleNode("*[local-name() = 'CH03L12']");

                var Zn = nodeRow.SelectSingleNode("*[local-name() = 'CH04L12']");

                var Cd = nodeRow.SelectSingleNode("*[local-name() = 'CH05L12']");

                var Sb = nodeRow.SelectSingleNode("*[local-name() = 'CH06L12']");
                var Sb_2 = nodeRow.SelectSingleNode("*[local-name() = 'CH09L12']"); // Utilizado para el segundo archivo

                var As = nodeRow.SelectSingleNode("*[local-name() = 'CH07L12']");

                var Te = nodeRow.SelectSingleNode("*[local-name() = 'CH19L12']");
                #endregion

                DtInfo.DtInfogridRow row = dtinfo.DtInfogrid.NewDtInfogridRow();

                #region Fecha
                if (date != null)
                {
                    row.Fecha = date.InnerText;
                }
                else
                {
                    row.Fecha = "";
                }
                #endregion

                #region Hora

                // Hora
                if (Time != null) { row.Hora = Time.InnerText; } else { row.Hora = ""; }

                #endregion

                #region Nombre de cliente

                if (NombreCliente != null)
                {
                    row.NombreCliente = NombreCliente.InnerText;
                }
                else
                {
                    row.NombreCliente = "";
                }
                #endregion

                #region Lote

                if (Lote != null)
                {
                    row.Lote = Lote.InnerText;
                }
                else
                {
                    row.Lote = "";
                }
                #endregion

                #region Elementos

                row.Pb = (Pb != null ? Pb.InnerText : "0.000");
                row.Cu = (Cu != null ? Cu.InnerText : "0.000");
                row.Sn = (Sn != null ? Sn.InnerText : "0.000");
                row.Ag = (Ag != null ? Ag.InnerText : "0.000");
                row.Ca = (Ca != null ? Ca.InnerText : "0.000");
                row.Al = (Al != null ? Al.InnerText : "0.000");
                row.Ni = (Ni != null ? Ni.InnerText : "0.000");
                row.Fe = (Fe != null ? Fe.InnerText : "0.000");
                row.Bi = (Bi != null ? Bi.InnerText : "0.000");
                row.Se = (Se != null ? Se.InnerText : "0.000");
                row.Zn = (Zn != null ? Zn.InnerText : "0.000");
                row.Cd = (Cd != null ? Cd.InnerText : "0.000");
                row.Te = (Te != null ? Te.InnerText : "0.000"); 
                if (Sb != null && Sb.InnerText.Trim().Length > 0)
                {
                    row.Sb = Sb.InnerText.Trim();
                }
                else if (Sb_2 != null && Sb_2.InnerText.Trim().Length > 0)
                {
                    row.Sb = Sb_2.InnerText.Trim(); // Solo aplica  por que no existe en archivo de Aleacion pura
                }
                //row.Sb = (Sb != null ? Sb.InnerText : "0.000");
                row.As = (As != null ? As.InnerText : "0.000");
                #endregion



                //Adicion de fila
                DtInfogrid.Rows.Add(row);

            }

            #endregion

            if (DtInfogrid.Rows.Count > 0)
            {
                return DtInfogrid;
            }

            return null;

        }


        /// <summary>
        /// Retorna tabla con informacion de cliente
        /// </summary>
        /// <param name="xdoc"></param>
        /// <returns>datatable</returns>
        public DataTable getEspecificacionClientes(XmlDocument xdoc)
        {

            DtInfo dtinfo = new DtInfo();
            DataTable dtCliente = dtinfo.Tables["Cliente"];
            XmlNodeList xnodeList = xdoc.SelectNodes("/Clientes/Cliente");

            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");
                XmlNode Descripcion = nodeRow.SelectSingleNode("Descripcion");
                


                DtInfo.ClienteRow row = dtinfo.Cliente.NewClienteRow();
                row.Id = id.InnerText;
                row.Nombre = Nombre.InnerText;
                row.Descripcion = Descripcion.InnerText;
                
                //Adiciona fila
                dtCliente.Rows.Add(row);
            }

            return dtCliente;
        }

        /// <summary>
        /// Retorna la informacion de clientes
        /// </summary>
        /// <param name="xdoc"></param>
        /// <returns></returns>
        public DataTable getInfoClientes(XmlDocument xdoc)
        {

            DtInfo dtinfo = new DtInfo();
            DataTable dtCliente = dtinfo.Tables["InfoCliente"];
            XmlNodeList xnodeList = xdoc.SelectNodes("/Clientes/Cliente");

            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");
                XmlNode direccion = nodeRow.SelectSingleNode("Direccion");



                DtInfo.InfoClienteRow row = dtinfo.InfoCliente.NewInfoClienteRow();
                row.Id = id.InnerText;
                row.Nombre = Nombre.InnerText;
                row.Direccion = direccion.InnerText;

                //Adiciona fila
                dtCliente.Rows.Add(row);
            }

            return dtCliente;
        }

        public DataTable GetInfoClientesById( string idCliente)
        {
            DataTable dtElementos = new DataTable();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(rutaXmlCLiente);

            dtElementos.Columns.Add("Id", typeof(string));
            dtElementos.Columns.Add("Nombre", typeof(string));
            dtElementos.Columns.Add("Simbolo", typeof(string));
            dtElementos.Columns.Add("Min", typeof(string));
            dtElementos.Columns.Add("Max", typeof(string)); 

            List<ListItemCombo> lstCombo = new List<ListItemCombo>();
            XmlNodeList xnodeList = xdoc.SelectNodes("/Clientes/Cliente[Id='"+ idCliente + "']/Elementos/Elemento");
 
            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");
                XmlNode Simbolo = nodeRow.SelectSingleNode("Simbolo");
                XmlNode Min = nodeRow.SelectSingleNode("Min");
                XmlNode Max = nodeRow.SelectSingleNode("Max");
                dtElementos.Rows.Add(id.InnerText, Nombre.InnerText, Simbolo.InnerText.Trim(), Min.InnerText.Trim(), Max.InnerText.Trim());
            }

            return dtElementos;

        }

        public List<ListItemCombo> GetInfoClientesComboBox()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(rutaXmlCLiente);

            List<ListItemCombo> lstCombo = new List<ListItemCombo>();
             XmlNodeList xnodeList = xdoc.SelectNodes("/Clientes/Cliente");

            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");                
                lstCombo.Add(new ListItemCombo { Text = Nombre.InnerText, Value = id.InnerText.ToString() });
            }

            return lstCombo;
        }

        /// <summary>
        /// Retorna la informacion de contacto de los clientes
        /// </summary>
        /// <returns></returns>
        public List<ListItemCombo> GetInformacionClientesComboBox()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(rutaXmlInfoCLiente);

            List<ListItemCombo> lstCombo = new List<ListItemCombo>();
            XmlNodeList xnodeList = xdoc.SelectNodes("/Clientes/Cliente");

            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");
                lstCombo.Add(new ListItemCombo { Text = Nombre.InnerText, Value = id.InnerText.ToString() });
            }

            return lstCombo;
        }


        /// <summary>
        /// Lectura del archivo fuente de inicio
        /// </summary>
        /// <param name="isError"></param>
        /// <param name="rutaArchivoXmlFuente"></param>
        /// <returns></returns>
        private XmlDocument LoadXml(Boolean isError, string rutaArchivoXmlFuente)
        {

            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                var urlXmlFile = rutaArchivoXmlFuente;
                doc.Load(urlXmlFile);
            }
            catch (Exception e)
            {
                isError = true;
                return null;
            }

            return doc;
        }


        /// <summary>
        /// Permite guardar un cliente nuevo
        /// </summary>
        /// <param name="clienteModel"></param>
        /// <returns></returns>
        public bool SaveOrEditCliente(ClienteModel clienteModel)
        {
            bool isError = false;
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(this.rutaXmlCLiente);

            if (string.IsNullOrEmpty(clienteModel.IdCLiente))
            {
                this.SaveNewCliente(xdoc, clienteModel);
            }
            else
            {
                this.SaveEditCliente(xdoc, clienteModel);
            }

            return isError;
        }


        /// <summary>
        /// Permite guardar editar informacion
        /// </summary>
        /// <param name="xdoc"></param>
        /// <param name="clienteModel"></param>
        private void SaveEditCliente(XmlDocument xdoc, ClienteModel clienteModel)
        {
            XmlNode xnodeCliente = xdoc.SelectSingleNode("/Clientes/Cliente[Id='" + clienteModel.IdCLiente + "']");

            XmlNode IDCliente = xnodeCliente.SelectSingleNode("Id");
            XmlNode xmNodelNombre = xnodeCliente.SelectSingleNode("Nombre");
            XmlNode xmlNodeDescripcion = xnodeCliente.SelectSingleNode("Descripcion");

            //Modifico Informacion del cliente
            
            xmNodelNombre.InnerText = clienteModel.NombreCliente;
            xmlNodeDescripcion.InnerText = clienteModel.Descripcion;
            IDCliente.InnerText = clienteModel.IdCLiente;

            // Borro todos detalles
            XmlNode xnodeDet = xdoc.SelectSingleNode("/Clientes/Cliente[Id='" + clienteModel.IdCLiente + "']/Elementos");
            XmlNodeList xnodeList = xdoc.SelectNodes("/Clientes/Cliente[Id='" + clienteModel.IdCLiente + "']/Elementos/Elemento");
            foreach (XmlNode item in xnodeList)
            {
                xnodeDet.RemoveChild(item);
            }

            int idDetalle = 0;
            foreach (var item in clienteModel.lstEspeficacionesElementos)
            {
                idDetalle++;

                XmlElement nodeElemento = xdoc.CreateElement("Elemento");
                xnodeDet.AppendChild(nodeElemento);

                #region ID

                XmlElement xnodeId = xdoc.CreateElement("Id");
                xnodeId.InnerText = idDetalle.ToString(); // cambiar a una mas unica 
                #endregion

                #region Nombre

                XmlElement xnodeNombre = xdoc.CreateElement("Nombre");
                xnodeNombre.InnerText = item.Elemento;
                #endregion

                #region Simbolo

                XmlElement xNodeSimbolo = xdoc.CreateElement("Simbolo");
                xNodeSimbolo.InnerText = item.Simbolo;
                #endregion


                #region Min

                XmlElement xNodeMin = xdoc.CreateElement("Min");
                xNodeMin.InnerText = item.Min;
                #endregion

                #region Max

                XmlElement xNodeMax = xdoc.CreateElement("Max");
                xNodeMax.InnerText = item.Max;
                #endregion

                nodeElemento.AppendChild(xnodeId);
                nodeElemento.AppendChild(xnodeNombre);
                nodeElemento.AppendChild(xNodeSimbolo);
                nodeElemento.AppendChild(xNodeMin);
                nodeElemento.AppendChild(xNodeMax);

            }

            xdoc.Save(this.rutaXmlCLiente);

         
            
            //foreach (XmlNode nodeRow in xnodeList)
            //{
                
            //    XmlNode IdDetalle = nodeRow.SelectSingleNode("Id");
            //    XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");
            //    XmlNode Simbolo = nodeRow.SelectSingleNode("Simbolo");
            //    XmlNode Min = nodeRow.SelectSingleNode("Min");
            //    XmlNode Max = nodeRow.SelectSingleNode("Max");

            //    cliente.lstEspeficacionesElementos.Add(new EspeficiacionElementosCliente
            //    {
            //        IdDetalle = IdDetalle.InnerText,
            //        Elemento = Nombre.InnerText,
            //        Simbolo = Simbolo.InnerText.Trim(),
            //        Min = Min.InnerText.Trim(),
            //        Max = Max.InnerText.Trim()

            //    });

            //}
        }


        /// <summary>
        /// Permite guardar la informacion nuevo registro
        /// </summary>
        /// <param name="xdoc"></param>
        /// <param name="clienteModel"></param>
        private void SaveNewCliente(XmlDocument xdoc , ClienteModel clienteModel)
        {

            XmlElement rootCliente = xdoc.CreateElement("Cliente");

            XmlElement id = xdoc.CreateElement("Id");
            id.InnerText = GetPkcliente(xdoc);//  "5"; //Pendiente auto generar

            XmlElement Nombre = xdoc.CreateElement("Nombre");
            Nombre.InnerText = clienteModel.NombreCliente;

            XmlElement Descripcion = xdoc.CreateElement("Descripcion");
            Descripcion.InnerText = clienteModel.Descripcion;

            //Informacion del encabezado de un cliente
            rootCliente.AppendChild(id);
            rootCliente.AppendChild(Nombre);
            rootCliente.AppendChild(Descripcion);

            XmlElement nodePadreElementos = xdoc.CreateElement("Elementos");


            #region Detalles




            rootCliente.AppendChild(nodePadreElementos); // Lo adiciona al nodo padre
            int idDetalle = 0;
            foreach (var item in clienteModel.lstEspeficacionesElementos)
            {
                idDetalle++;

                XmlElement nodeElemento = xdoc.CreateElement("Elemento");
                nodePadreElementos.AppendChild(nodeElemento);

                #region ID

                XmlElement xnodeId = xdoc.CreateElement("Id");
                xnodeId.InnerText = idDetalle.ToString(); // cambiar a una mas unica 
                #endregion

                #region Nombre

                XmlElement xnodeNombre = xdoc.CreateElement("Nombre");
                xnodeNombre.InnerText = item.Elemento;
                #endregion

                #region Simbolo

                XmlElement xNodeSimbolo = xdoc.CreateElement("Simbolo");
                xNodeSimbolo.InnerText = item.Simbolo;
                #endregion


                #region Min

                XmlElement xNodeMin = xdoc.CreateElement("Min");
                xNodeMin.InnerText = item.Min;
                #endregion

                #region Max

                XmlElement xNodeMax = xdoc.CreateElement("Max");
                xNodeMax.InnerText = item.Max;
                #endregion

                nodeElemento.AppendChild(xnodeId);
                nodeElemento.AppendChild(xnodeNombre);
                nodeElemento.AppendChild(xNodeSimbolo);
                nodeElemento.AppendChild(xNodeMin);
                nodeElemento.AppendChild(xNodeMax);

            }

            #endregion


            // Adiciciona un nodo <Cliente> a la raiz pabdre
            xdoc.DocumentElement.AppendChild(rootCliente);

            //Guarda Documento
            xdoc.Save(this.rutaXmlCLiente);


        }

        private String GetPkcliente(XmlDocument xdoc) => (xdoc.SelectNodes("/Clientes/Cliente").Count + 1).ToString();


        /// <summary>
        /// Permite retornar la informacion completa de un cliente 
        /// </summary>
        /// <param name="xDocCliente"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ClienteModel GetClienteById( string Id)
        {
            ClienteModel cliente = new ClienteModel();

            XmlDocument xDocCliente = new XmlDocument();

            xDocCliente.Load(this.rutaXmlCLiente);

            List<ListItemCombo> lstCombo = new List<ListItemCombo>();
            XmlNode xnodeCliente = xDocCliente.SelectSingleNode("/Clientes/Cliente[Id='" + Id + "']");

            XmlNode IDCliente = xnodeCliente.SelectSingleNode("Id");
            XmlNode xmNodelNombre = xnodeCliente.SelectSingleNode("Nombre");
            XmlNode xmlNodeDescripcion = xnodeCliente.SelectSingleNode("Descripcion");

            //Informacion del cliente
            cliente.IdCLiente = IDCliente.InnerText;
            cliente.NombreCliente = xmNodelNombre.InnerText;
            cliente.Descripcion = xmlNodeDescripcion.InnerText;

            //Detalles 
            XmlNodeList xnodeList = xDocCliente.SelectNodes("/Clientes/Cliente[Id='" + Id + "']/Elementos/Elemento");

            foreach (XmlNode nodeRow in xnodeList)
            {
                               
                XmlNode IdDetalle = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");
                XmlNode Simbolo = nodeRow.SelectSingleNode("Simbolo");
                XmlNode Min = nodeRow.SelectSingleNode("Min");
                XmlNode Max = nodeRow.SelectSingleNode("Max");

                cliente.lstEspeficacionesElementos.Add(new EspeficiacionElementosCliente {
                     IdDetalle = IdDetalle.InnerText,
                    Simbolo = Simbolo.InnerText.Trim(),
                    Elemento = Nombre.InnerText,
                      
                        Min = Min.InnerText.Trim(),
                        Max = Max.InnerText.Trim()

                });
              
            }

            return cliente;
        }

        public bool SaveOrEditInfoCliente(ClienteModel clienteModel)
        {
            bool isError = false;
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(this.rutaXmlInfoCLiente);

            if (string.IsNullOrEmpty(clienteModel.IdCLiente))
            {
                this.SaveNewInfoCliente(xdoc, clienteModel);
            }
            else
            {
                this.SaveEditInfoCliente(xdoc, clienteModel);
            }

            return isError;
        }

        private void SaveEditInfoCliente(XmlDocument xdoc, ClienteModel clienteModel)
        {
            XmlNode xnodeCliente = xdoc.SelectSingleNode("/Clientes/Cliente[Id='" + clienteModel.IdCLiente + "']");

            XmlNode IDCliente = xnodeCliente.SelectSingleNode("Id");
            XmlNode xmNodelNombre = xnodeCliente.SelectSingleNode("Nombre");
            XmlNode xmlNodeDireccion = xnodeCliente.SelectSingleNode("Direccion");

            //Modifico Informacion del cliente

            xmNodelNombre.InnerText = clienteModel.NombreCliente;
            xmlNodeDireccion.InnerText = clienteModel.Descripcion;  // se usa para  la direccion
            IDCliente.InnerText = clienteModel.IdCLiente;

    
            xdoc.Save(this.rutaXmlInfoCLiente);


        }

        private void SaveNewInfoCliente(XmlDocument xdoc, ClienteModel clienteModel)
        {
           
                XmlElement rootCliente = xdoc.CreateElement("Cliente");

                XmlElement id = xdoc.CreateElement("Id");
                id.InnerText = GetPkcliente(xdoc);//  "5"; //Pendiente auto generar

                XmlElement Nombre = xdoc.CreateElement("Nombre");
                Nombre.InnerText = clienteModel.NombreCliente;

                XmlElement direccion = xdoc.CreateElement("Direccion");
                direccion.InnerText = clienteModel.Descripcion;

                //Informacion del encabezado de un cliente
                rootCliente.AppendChild(id);
                rootCliente.AppendChild(Nombre);
                rootCliente.AppendChild(direccion);

             

                // Adiciciona un nodo <Cliente> a la raiz pabdre
                xdoc.DocumentElement.AppendChild(rootCliente);

                //Guarda Documento
                xdoc.Save(this.rutaXmlInfoCLiente);

            
        }


        /// <summary>
        /// Permite obtener un solo registro busqueda por ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ClienteModel GetInfoClienteById(string Id)
        {
            ClienteModel cliente = new ClienteModel();

            XmlDocument xDocCliente = new XmlDocument();

            xDocCliente.Load(this.rutaXmlInfoCLiente);

            List<ListItemCombo> lstCombo = new List<ListItemCombo>();
            XmlNode xnodeCliente = xDocCliente.SelectSingleNode("/Clientes/Cliente[Id='" + Id + "']");

            XmlNode IDCliente = xnodeCliente.SelectSingleNode("Id");
            XmlNode xmNodelNombre = xnodeCliente.SelectSingleNode("Nombre");
            XmlNode xmlNodeDireccion = xnodeCliente.SelectSingleNode("Direccion");

            //Informacion del cliente
            cliente.IdCLiente = IDCliente.InnerText;
            cliente.NombreCliente = xmNodelNombre.InnerText;
            cliente.Descripcion = xmlNodeDireccion.InnerText;



            return cliente;
        }

        public DataTable getTipoProducto(XmlDocument xdoc)
        {
            DtInfo dtinfo = new DtInfo();
            DataTable data = dtinfo.Tables["TipoProducto"];
            XmlNodeList xnodeList = xdoc.SelectNodes("/Info/TipoProducto");

            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");

                DtInfo.TipoProductoRow row = dtinfo.TipoProducto.NewTipoProductoRow();
                //row.Id = id.InnerText;
                row.Nombre = Nombre.InnerText;


                //Adiciona fila
                data.Rows.Add(row);
            }

            return data;
        }

        public DataTable getTipoLingote(XmlDocument xdoc)
        {
            DtInfo dtinfo = new DtInfo();
            DataTable data = dtinfo.Tables["TipoLingotes"];
            XmlNodeList xnodeList = xdoc.SelectNodes("/Info/TipoLingote");

            foreach (XmlNode nodeRow in xnodeList)
            {
                XmlNode id = nodeRow.SelectSingleNode("Id");
                XmlNode Nombre = nodeRow.SelectSingleNode("Nombre");




                DtInfo.TipoLingotesRow row = dtinfo.TipoLingotes.NewTipoLingotesRow();
                row.Id = id.InnerText;
                row.Nombre = Nombre.InnerText;


                //Adiciona fila
                data.Rows.Add(row);
            }

            return data;
        }

        public bool SaveOrEditParameter(DataTable dtTipoProducto, DataTable dtLingotes)
        {

            return true;

          
        }

        public bool SaveOrEditTipoProduct(DataTable dataSource, XmlDocument xdoc)
        {


          XmlNode root1 =  xdoc.DocumentElement;
            root1.RemoveAll();

            int i = 1;
            foreach (DataRow item in dataSource.Rows)
            {
                XmlElement root = xdoc.CreateElement("TipoProducto");

                XmlElement id = xdoc.CreateElement("Id");
                id.InnerText = i.ToString();

                XmlElement Nombre = xdoc.CreateElement("Nombre");
                Nombre.InnerText = item[0].ToString();

                

                //Informacion del encabezado de un cliente
                root.AppendChild(id);
                root.AppendChild(Nombre);
              



                // Adiciciona un nodo <Cliente> a la raiz pabdre
                xdoc.DocumentElement.AppendChild(root);
                i++;
                
            }
            //Guarda Documento
            xdoc.Save(this.rutaXmlTipoProducto);


            return true;
        }

        public void SaveEditLingote(DataTable dataSource, XmlDocument xdoc)
        {

            XmlNode root1 = xdoc.DocumentElement;
            root1.RemoveAll();

            int i = 1;
            foreach (DataRow item in dataSource.Rows)
            {
                XmlElement root = xdoc.CreateElement("TipoLingote");

                XmlElement id = xdoc.CreateElement("Id");
                id.InnerText = i.ToString();

                XmlElement Nombre = xdoc.CreateElement("Nombre");
                Nombre.InnerText = item[1].ToString();



                //Informacion del encabezado de un cliente
                root.AppendChild(id);
                root.AppendChild(Nombre);
                // Adiciciona un nodo <TipoLingote> a la raiz pabdre
                xdoc.DocumentElement.AppendChild(root);
                i++;

            }
            //Guarda Documento
            xdoc.Save(this.rutaXmlTipoLingote);


 
        }
    }


}
