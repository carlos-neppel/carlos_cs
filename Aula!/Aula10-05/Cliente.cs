using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_05
{
    class Cliente : Pessoa
    {
        private DateTime dataNasc { get; set }

        public string dataQueNasceu
        {
            get
            {
                return dataNasc.ToShortDateString();
            }
        }


        public int MyProperty { get; set; }

        public Cliente()
        {
        }

       public Cliente (string nome) : base(nome)
        {

        }

        public Cliente (string nome, string cpf): base (nome, cpf)
        {

        }

    }     

}
