using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_05Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();

            Console.WriteLine("Velocidade inicial" + car.Velocidade);
            car.acelerar();
            car.acelerar();
            Console.WriteLine("Velocidade inicial" + car.Velocidade);
            Console.ReadKey();

            
        }
    }
}
