using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System;
using CourseCSharp.Entities;
using CourseCSharp.Entities.Exceptions;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"c:\temp\file1.txt";
            string targePath = @"c:\temp\file2.txt";
            try
            {
                string[] lines =  File.ReadAllLines(sourcePath);

                using(StreamWriter sr = File.AppendText(targePath))
                {
                    foreach(string line in lines)
                    {
                        sr.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine($"An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
