using GastosFunc.Models;

namespace FuncTest
{
    public class SalarioTest
    {
        [Fact]
        public void TestarCalculo()
        {
            var f = new Funcionario()
            {
                SalarioBase = 1500,
                Desconto = 300,
                Beneficios = 50
            };

            Assert.Equal(1250, GastosFunc.Controllers.FuncionarioController.CalcularCustoFunc(f));
        }
    }
}