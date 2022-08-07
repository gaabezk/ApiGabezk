using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGabezk.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "C�digo")]
        public int Id;

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo Nome � obrigatorio")]
        public string Nome { get; set; }

        [Column("Idade")]
        [Display(Name = "Idade")]
        [Required(ErrorMessage = "Campo Idade � obrigatorio")]
        public int Idade { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Campo Email � obrigatorio")]
        public string Email { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Senha � obrigatorio")]
        public string Senha { get; set; }

     
    }

}