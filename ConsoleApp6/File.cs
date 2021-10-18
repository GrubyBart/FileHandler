using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp6
{
    public class File
    {
        public void Read()
        {
            var _streamReader = new StreamReader("C:\\a\\Sample.txt");
            String line;
            try
            {
                line = _streamReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = _streamReader.ReadLine();
                }
                _streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadLine(int lineNumber)
        {
            var _streamReader = new StreamReader("C:\\a\\Sample.txt");
            String line;
            int actualLine = 0;
            try
            {
                line = _streamReader.ReadLine();
                while (line != null)
                {
                    actualLine++;
                    if (actualLine == lineNumber)
                    {
                        Console.WriteLine(line);
                        break;
                    }
                    line = _streamReader.ReadLine();
                }
                _streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Write(string text)
        {
            var _streamWriter = new StreamWriter("C:\\a\\Sample.txt");
            try
            {
                _streamWriter.WriteLine(text);
                _streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}
