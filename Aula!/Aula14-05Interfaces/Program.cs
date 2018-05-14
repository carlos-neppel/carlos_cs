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
            Onibus onb = new Onibus();

            Console.WriteLine("Velocidade inicial" +  car.Velocidade);
            car.acelerar();
            car.acelerar();
            car.desacelerar();
            Console.WriteLine();
            Console.WriteLine("Velocidade inicial" +  car.Velocidade);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Velocidade inicila" + onb.Velocidade);
            onb.acelerar();
            onb.acelerar();
            onb.desacelerar();
            Console.WriteLine();
            Console.WriteLine("Velocidade inicila" + onb.Velocidade);

            AcelerarBastante(car);
            consoleWriteline car.ImprimirInfo();
            AcelerarBastante(onb);
            onb.ImprimirInfo


            Console.ReadKey();

            
        }
    }

    static void AcelerarBastante(IMeioTrasporte meioTrasporte)
    {
        for (int i = 0; i < 20; i ++)
        {
            meioTrasporte.acelerar();
        }
    }
}
