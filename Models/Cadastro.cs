using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCadastroAluno.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("Id")]
        [Display(Name ="Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int Telefone { get; set; }
    }
}
