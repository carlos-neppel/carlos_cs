using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Base;
using Modelos;

namespace Controllers
{
    class UsuariosController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();

        {
            
        public void Adicionar(Usuario entity)
            {
               
            }

            public void Atualizar(Usuario entity)
            {
                throw new NotImplementedException();
            }

            public Usuario BuscarPorID(int id)
            {
                throw new NotImplementedException();
            }

            public void Excluir(int id)
            {
                throw new NotImplementedException();
            }

            public IList<Usuario> ListarPorNome(string nome)
            {
               return contexto.Usuarios.Where(uint => u)
            }

            public IList<Usuario> ListarTodos()
            {
                throw new NotImplementedException();
            }
        }


    }
}
