using System.ComponentModel.DataAnnotations;

namespace ChileMostraCultural.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Informe seu nome completo.")]
		[StringLength(30, ErrorMessage = "Máximo de 30 caracteres.")]
		[Display(Name = "Nome completo")]
		public string NomeCompleto { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe sua data de nascimento.")]
		[DataType(DataType.Date)]
		[Display(Name = "Data de nascimento")]
		public DateTime DataNascimento { get; set; }

		[Required(ErrorMessage = "Informe seu e-mail.")]
		[EmailAddress(ErrorMessage = "E-mail inválido.")]
		[StringLength(50, ErrorMessage = "Máximo de 50 caracteres.")]
		[Display(Name = "E-mail")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe seu telefone.")]
		[Phone(ErrorMessage = "Telefone inválido.")]
		[StringLength(14, ErrorMessage = "Máximo de 14 caracteres.")]
		[Display(Name = "Telefone")]
		public string Telefone { get; set; } = string.Empty;

		[Required(ErrorMessage = "Crie uma senha.")]
		[StringLength(8, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 8 caracteres.")]
		[DataType(DataType.Password)]
		[Display(Name = "Senha")]
		public string Senha { get; set; } = string.Empty;

		[Required(ErrorMessage = "Confirme sua senha.")]
		[StringLength(8, ErrorMessage = "Máximo de 8 caracteres.")]
		[DataType(DataType.Password)]
		[Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
		[Display(Name = "Confirmar senha")]
		public string ConfirmarSenha { get; set; } = string.Empty;
	}
}