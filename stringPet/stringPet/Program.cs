using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Unesite cijeli i decimalni broj odvojene razmakom: ");
            string unos = Console.ReadLine();

            
            string[] brojevi = unos.Split(' ');

            
            int x = int.Parse(brojevi[0]);        
            double y = double.Parse(brojevi[1]);  

            
            Console.WriteLine("Cijeli broj (x): " + x);
            Console.WriteLine("Decimalni broj (y): " + y);
        }
    }
}
