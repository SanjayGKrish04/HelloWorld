using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace HellowWorld.LittleProjects
{
    public class ImageToPdfConvertor
    {
        public ImageToPdfConvertor()
        {
            ConvertImagesToPdf();
        }

        private void ConvertImagesToPdf()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;";
            openFileDialog.Title = "Select only jpg Images";
            openFileDialog.Multiselect = true;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK && openFileDialog.FileNames.Length > 0)
            {
                string[] imagePaths = openFileDialog.FileNames;
                string outputFolder = Path.GetDirectoryName(imagePaths[0]);
                string outputPdfPath = Path.Combine(outputFolder, $"CreatedImage.pdf");

                var pdfDoc = new PdfSharp.Pdf.PdfDocument();

                foreach (string imagePath in imagePaths)
                {
                    PdfPage page = pdfDoc.AddPage();
                    page.Size = PdfSharp.PageSize.A4;

                    using (XGraphics gfx = XGraphics.FromPdfPage(page))
                    using (XImage image = XImage.FromFile(imagePath))
                    {
                        double pageWidth = page.Width.Value;
                        double pageHeight = page.Height.Value;

                        double imgWidth = image.PixelWidth;
                        double imgHeight = image.PixelHeight;

                        double dpi = image.HorizontalResolution;
                        double imgWidthMm = imgWidth * 25.4 / dpi;
                        double imgHeightMm = imgHeight * 25.4 / dpi;

                        double scaleX = pageWidth / imgWidth;
                        double scaleY = pageHeight / imgHeight;
                        double scale = Math.Min(scaleX, scaleY);

                        double renderWidth = imgWidth * scale;
                        double renderHeight = imgHeight * scale;

                        double x = (pageWidth - renderWidth) / 2;
                        double y = (pageHeight - renderHeight) / 2;

                        gfx.DrawImage(image, x, y, renderWidth, renderHeight);
                    }
                }

                pdfDoc.Save(outputPdfPath);
                MessageBox.Show($"PDF saved successfully:\n{outputPdfPath}", "Done");
            }
            else
            {
                Console.WriteLine("No image selected.");
            }
        }
    }
}
