﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_05
{
    class Cliente
    {
        //Atributo
        private string nome;
        private string cpf;


        //Propriendade
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }


        public string Cpf { get; set; }


        //contrutor

        public Cliente() //contrutor vazio
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
            
        }

        public Cliente(string nome ; string cpf)
            {
                Nome = nome;
                 Cpf = cpf;
            }



    }
}