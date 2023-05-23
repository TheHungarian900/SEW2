using System;
using System.IO;
namespace _230418_Ex24_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gyarm\OneDrive - Linzer Technikum\2AHIT\SEW\Stream_Test.txt";

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("This");
                    sw.WriteLine("is some text");
                    sw.WriteLine("to test");
                    sw.WriteLine("Reading");
                }

                using(StreamReader sr = new StreamReader(path))
                {
                    while(sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: " + e.ToString());
            }
        }
    }
}
