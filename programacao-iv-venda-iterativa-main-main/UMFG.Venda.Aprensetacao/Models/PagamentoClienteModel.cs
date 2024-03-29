using System;
using System.ComponentModel.DataAnnotations;

namespace UMFG.Venda.Aprensetacao.Models
{
	public class PagamentoClienteModel
	{
		[Required(ErrorMessage = "O nome do cliente DEVE ser informado.")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O n�mero do cart�o DEVE ser informado.")]
		[CreditCard(ErrorMessage = "O n�mero do cart�o � inv�lido.")]
		public string NumeroCartao { get; set; }

		[Required(ErrorMessage = "A data de vencimento DEVE ser informada.")]
		[RegularExpression(@"^(0[1-9]|1[0-2])\/((20)\d{2})$", ErrorMessage = "Formato de data inv�lido. Use MM/yyyy.")]
		public string DataVencimento { get; set; }

		[Required(ErrorMessage = "O CVV DEVE ser infromado.")]
		[RegularExpression(@"^\d{3}$", ErrorMessage = "O CVV deve conter 3 d�gitos.")]
		public string CVV { get; set; }
	}
}
