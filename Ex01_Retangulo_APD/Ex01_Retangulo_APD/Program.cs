using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Ex01_Retangulo_APD
{
	class Program
	{
		static void Main(string[] args)
		{
			Retangulo ret;

			ret = new Retangulo();
			
			Console.WriteLine("Entre com a largura e a altura do retângulo: ");

			Console.WriteLine();

			Console.Write("Largura: ");
			ret.largura = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
			Console.Write("Altura: ");
			ret.altura = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

			Console.WriteLine();

			Console.WriteLine("Area: " + ret.Area().ToString("F2" , CultureInfo.InvariantCulture));
			Console.WriteLine("Perimetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
			Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
