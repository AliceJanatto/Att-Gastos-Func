using GastosFunc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GastosFunc.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                var custoFuncionario = CalcularCustoFunc(funcionario);
                ViewData["CustoFunc"] = custoFuncionario;
            }

            return View("Index", funcionario);
        }

        public static decimal CalcularCustoFunc(Funcionario funcionario)
        {
            return funcionario.SalarioBase + funcionario.Beneficios - funcionario.Desconto;
        }
    }
}
