using System.Collections.Generic;
using System.IO;
using System;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try{
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    while(!sr.EndOfStream)
                    {

                        string[] usr = sr.ReadLine().Split(',');
                        string key = usr[0];
                        int value = int.Parse(usr[1]);

                        if(dictionary.ContainsKey(key))
                        {
                            dictionary[key] += value; 
                        }else
                        {
                            dictionary[key] = value;
                        }
                    }

                    
                    foreach(KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
