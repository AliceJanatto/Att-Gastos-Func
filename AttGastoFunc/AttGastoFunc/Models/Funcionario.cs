using System.ComponentModel.DataAnnotations;

namespace GastosFunc.Models
{
    public class Funcionario
    {
        [StringLength(100, ErrorMessage = "Por favor, escreva seu nome limitando-se em 100 caracteres.")]
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Desconto { get; set; }
        public decimal Beneficios { get; set; }
    }
}
