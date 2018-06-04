using System.Data.Entity;
using Modelos

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base ("strconn")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Atividade> Atividades { get; set; }
        public object atividades { get; internal set; }
        public DbSet<Categoria> Categorias { get; set; }

    }
}
