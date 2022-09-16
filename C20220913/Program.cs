using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C20220913
{
    internal class Program
    {
        private static void Read()
        {
            FileStream fs = new FileStream(@"..\..\kuldetesek.csv", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                List_Shuttle.Add(new Shuttle(sr.ReadLine().Split(';')));
            }
            sr.Close(); fs.Close();
        }

        static List<Shuttle> List_Shuttle = new List<Shuttle>();

        static void Main(string[] args)
        {
            Read();
            Console.ReadKey(true);
        }
    }
}
