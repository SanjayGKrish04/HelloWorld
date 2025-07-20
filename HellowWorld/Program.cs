using HellowWorld.LittleProjects;
using HellowWorld.RakeshProjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HellowWorld
{
    internal class Program
    {
        [STAThread]
        public static async Task Main(string[] args)
        {
            bool isYes = true;
            while (isYes)
            {
                Console.WriteLine("Choose the object to create:");
                List<string> menuOptions = new List<string>
                {
                    "Star Blink",
                    "Name Generator",
                    "Blink Print Name",
                    "Base64 Convertor",
                    "PDF to Image Convertor",
                    "Image to PDF Convertor",
                    "Internet Speed Test",
                    "Joke of the Day",
                    "Get Current Location",
                    "addition of two number",
                    "multiplication of two number"
                };

                for (int i = 0; i < menuOptions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuOptions[i]}");
                }
                Console.Write($"Enter your choice (1-{menuOptions.Count}): ");

                string choice = Console.ReadLine();
                int parsedChoice = 0;
                int.TryParse(choice, out parsedChoice);

                switch (parsedChoice)
                {
                    case 1:
                        Console.Write("Enter number of stars to blink: ");
                        int starCount;
                        int.TryParse(Console.ReadLine(), out starCount);
                        StarBlink starBlink = new StarBlink(starCount);
                        break;

                    case 2:
                        NameGenerator nameGenerator = new NameGenerator();
                        break;

                    case 3:
                        BlinkPrintName blinkPrintName = new BlinkPrintName();
                        break;

                    case 4:
                        Base64Convertor base64Convertor = new Base64Convertor();
                        break;

                    case 5:
                        PdfToImageConvertor pdfConverter = new PdfToImageConvertor();
                        break;

                    case 6:
                        ImageToPdfConvertor imageToPdf = new ImageToPdfConvertor();
                        break;

                    case 7:
                        InternetSpeedTester internetSpeedTester = new InternetSpeedTester();
                        break;

                    case 8:
                        JokeFetcher jokeFetcher = new JokeFetcher();
                        await jokeFetcher.FetchAndPrintJoke();
                        break;

                    case 9:
                        LocationFetcher locationFetcher = new LocationFetcher();
                        await locationFetcher.GetCurrentLocation();
                        break;

                    case 10:
                        Addition addition = new Addition();
                        break;
                    case 11:
                        Multiplication multiplication = new Multiplication();
                        break;
                    default:
                        Console.WriteLine($"Invalid choice. Please select within {menuOptions.Count}.");
                        break;
                }

                Console.WriteLine("Do you want to exit Y/N?");
                string yesno = Console.ReadLine();
                if (yesno.ToLower() == "y")
                {
                    isYes = false;
                    Console.Clear();
                    Console.WriteLine("Bye !!!! ");
                }
                Console.Clear();
            }
        }
    }
}
