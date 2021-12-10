using System;
using System.Globalization;

namespace Exercico.fixação.Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de computador";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produto:\n{produto1} cujo o preço é ${preco1}\n {produto2} cujo preço é ${preco2}" );
            Console.WriteLine();
            Console.WriteLine($"Registro:{idade} anos de idade, codígo {codigo}, genero é {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"{medida.ToString("F3")}");
            Console.WriteLine($"{medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
