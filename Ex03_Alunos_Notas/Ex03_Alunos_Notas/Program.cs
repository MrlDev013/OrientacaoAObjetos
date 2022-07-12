using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex03_Alunos_Notas
{
	class Program
	{
		static void Main(string[] args)
		{
			Aluno aluno = new Aluno();

			int controle = 0;

			Console.Write("Nome do aluno: ");
			aluno.nome = Console.ReadLine();

			Console.Write("Nota do primerio trimestre: ");
			aluno.nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Nota do segundo trimestre: ");
			aluno.nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Write("Nota do terceiro trimestre: ");
			aluno.nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2" , CultureInfo.InvariantCulture));

			if (aluno.Aprovado())
			{
				Console.WriteLine("Aprovado");
			}
			else
			{
				Console.WriteLine("Reprovado");
				Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("F2" , CultureInfo.InvariantCulture) + " pontos");
			}
		}
	}
}
