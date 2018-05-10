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
            Console.WriteLine("cli2.Nome:" + cli2.Nome);

            Cliente cli3 = new Cliente("Juciliuda", "123");
            cli3. = new DateTime(1950, 05, 05);
            Console.WriteLine(cli3.Nome + "nasceu em  " + cli3.DataNasc);

            //ERRO: classes abstratas nao podem ser instanciadas
            //Pessoa p = new Pessoa();

        }
    }
}
