using System.Globalization;
using System;
using System.IO;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\file.csv";
            string targetPath = @"c:\temp\out\file2.csv";

           
            try{
                string[] lines = File.ReadAllLines(sourcePath);

                Directory.CreateDirectory(Path.GetDirectoryName(sourcePath) + @"\out");

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        string[] texts = line.Split(",");
                        string title = texts[0];
                        double price = double.Parse(texts[1], CultureInfo.InvariantCulture);
                        double quantity = double.Parse(texts[2], CultureInfo.InvariantCulture);
                        string result = title + "," + (price * quantity).ToString("F2", CultureInfo.InvariantCulture);
                        sw.WriteLine(result);
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine($"An erro as ocurred: {e.Message}");
            }

        }
    }
}
