using System;

namespace Exercicio_Classe_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1;
            r1 = new Retangulo();

            Console.WriteLine("Digite a altura do retângulo: ");
            r1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine());

            r1.Area();
            r1.Diagonal();
            r1.Perimetro();

            Console.WriteLine(r1);
        }
    }
}
