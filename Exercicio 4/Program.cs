using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            Console.WriteLine($"{retangulo}");

            Console.WriteLine("\nPressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
