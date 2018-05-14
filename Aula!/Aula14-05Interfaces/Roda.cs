using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_05Interfaces
{
    class Roda
    {

        public int RodaId { get; set; }

        public String Modelo { get; set; }

        public int  MarcaId { get; set; }

        public Marca _Marca { get; set; }
    }
}
