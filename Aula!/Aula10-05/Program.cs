using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_05
{
    class Program
    {
        static void Main(string[] args)

        {            Cliente clin = new Cliente();
            clin.Nome = "Godofredo"; //set
            string nomeClinte = clin.Nome;//get

            clin.Cpf = "12345678909";//set
            String cpfCliente = clin.Cpf;//get


            Console.WriteLine(clin.Nome);
            Console.WriteLine(clin.Cpf);
            Console.ReadKey();

            Cliente cli2 = new Cliente("jucicreia");
            Cliente cli3 = new Cliente("Juciliuda", "123");

        }
    }
}
