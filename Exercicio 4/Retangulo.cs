using System;

namespace Exercicio_4
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double Area()
        {
            return Largura * Altura;    
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return "AREA: " +
                Area().ToString("F2") +
                "\nPERÍMETRO: " +
                Perimetro().ToString("F2") +
                "\nDIAGONAL: " +
                Diagonal().ToString("F2");
        }
    }
}
