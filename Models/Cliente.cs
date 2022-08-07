using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGabezk.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id;

        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo Nome é obrigatorio")]
        public string Nome { get; set; }

        [Column("Idade")]
        [Display(Name = "Idade")]
        [Required(ErrorMessage = "Campo Idade é obrigatorio")]
        public int Idade { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Campo Email é obrigatorio")]
        public string Email { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Senha é obrigatorio")]
        public string Senha { get; set; }

     
    }

}