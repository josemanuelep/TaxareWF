using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class creadorPDF
    {
        private Document doc;
        private PdfWriter writer;

        public creadorPDF(string ruta, string autor, string titulo) {

            doc =  new Document(PageSize.LETTER);
            writer = PdfWriter.GetInstance(doc, new FileStream(@""+ruta, FileMode.Create));
            doc.AddTitle(titulo);
            doc.AddCreator(autor);
        }

        public void crearPDF(string encabezado, List elementos, Object clase) {
            doc.Open();
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph(encabezado));
            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblPrueba = new PdfPTable(3);
            tblPrueba.WidthPercentage = 100;

            List<string> miembros = this.retornaAtributosClase(clase);

            foreach (var item in miembros)
            {
                // Configuramos el título de las columnas de la tabla
                PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.75f;

                PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
                clApellido.BorderWidth = 0;
                clApellido.BorderWidthBottom = 0.75f;

                PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
                clPais.BorderWidth = 0;
                clPais.BorderWidthBottom = 0.75f;
            }

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
            clNombre.BorderWidth = 0;

            clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
            clApellido.BorderWidth = 0;

            clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
            clPais.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clPais);

            doc.Add(tblPrueba);
            doc.Close();
            writer.Close();

        }

        private List<string> retornaAtributosClase(Object clase) {

            List<string> miembrosClase = new List<string>();
            Type Datos = clase.GetType();

            Console.WriteLine("Los campos de la clase '" + Datos.Name + "', son:");
            foreach (FieldInfo F in Datos.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine("Nombre: '{0,-12}', Tipo: '{1,-10}'", F.Name, F.FieldType.Name);
                miembrosClase.Add(F.Name.ToUpper());
            }
            return miembrosClase;
        }

        
    }
}
