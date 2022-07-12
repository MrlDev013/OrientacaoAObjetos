using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex02_Salario_Imposto
{
	class Funcionario
	{
		public string nome;
		public double salarioBruto;
		public double imposto;
		public double porcentagem;

		public double SalarioLiquido()
		{
			return salarioBruto - imposto;
		}
		public void AumentarSalario(double porcentagem)
		{
			 salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.00);
		}
		public override string ToString()
		{
			return nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
