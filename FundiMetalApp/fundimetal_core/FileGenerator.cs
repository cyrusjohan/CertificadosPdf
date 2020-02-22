using fundimetal_core.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace fundimetal_core
{
    public class FileGenerator
    {

        private string rutaSalidaArchivosPDF = string.Empty;
        private string FileNameMask = "{0}_Certificado_Analisis_{1}_{2}.pdf";
        private string FileNameMaskExportacion = "{0}_Certificado_Exportacion_{1}_{2}.pdf";

        private readonly string RutaTemplateXmlArchivo = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\PlantillaCertificado.xml";

        // Variables del contenido del archivo 
        private string HeaderText;
        private string Titulo;
        private string Texto1;
        private string Texto2;

        public string RutaSalidaArchivosPDF { get => rutaSalidaArchivosPDF; set => rutaSalidaArchivosPDF = value; }
        public string Lote;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="RutaSalidaArchivos"></param>
        public FileGenerator(string RutaSalidaArchivos, String lote)
        {
            this.RutaSalidaArchivosPDF = Path.Combine(RutaSalidaArchivos, String.Format(FileNameMask,
                                                                                                    DateTime.Now.ToString("yyyy"),
                                                                                                    lote,
                                                                                                    DateTime.Now.ToString("MMddHHmmss")));
            this.Lote = lote;
            this.SetDataTemplate();
        }

        public FileGenerator(string RutaSalidaArchivos, int NumeroCertificado)
        {
            this.RutaSalidaArchivosPDF = Path.Combine(RutaSalidaArchivos, String.Format(FileNameMaskExportacion,
                                                                                                    DateTime.Now.ToString("yyyy"),
                                                                                                  NumeroCertificado,
                                                                                                    DateTime.Now.ToString("MMddHHmmss")));


        }

        /// <summary>
        /// Establece los datos a mostrar
        /// </summary>
        public void SetDataTemplate()
        {
            XmlDocument xdocPlantilla = new XmlDocument();
            xdocPlantilla.Load(RutaTemplateXmlArchivo);


            this.Titulo = xdocPlantilla.SelectSingleNode("/Template/Title").InnerText;
            this.HeaderText = xdocPlantilla.SelectSingleNode("/Template/Header").InnerText;
            this.Texto1 = xdocPlantilla.SelectSingleNode("/Template/Texto1").InnerText;
            this.Texto2 = xdocPlantilla.SelectSingleNode("/Template/Texto2").InnerText;

        }

        /// <summary>
        /// Permite la creacion del documento completo PDF
        /// </summary>
        /// <param name="dtblTable"></param>
        public void ToMake(DataTable dtblTable, string text_aleacion)
        {
            Boolean esTablaEspecificaDoble = false;

            if (File.Exists(this.RutaSalidaArchivosPDF))
            {
                File.Delete(this.RutaSalidaArchivosPDF);
            }

            #region Creacion Documento

            System.IO.FileStream fs = new FileStream(this.rutaSalidaArchivosPDF, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Fuente Cuerpo del Documento
            // BaseFont baseFontBody = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntBodyBold = new Font(FontFactory.GetFont("Arial", 12, 1, Color.BLACK));
            Font fntBodyNormal = new Font(FontFactory.GetFont("Arial", 12, 0, Color.BLACK));
            Font fntBodyNormal11 = new Font(FontFactory.GetFont("Arial", 11, 0, Color.BLACK));
            Font fntBodyNormal10 = new Font(FontFactory.GetFont("Arial", 10, 0, Color.BLACK));

            #endregion

            #region Logo

            //Logo
            var imagepath = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\logo.jpg";
            var image_PIE_PAGINA = System.AppDomain.CurrentDomain.BaseDirectory + "Referencia\\direccion_pie_pagina.jpg";
            Image jpg = Image.GetInstance(imagepath);
            jpg.Alignment = Image.ALIGN_CENTER;
            document.Add(jpg);



            //Saltos de linea
            document.Add(addSpace(14));
            document.Add(addSpace(14));
            #endregion

            #region Cuerpo del documento
            //Report Header
            //BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font fntHead = new Font(bfntHead, 16, 1, Color.GRAY);
            FontFactory.RegisterDirectories();

            Font fntHead = new Font(FontFactory.GetFont("Arial", 14, 3, Color.BLACK));



            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(this.Titulo, fntHead));
            document.Add(prgHeading);


            //Add line break
            document.Add(new Chunk("\n", fntHead));

            // Linea antes , ahora es parametrizable
            //document.Add(new Chunk("Le certificamos el contenido homogéneo de los elementos en un lote  de Metal súper Puro para Oxido de Baterías,  Marca  Fundimetales, de aprox. 10 tons como sigue ", fntBodyNormal));
            document.Add(new Chunk(string.Format(this.HeaderText, text_aleacion), fntBodyNormal));

            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));

            #endregion

            #region Detalle del documento

            int NumeroColumnas = ObtenerNumeroColumnasEspecificacion(dtblTable);
            if (NumeroColumnas == 5) // Espeficacion tabla Simple 
            {
                esTablaEspecificaDoble = true;
            }
            else
            {
                dtblTable.Columns.Remove("Min");
            }

            //Write the table
            PdfPTable table = new PdfPTable(NumeroColumnas)
            {
                TotalWidth = 360f,
                LockedWidth = true
            };

            #region Lote 

            PdfPCell cellTitulo = new PdfPCell(new Phrase("Lote Identificado", fntBodyNormal11));
            cellTitulo.HorizontalAlignment = PdfCell.ALIGN_LEFT;
            //cellTitulo.Colspan = 2;

            table.AddCell(cellTitulo);

            // Lote
            PdfPCell cellLote = new PdfPCell(new Phrase(this.Lote, fntBodyBold));
            cellLote.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            cellLote.Colspan = 2;
            table.AddCell(cellLote);
            #endregion

            //PdfPCell cellTitulo2 = new PdfPCell(new Phrase("", fntBodyNormal));
            //cellTitulo2.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            //table.AddCell(cellTitulo2);

            PdfPCell cellTitulo3 = new PdfPCell(new Phrase("Especificación", fntBodyNormal11));
            cellTitulo3.HorizontalAlignment = PdfCell.ALIGN_CENTER;

            cellTitulo3.Colspan = (!esTablaEspecificaDoble ? 1 : 2);
            table.AddCell(cellTitulo3);

            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);


            PdfPCell cellElemento = new PdfPCell(new Phrase("Elemento", fntBodyBold));
            cellElemento.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            cellElemento.Colspan = 2;
            table.AddCell(cellElemento);

            PdfPCell cellAnalizado = new PdfPCell(new Phrase("Analizado en %", fntBodyBold));
            cellAnalizado.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            table.AddCell(cellAnalizado);

            if (esTablaEspecificaDoble)
            {
                PdfPCell cellMin = new PdfPCell(new Phrase("Permitidos Min %", fntBodyBold));
                cellMin.HorizontalAlignment = PdfCell.ALIGN_CENTER;
                table.AddCell(cellMin);
            }

            PdfPCell cellPermitido = new PdfPCell(new Phrase("Permitidos Max %", fntBodyBold));
            cellPermitido.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            table.AddCell(cellPermitido);


            //foreach (String tituloEncabezado in Arr_Titulos)
            //{
            //    PdfPCell cell = new PdfPCell
            //    {
            //        BackgroundColor = Color.GRAY
            //    };
            //    cell.AddElement(new Chunk(tituloEncabezado, fntBodyBold));
            //    table.AddCell(cell);
            //}


            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);

            #endregion

            #region Pie de pagina

            //Saltos de linea
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));


            // Ahora es parametrizable
            //String text1 = "Cada lingote de 30 kg promediados tiene nuestra marca   \"Arbolito Reciclaje\" y FUNDIMETAL y una identificación  de lote por una letra.";            
            document.Add(new Chunk(this.Texto1, fntBodyNormal));

            //Saltos de linea
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));


            //String text2 = "Los elementos han sido analizados en nuestro Espectrómetro de Emisión Óptica marca ANGSTROM modelo V-950, de última generación.";

            document.Add(new Chunk(this.Texto2, fntBodyNormal));
            //Saltos de linea
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));


            String fechaDocumento = HelperString.GetFechaDocumento();
            //
            //Cali, Noviembre 27 / 2018
            document.Add(new Chunk(fechaDocumento, fntBodyNormal));

            //Saltos de linea
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));

            // Firma
            Paragraph prgFooter = new Paragraph();
            prgFooter.Alignment = Element.ALIGN_RIGHT;
            prgFooter.Add(new Chunk("A y G  Ingeniería  S.A.S  ", fntBodyBold));
            prgFooter.Add(new Chunk("Nit 890323114-7", fntBodyNormal));
            document.Add(prgFooter);



            Paragraph prgFooter2 = new Paragraph();
            prgFooter2.Alignment = Element.ALIGN_RIGHT;
            prgFooter2.Add(new Chunk("en su establecimiento de comercio ", fntBodyNormal));
            prgFooter2.Add(new Chunk("i - MAQ", fntBodyBold));

            document.Add(prgFooter2);

            document.Add(new Chunk("\n", fntBodyNormal));

            Paragraph prgFooter3 = new Paragraph();
            prgFooter3.Alignment = Element.ALIGN_RIGHT;
            prgFooter3.Add(new Chunk("por V. Miguel Giersberg, Director             ", fntBodyNormal));
            document.Add(prgFooter3);


            //Saltos de linea
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));


            Image jpgPIE_PAGINA = Image.GetInstance(image_PIE_PAGINA);
            jpgPIE_PAGINA.Alignment = Image.ALIGN_CENTER;
            document.Add(jpgPIE_PAGINA);

            #endregion

            document.Close();
            writer.Close();


            fs.Close();

        }

        public void ToMakeExportacion(DataTable tablaAnalisQuimico, ExportacionModel exportacionModel)
        {
            if (File.Exists(this.RutaSalidaArchivosPDF))
            {
                File.Delete(this.RutaSalidaArchivosPDF);
            }

            #region Creacion Documento
            float TotalWidth = 216f;

            System.IO.FileStream fs = new FileStream(this.rutaSalidaArchivosPDF, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Fuente Cuerpo del Documento
            // BaseFont baseFontBody = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntBodyBold = new Font(FontFactory.GetFont("Arial", 12, 1, Color.BLACK));
            Font fntBodyNormal = new Font(FontFactory.GetFont("Arial", 12, 0, Color.BLACK));
            Font fntBodyNormal11 = new Font(FontFactory.GetFont("Arial", 11, 0, Color.BLACK));
            Font fntBodyNormal10 = new Font(FontFactory.GetFont("Arial", 10, 0, Color.BLACK));

            #endregion

            #region encabezado Documento

            PdfPTable table = new PdfPTable(1);
           
            PdfPCell cell = new PdfPCell(new Phrase("CERTIFICATE OF QUALITY \n (CERTIFICADO DE CALIDAD)"));
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);
            document.Add(table);


            PdfPTable table_enc = new PdfPTable(4);
            float[] widths = new float[] { 4, 5, 3,4 };
            //actual width of table in points
            table_enc.TotalWidth = 500f;
            //fix the absolute width of the table
            table_enc.LockedWidth = true;

            table_enc.SetWidths(widths);
            //leave a gap before and after the table

            table_enc.SpacingBefore = 20f;
            table_enc.SpacingAfter = 30f;


            PdfPCell cell_customer = new PdfPCell(new Phrase("CUSTOMER "));
            cell_customer.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            cell_customer.BorderWidthRight = 0;
            PdfPCell cell_customer_2 = new PdfPCell(new Phrase(exportacionModel.Cliente));
            cell_customer_2.BorderWidthLeft = 0;

            table_enc.AddCell(cell_customer);
            table_enc.AddCell(cell_customer_2);

            table_enc.AddCell(new PdfPCell(new Phrase("CERTIFICATE (CERTIFICADO) \n\n\n  DATE (FECHA) ")) {HorizontalAlignment = PdfCell.ALIGN_LEFT });
            table_enc.AddCell(exportacionModel.NumeroCertificado + "\n\n\n\n" + DateTime.Now.ToString("yyyMMdd"));
            


            PdfPCell cell_PRODUCTO = new PdfPCell(new Phrase("PRODUCT: (PRODUCTO) "));
            cell_PRODUCTO.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            cell_PRODUCTO.BorderWidthRight = 0;
            PdfPCell cell_PRODUCTO_2 = new PdfPCell(new Phrase(exportacionModel.Producto));
            cell_PRODUCTO_2.BorderWidthLeft = 0;

            table_enc.AddCell(cell_PRODUCTO);
            table_enc.AddCell(cell_PRODUCTO_2);
            table_enc.AddCell(new PdfPCell(new Phrase("INVOICE No: (FACTURA)")) { HorizontalAlignment = PdfCell.ALIGN_LEFT });
            table_enc.AddCell(exportacionModel.NumeroFactura);



            PdfPCell cell_netweight = new PdfPCell(new Phrase("NET WEIGHT: (PESO-NETO) "));
            cell_netweight.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            cell_netweight.BorderWidthRight = 0;
            PdfPCell cell_netweight_2 = new PdfPCell(new Phrase(exportacionModel.PesoNeto.ToString()));
            cell_netweight_2.BorderWidthLeft = 0;

            table_enc.AddCell(cell_netweight);
            table_enc.AddCell(cell_netweight_2);
            table_enc.AddCell(new PdfPCell(new Phrase("SHIPPING MARKS: (MARCAS DE EMBALAJE)")) { HorizontalAlignment = PdfCell.ALIGN_LEFT });
            table_enc.AddCell(exportacionModel.MarcaEmbalaje);




            PdfPCell cell_grossweight = new PdfPCell(new Phrase("GROSS WEIGHT: (PESO-BRUTO) "));
            cell_grossweight.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            cell_grossweight.BorderWidthRight = 0;
            PdfPCell cell_grossweight_2  = new PdfPCell(new Phrase(exportacionModel.PesoBruto.ToString()));
            cell_grossweight_2.BorderWidthLeft = 0;

            table_enc.AddCell(cell_grossweight);
            table_enc.AddCell(cell_grossweight_2);
            table_enc.AddCell(new PdfPCell(new Phrase("PRESENTATIOS: (PRESENTACIÓN)")) { HorizontalAlignment = PdfCell.ALIGN_LEFT });
            table_enc.AddCell(exportacionModel.Presentacion);

            #region TABLA MELTS
            PdfPTable table_melts = new PdfPTable(exportacionModel.dtMelts.Columns.Count + 1)  //Se adiciona columna melts
            {
                TotalWidth = 500f,
                LockedWidth = true
            };


            PdfPCell cellTitulo = new PdfPCell(new Phrase("MELTS (lote)"));
            cellTitulo.HorizontalAlignment = PdfCell.ALIGN_LEFT;

            table_melts.AddCell(cellTitulo);
            // Adicon de valores de los lotes
            for (int j = 0; j < exportacionModel.dtMelts.Columns.Count; j++)
            {
                table_melts.AddCell(exportacionModel.dtMelts.Columns[j].ToString());
            }

            PdfPCell cellTitulo_2 = new PdfPCell(new Phrase("WEIGHT (kg)"));
            cellTitulo_2.HorizontalAlignment = PdfCell.ALIGN_LEFT;

            table_melts.AddCell(cellTitulo_2);

            for (int i = 0; i < exportacionModel.dtMelts.Rows.Count; i++)
            {
                for (int j = 0; j < exportacionModel.dtMelts.Columns.Count; j++)
                {
                    table_melts.AddCell(exportacionModel.dtMelts.Rows[i][j].ToString());
                }
            } 
            #endregion


            document.Add(table_enc);
            document.Add(table_melts);

            #endregion

            #region Detalle Documento


            #endregion

            #region Pie de pagina Documento
            #endregion

            document.Close();
            writer.Close();


            fs.Close();
            fs.Close();






        }

        /// <summary>
        /// Detecta las columnas que debe generar en la tabla 
        /// de acuerdo si el valor Min esta presente en alguna especificacion
        /// 
        /// </summary>
        /// <param name="dtblTable"></param>
        /// <returns></returns>
        private int ObtenerNumeroColumnasEspecificacion(DataTable dtblTable)
        {
            int NumeroCol = 4;

            foreach (DataRow item in dtblTable.Rows)
            {
                if (item["Min"].ToString().Trim().Length > 0)
                {
                    NumeroCol = 5;
                    break;
                }
            }

            return NumeroCol;
        }

        private static Paragraph addSpace(int size = 1)
        {

            Font LineBreak = FontFactory.GetFont("Arial", size);
            Paragraph paragraph = new Paragraph("\n\n", LineBreak);
            return paragraph;

        }




        public string GetFileName()
        {
            throw new NotImplementedException();
        }
    }
}
