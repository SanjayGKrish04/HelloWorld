using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using PdfiumViewer;

namespace HellowWorld.LittleProjects
{
    public class PdfToImageConvertor
    {
        public PdfToImageConvertor()
        {
            ConvertPdfToImages();
        }

        private void ConvertPdfToImages()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            openFileDialog.Title = "Select PDF File";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                string pdfPath = openFileDialog.FileName;
                string outputDirectory = Path.GetDirectoryName(pdfPath);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(pdfPath);
                string imageOutputFolder = Path.Combine(outputDirectory, fileNameWithoutExt);
                if (!Directory.Exists(imageOutputFolder))
                {
                    Directory.CreateDirectory(imageOutputFolder);
                }
                using (var document = PdfDocument.Load(pdfPath))
                {
                    int pageCount = document.PageCount;

                    for (int i = 0; i < pageCount; i++)
                    {
                        using (var image = document.Render(i, 300, 300, true))
                        {
                            string outputImagePath = Path.Combine(imageOutputFolder, $"{fileNameWithoutExt}{i + 1}.png");
                            image.Save(outputImagePath, ImageFormat.Png);
                        }
                    }

                    MessageBox.Show($"{pageCount} images saved successfully in:\n{imageOutputFolder}", "Conversion Complete");
                }
            }
            else
            {
                Console.WriteLine("No file selected or file not found.");
            }
        }
    }
}
