using Microsoft.EntityFrameworkCore;

namespace CrudCadastroAluno.Models
{
    public class Contexto : DbContext
    {
      public Contexto(DbContextOptions<Contexto>options) : base(options) 
        { }

        public DbSet<Cadastro> Cadastros { get; set; }
    }

    
}
