using EduLink.Entidades.Dtos;
using EduLink.Entidades.Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edulink.Windows.Helpers
{
    public static class ImprimirHelper
    {
        public static void CrearCertificadoAlumnoRegular(EstudianteDto estudianteDto, string nombreCarrera)
        {
            CrearCarpetaCertificados();
            var path = Environment.CurrentDirectory + @"\Certificados";
            var archivo = "CertificadoAlumnoRegular.pdf";
            var completo = Path.Combine(path, archivo);
            // Esto se modifica porque no me detecta la ruta por referencias
            string rutaHtml = "C:\\_PROGRAMACION_\\2º Año\\Seminario de Programación\\TP FINAL EduLink\\TPFinalEdulink\\Edulink.Windows\\Resources\\CertificadoAlumnoRegular.html";
            string htmlTemplate = File.ReadAllText(rutaHtml); // leer contenido

            string htmlFinal = htmlTemplate
                .Replace("@APELLIDOS", estudianteDto.Apellidos)
                .Replace("@NOMBRES", estudianteDto.Nombres)
                .Replace("@DNI", estudianteDto.DNI.ToString())
                .Replace("@CARRERA", nombreCarrera)
                .Replace("@FECHA", DateTime.Today.ToShortDateString());

            GuardarPdfImagen(completo, htmlFinal);
        }

        private static void GuardarPdfImagen(string completo, string PaginaHTML_Texto)
        {
            using (FileStream stream = new FileStream(completo, FileMode.Create))
            {
                //Creamos un nuevo documento y lo definimos como PDF
                Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                //Agregamos la imagen del banner al documento
                //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop,
                //	System.Drawing.Imaging.ImageFormat.Png);
                //img.ScaleToFit(60, 60);
                //img.Alignment = iTextSharp.text.Image.UNDERLYING;

                ////img.SetAbsolutePosition(10,100);
                //img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                //pdfDoc.Add(img);


                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
                Process.Start($"{completo}"); //Muestra el reporte
            }
        }


        private static void CrearCarpetaCertificados()
        {
            var path = Environment.CurrentDirectory;
            var carpeta = "Certificados";
            var completo = Path.Combine(path, carpeta);
            if (!Directory.Exists(completo))
            {
                Directory.CreateDirectory(completo);
            }
        }

        internal static void CertificadoIncripcionMaterias(Estudiante estudiante)
        {
        //    CrearCarpetaCertificados();
        //    var path = Environment.CurrentDirectory + @"\Certificados";
        //    var archivo = "CertificadoInscripcionMaterias.pdf";
        //    var completo = Path.Combine(path, archivo);
        //    // Esto se modifica porque no me detecta la ruta por referencias
        //    string rutaHtml = "C:\\_PROGRAMACION_\\2º Año\\Seminario de Programación\\TP FINAL EduLink\\TPFinalEdulink\\Edulink.Windows\\Resources\\CertificadoInscripcionMaterias.html";
        //    string htmlTemplate = File.ReadAllText(rutaHtml); // leer contenido

        //    string htmlFinal = htmlTemplate
        //        .Replace("@APELLIDOS", estudianteDto.Apellidos)
        //        .Replace("@NOMBRES", estudianteDto.Nombres)
        //        .Replace("@DNI", estudianteDto.DNI.ToString())
        //        .Replace("@CARRERA", nombreCarrera)
        //        .Replace("@FECHA", DateTime.Today.ToShortDateString());

        //    GuardarPdfImagen(completo, htmlFinal);
        }
    }
}


