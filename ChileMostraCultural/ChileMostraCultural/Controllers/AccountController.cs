using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using ChileMostraCultural.Models;

namespace ChileMostraCultural.Controllers
{
	public class AccountController : Controller
	{
		private readonly IConfiguration _configuration;

		public AccountController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		private string ConnectionString =>
			_configuration.GetConnectionString("ConexaoMySQL")!;

		[HttpGet]
		public IActionResult Login()
		{
			return View(new LoginViewModel());
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Login(LoginViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			using var conexao = new MySqlConnection(ConnectionString);

			try
			{
				conexao.Open();

				const string sql = "SELECT Nome FROM tbLogin WHERE Email = @Email AND Senha = @Senha AND Situacao = 'A' LIMIT 1";

				using var comando = new MySqlCommand(sql, conexao);
				comando.Parameters.AddWithValue("@Email", model.Email);
				comando.Parameters.AddWithValue("@Senha", model.Senha);

				using var leitor = comando.ExecuteReader();

				if (!leitor.Read())
				{
					ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");
					return View(model);
				}

				var nome = leitor.GetString("Nome");

				HttpContext.Session.SetString("UsuarioNome", nome);
				HttpContext.Session.SetString("UsuarioEmail", model.Email);

				TempData["Mensagem"] = $"Bem-vindo(a) de volta, {nome}!";
				return RedirectToAction("Index", "Home");
			}
			catch (MySqlException ex)
			{
				ModelState.AddModelError(string.Empty, $"Erro de conexão: {ex.Message}");
				return View(model);
			}
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View(new RegisterViewModel());
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Register(RegisterViewModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			using var conexao = new MySqlConnection(ConnectionString);

			try
			{
				conexao.Open();

				// Verifica se o e-mail já existe
				const string sqlVerifica = "SELECT COUNT(*) FROM tbLogin WHERE Email = @Email";
				using (var comandoVerifica = new MySqlCommand(sqlVerifica, conexao))
				{
					comandoVerifica.Parameters.AddWithValue("@Email", model.Email);
					var existe = Convert.ToInt32(comandoVerifica.ExecuteScalar()) > 0;

					if (existe)
					{
						ModelState.AddModelError(nameof(model.Email), "Este e-mail já está cadastrado.");
						return View(model);
					}
				}

				// Insere o novo usuário
				const string sqlInsere = @"INSERT INTO tbLogin (Nome, DataNasc, Telefone, Email, Senha, ConfirmacaoSenha, Situacao)
                                            VALUES (@Nome, @DataNasc, @Telefone, @Email, @Senha, @ConfirmacaoSenha, 'A')";

				using var comandoInsere = new MySqlCommand(sqlInsere, conexao);
				comandoInsere.Parameters.AddWithValue("@Nome", model.NomeCompleto);
				comandoInsere.Parameters.AddWithValue("@DataNasc", model.DataNascimento);
				comandoInsere.Parameters.AddWithValue("@Telefone", model.Telefone);
				comandoInsere.Parameters.AddWithValue("@Email", model.Email);
				comandoInsere.Parameters.AddWithValue("@Senha", model.Senha);
				comandoInsere.Parameters.AddWithValue("@ConfirmacaoSenha", model.ConfirmarSenha);

				comandoInsere.ExecuteNonQuery();

				TempData["Mensagem"] = "Conta criada com sucesso! Faça login para continuar.";
				return RedirectToAction("Login");
			}
			catch (MySqlException ex)
			{
				ModelState.AddModelError(string.Empty, $"Erro de conexão: {ex.Message}");
				return View(model);
			}
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Index", "Home");
		}
	}
}