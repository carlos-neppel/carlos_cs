using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;


            Console.WriteLine("Hello Words");
            Console.WriteLine("a:" + a);
           
            if (Console.CapsLock)
                Console.WriteLine("CapsLock ativado");
            else
                Console.WriteLine("CapsLock desativado");

            Console.ReadKey();
           


        }
    }
}
