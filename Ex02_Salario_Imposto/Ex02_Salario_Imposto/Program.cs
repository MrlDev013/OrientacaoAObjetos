using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex02_Salario_Imposto
{
	class Program
	{
		static void Main(string[] args)
		{
			Funcionario funcionario = new Funcionario();

			Console.Write("Nome: ");
			funcionario.nome = Console.ReadLine();
			Console.Write("Salário Bruto: ");
			funcionario.salarioBruto = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
			Console.Write("Imposto: ");
			funcionario.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("Funcionário: " + funcionario.nome + ", " + "$" + funcionario.SalarioLiquido().ToString("F2") , CultureInfo.InvariantCulture);

			Console.Write("Digite a porcentagem para aumentar o salário: ");
			double porcent = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
			funcionario.AumentarSalario(porcent);

			Console.WriteLine();

			Console.WriteLine("Dados atualizados: " + funcionario);
		}
	}
}
