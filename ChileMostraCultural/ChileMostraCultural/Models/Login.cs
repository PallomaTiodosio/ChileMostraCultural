using System.ComponentModel.DataAnnotations;

namespace ChileMostraCultural.Models
{
    public class Login
    {
        [Display(Name = "Código", Description = "Código.")]
        public int Id { get; set; }

        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome")]
        [Required(ErrorMessage ="O nome completo é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Nascimento")]
        [Required(ErrorMessage = "A data é obrigatório")]
        public DateTime Data { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O telefone é obrigatório.")]
        public int Telefone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "O Email não é valido.")]
        [RegularExpression(".+\\@.+\\..", ErrorMessage ="Informe o email válido")]
        public string Email{ get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "A senha é obrigatório.")]
        [StringLength(10,MinimumLength =6, ErrorMessage ="A senha deve ter entre 6 e 10 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessage = "A situação é obrigatória")]
        public string Situacao { get; set; }
    }
}
