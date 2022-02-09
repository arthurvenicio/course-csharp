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
            

            Console.WriteLine(Path.GetDirectoryName(sourcePath));
            Console.WriteLine(Path.GetFileName(sourcePath));
            Console.WriteLine(Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetTempPath());

        }
    }
}
