using System.ComponentModel.DataAnnotations;

namespace ChileMostraCultural.Models
{
    public class Trabalhador
    {
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome.")]
        [Required(ErrorMessage = "o nome completo é obrigatorio")]
        public string Nome { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessage = "o celular é obrigatorio")]
        public string Telefone { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "o CPF é obrigatorio")]
        public string CPF { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "O Email nao é valido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um Email valido...")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A Senha é obrigatoria")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = " A Senha deve ter entre 6 e 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "o Tipo é obrigatorio")]
        public string Tipo { get; set; }
    }
}
