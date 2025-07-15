using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HellowWorld.LittleProjects
{
    public class Base64Convertor
    {
        public Base64Convertor()
        {
            Console.WriteLine("Please select a .txt file to convert to Base64...");

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt";
            fileDialog.Title = "Select a Text File";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = fileDialog.FileName;
                string base64String = ConvertFileToBase64(selectedFilePath);
                SaveBase64ToFile(base64String, selectedFilePath);
            }
            else
            {
                Console.WriteLine("No file selected. Program exiting.");
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
        public static string ConvertFileToBase64(string filePath)
        {
            string content = File.ReadAllText(filePath);
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            string base64String = Convert.ToBase64String(bytes);
            return base64String;
        }

        public static void SaveBase64ToFile(string base64String, string originalFileName)
        {
            string directory = Path.GetDirectoryName(originalFileName);
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFileName);
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string outputFileName = $"{fileNameWithoutExt}_base64_{timestamp}.txt";
            string outputPath = Path.Combine(directory, outputFileName);

            File.WriteAllText(outputPath, base64String);
            Console.WriteLine($"Base64 output saved to: {outputPath}");
        }
    }
}
