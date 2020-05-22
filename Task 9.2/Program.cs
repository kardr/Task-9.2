using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                StreamWriter sw = new StreamWriter("text2.txt");
                while (sr.EndOfStream != true)
                {
                    string s = sr.ReadLine();
                    string s2 = "";
                    for (int i = 1; i < s.Length; i += 2)
                    {
                        s2 += s[i];
                    }
                    sw.WriteLine(s2);
                }
                sr.Close();
                sw.Close();
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadKey();
        }
    }
}
