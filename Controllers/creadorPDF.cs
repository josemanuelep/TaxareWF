using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EN = Entities;

namespace Controllers
{
    public class creadorPDF
    {
        private Document doc;
        private PdfWriter writer;
        private string autor;
        private string ruta;
        private string titulo;

        public string getRuta() {

            return ruta + "" + titulo ;
        }

        public creadorPDF(string ruta, string autor, string titulo)
        {

            this.ruta = ruta;
            this.autor = autor;
            this.titulo = titulo;

        }

        public bool crearPDF(string encabezado, List<EN.Produccion> lista, Object clase, string funcion)
        {

            bool resultado = false;
            try
            {
                
                doc = new Document(PageSize.LETTER);
                writer = PdfWriter.GetInstance(doc, new FileStream(ruta + titulo+"-"+funcion + ".pdf", FileMode.Create));
                this.titulo = titulo + "-" + funcion + ".pdf";
                doc.AddTitle(titulo);
                doc.AddCreator(autor);
                doc.Open();
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Escribimos el encabezamiento en el documento
                var imagepath = @"F:\Logo.png";
                using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                {
                    var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    png.ScalePercent(20f);
                    png.SetAbsolutePosition(doc.Left, doc.Top-20);
                    doc.Add(png);
                }
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                doc.Add(spacer);

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
          
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };
                headerTable.HorizontalAlignment = 10;
                headerTable.AddCell("Fecha");
                headerTable.AddCell(DateTime.Now.ToString());
                headerTable.AddCell("Nombre del Administrador");
                headerTable.AddCell(this.autor);
                headerTable.AddCell("Proyecto");
                headerTable.AddCell("A1");
          
                doc.Add(headerTable);
                doc.Add(spacer);


                doc.Add(new Paragraph(encabezado));
                doc.Add(Chunk.NEWLINE);

                // Creamos una tabla que contendrá el nombre, apellido y país
                // de nuestros visitante.
                List<string> miembros = this.retornaAtributosClaseProduccion();
                PdfPTable tblPrueba = new PdfPTable(miembros.Count());
                tblPrueba.WidthPercentage = 100;

                int contador = 0;
                //Titulos de las celdas
                foreach (var item in miembros)
                {
                    // Configuramos el título de las columnas de la tabla
                    PdfPCell celda = new PdfPCell(new Phrase(item, _standardFont));
                    celda.BorderWidth = 0;
                    celda.BorderWidthBottom = 0.75f;
                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(celda);
                    contador++;

                }

                //Contenido
                foreach (var item in lista)
                {

                    tblPrueba.AddCell(item.id.ToString());
                    tblPrueba.AddCell(item.producido.ToString());
                    tblPrueba.AddCell(item.placa);
                    tblPrueba.AddCell(item.conductor);
                    tblPrueba.AddCell(item.dias.ToString());
                    tblPrueba.AddCell(item.inicio.ToShortDateString());
                    tblPrueba.AddCell(item.final.ToShortDateString());

                }

                doc.Add(tblPrueba);
                doc.Close();
                writer.Close();
                resultado = true;

                return resultado;
            }
            catch (Exception)
            {
    
                return resultado;
            }

        }

        public bool crearPDFGanancias(string encabezado, EN.GananciasNetas ganancias,string funcion)
        {

            bool resultado = false;
            try
            {

                doc = new Document(PageSize.LETTER);
                writer = PdfWriter.GetInstance(doc, new FileStream(ruta + titulo + "-" + funcion + ".pdf", FileMode.Create));
                this.titulo = titulo + "-" + funcion + ".pdf";
                doc.AddTitle(titulo);
                doc.AddCreator(autor);
                doc.Open();
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Escribimos el encabezamiento en el documento
                var imagepath = @"F:\Logo.png";
                using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                {
                    var png = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    png.ScalePercent(20f);
                    png.SetAbsolutePosition(doc.Left, doc.Top - 20);
                    doc.Add(png);
                }
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                doc.Add(spacer);

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {

                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };
                headerTable.HorizontalAlignment = 10;
                headerTable.AddCell("Fecha");
                headerTable.AddCell(DateTime.Now.ToString());
                headerTable.AddCell("Nombre del Administrador");
                headerTable.AddCell(this.autor);
                headerTable.AddCell("Proyecto");
                headerTable.AddCell("A1");

                doc.Add(headerTable);
                doc.Add(spacer);

                // Escribimos el encabezamiento en el documento
                doc.Add(new Paragraph(encabezado));
                doc.Add(Chunk.NEWLINE);

                // Creamos una tabla
                List<string> miembros = this.retornaAtributosClaseGanancias();
                PdfPTable tblPrueba = new PdfPTable(8);
                tblPrueba.WidthPercentage = 100;

               

                //Datos de las ganacias

                tblPrueba.AddCell("Placa");
                tblPrueba.AddCell("Inicio");
                tblPrueba.AddCell("Final");
                tblPrueba.AddCell("No. Producciones");
                tblPrueba.AddCell("No. Gastos");
                tblPrueba.AddCell("Total Gastos");
                tblPrueba.AddCell("Total Produccion");
                tblPrueba.AddCell("Neto");

                tblPrueba.AddCell(ganancias.placa);
                tblPrueba.AddCell(ganancias.inicio.ToShortDateString());
                tblPrueba.AddCell(ganancias.final.ToShortDateString());
                tblPrueba.AddCell(ganancias.listaProducciones.Count().ToString());
                tblPrueba.AddCell(ganancias.listaGastos.Count().ToString());
                tblPrueba.AddCell(ganancias.totalGastos.ToString());
                tblPrueba.AddCell(ganancias.totalProduccion.ToString());
                tblPrueba.AddCell(ganancias.neto.ToString());


                

                doc.Add(tblPrueba);
                doc.Close();
                writer.Close();
                resultado = true;

                return resultado;
            }
            catch (Exception)
            {

                return resultado;
            }

        }

        private List<string> retornaAtributosClaseProduccion()
        {

            List<string> retunrList = new List<string>();
            PropertyInfo[] properties = typeof(EN.Produccion).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                //así obtenemos el nombre del atributo
                string NombreAtributo = property.Name;
                retunrList.Add(NombreAtributo.ToUpper());
            }
            return retunrList;
        }

        private List<string> retornaAtributosClaseGanancias()
        {

            List<string> retunrList = new List<string>();
            PropertyInfo[] properties = typeof(EN.GananciasNetas).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                //así obtenemos el nombre del atributo
                string NombreAtributo = property.Name;
                retunrList.Add(NombreAtributo.ToUpper());
            }
            return retunrList;
        }
    }
}
