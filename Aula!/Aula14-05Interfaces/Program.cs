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


   static  void CriarRelacionamentos()
    {
        Carro c = new Carro();
        c.Modelo = "Corsa";

        Marca m = new Marca();
        m.Nome = "Chevrolet";
        c._Marca = m;

        Onibus o = new Onibus();
        o.Modelo = "Chevrolet";
        o._Marca = m;
        


        //criando e armazemando rodas

        c.Rodas = new List<Roda>();
        Roda r1 = new Roda();
        

        Console.WriteLine("qtd rodas: " + c.Rodas.Count);

        for (int i =  0; i  <  3; i++)
        {
            c.Rodas.Add(r1);
        }

    }
}
