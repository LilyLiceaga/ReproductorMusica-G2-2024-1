using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace ReproductorMusica_G2_2024_1
{
    public partial class FormTopTen : Form //PARA GRÁFICO PIE
    {
        public FormTopTen()
        {
            InitializeComponent();
        }

        private void guardarGráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CONFIGURACIÓN DE IMPRESIÓN DE DOCUMENTO
            Document docPDF = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35); //(tamaño de hoja, margen1, margen2, margen3, margen4)
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.pdf | .pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PdfWriter pdfWriter = PdfWriter.GetInstance(docPDF, new FileStream(sfd.FileName, FileMode.Append)); //se abre para agragar datos (?)
                    docPDF.Open(); // se abre el docmento
                    MemoryStream imagenStream = new MemoryStream();//se guarda el documento 
                                                                   //conviene más usar MemoryStream y no FileStream por que deja guardar cosas más grandes (se necesita porque es una imagen)

                    chartTop.SaveImage(imagenStream, ChartImageFormat.Png);
                    iTextSharp.text.Image GrafPdf = iTextSharp.text.Image.GetInstance(imagenStream.GetBuffer());
                    docPDF.Add(GrafPdf);
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
                finally
                {
                    docPDF.Close();
                }
            }
        }

        private void topTenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
