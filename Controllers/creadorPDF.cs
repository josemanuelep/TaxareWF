using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
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

        public creadorPDF(string ruta, string autor, string titulo)
        {

            this.ruta = ruta;
            this.autor = autor;
            this.titulo = titulo;

        }

        public void crearPDF(string encabezado, List<EN.Produccion> lista, Object clase)
        {

            doc = new Document(PageSize.LETTER);
            writer = PdfWriter.GetInstance(doc, new FileStream(ruta + "Probando.pdf", FileMode.Create));
            doc.AddTitle(titulo);
            doc.AddCreator(autor);
            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
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
            //foreach (var item in lista)
            //{
         
            //    tblPrueba.AddCell(item.conductor);
            //    tblPrueba.AddCell(item.dias.ToString());
            //    tblPrueba.AddCell(item.final.ToShortDateString());
            //    tblPrueba.AddCell(item.inicio.ToShortDateString());
            //    tblPrueba.AddCell(item.placa);
            //    tblPrueba.AddCell(item.producido.ToString());
            //}   

            doc.Add(tblPrueba);
            doc.Close();
            writer.Close();

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
    }
}
