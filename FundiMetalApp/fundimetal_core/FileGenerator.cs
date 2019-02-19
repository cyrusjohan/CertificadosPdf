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
            this.RutaSalidaArchivosPDF =Path.Combine(RutaSalidaArchivos, String.Format(   FileNameMask,  
                                                                                                    DateTime.Now.ToString("yyyy"), 
                                                                                                    lote, 
                                                                                                    DateTime.Now.ToString("MMddHHmmss")) );
            this.Lote = lote;
            this.SetDataTemplate();
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
        public void ToMake(DataTable dtblTable)
        {

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

            Font fntHead = new Font(FontFactory.GetFont("Arial", 14, 3 , Color.BLACK));

        
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(this.Titulo, fntHead));
            document.Add(prgHeading);


            //Add line break
            document.Add(new Chunk("\n", fntHead));
           
            // Linea antes , ahora es parametrizable
            //document.Add(new Chunk("Le certificamos el contenido homogéneo de los elementos en un lote  de Metal súper Puro para Oxido de Baterías,  Marca  Fundimetales, de aprox. 10 tons como sigue ", fntBodyNormal));
            document.Add(new Chunk(this.HeaderText, fntBodyNormal));

            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));
          
            #endregion

            #region Detalle del documento

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count)
            {
                TotalWidth = 300f,
                LockedWidth = true
            };

            #region Lote 

            PdfPCell cellTitulo = new PdfPCell();
            cellTitulo.AddElement(new Phrase("Lote Identificado", fntBodyNormal11));            
            table.AddCell(cellTitulo);

            // Lote
            PdfPCell cellLote = new PdfPCell(new Phrase(this.Lote, fntBodyBold));
            cellLote.HorizontalAlignment = PdfCell.ALIGN_CENTER;           
            table.AddCell(cellLote);
            #endregion

            PdfPCell cellTitulo2 = new PdfPCell(new Phrase("", fntBodyNormal));
            cellTitulo2.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            table.AddCell(cellTitulo2);

            PdfPCell cellTitulo3 = new PdfPCell(new Phrase("Especificación", fntBodyNormal10));
            cellTitulo2.HorizontalAlignment = PdfCell.ALIGN_CENTER;
           // cellTitulo2.Colspan = 2;
            table.AddCell(cellTitulo3);          

             //Table header
             BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);


         
            // Titulo de la tabla 
            //String[] Arr_Titulos = new String[] { "Elemento", " ", "Analizado en %", "Permitidos Max %" };

            PdfPCell cellElemento = new PdfPCell(new Phrase("Elemento", fntBodyBold));
            cellElemento.HorizontalAlignment = PdfCell.ALIGN_CENTER;
            cellElemento.Colspan = 2;
            table.AddCell(cellElemento);

            PdfPCell cellAnalizado = new PdfPCell(new Phrase("Analizado en %", fntBodyBold));
            cellAnalizado.HorizontalAlignment = PdfCell.ALIGN_CENTER;            
            table.AddCell(cellAnalizado);

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
            document.Add(new Chunk( fechaDocumento, fntBodyNormal));

            //Saltos de linea
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
