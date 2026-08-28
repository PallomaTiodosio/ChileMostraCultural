using System.ComponentModel.DataAnnotations;

namespace ChileMostraCultural.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Informe seu e-mail.")]
		[EmailAddress(ErrorMessage = "E-mail inválido.")]
		[Display(Name = "E-mail")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Informe sua senha.")]
		[StringLength(8, ErrorMessage = "Máximo de 8 caracteres.")]
		[DataType(DataType.Password)]
		[Display(Name = "Senha")]
		public string Senha { get; set; } = string.Empty;
	}
}