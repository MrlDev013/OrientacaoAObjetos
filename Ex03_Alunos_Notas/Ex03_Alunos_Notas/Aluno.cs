using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex03_Alunos_Notas
{
	class Aluno
	{
		public string nome;
		public double nota01;
		public double nota02;
		public double nota03;

		public double NotaFinal()
		{
			return nota01 + nota02 + nota03;
		}
		public bool Aprovado()
		{
			if (NotaFinal() >= 60)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public double NotaRestante()
		{
			if (Aprovado())
			{
				return 0.0;
			}
			else
			{
				return 60.0 - NotaFinal();
			}
		}
	}
}
