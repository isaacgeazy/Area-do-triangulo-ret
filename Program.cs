using System;

namespace TriangRet
{
    class Program
    {
        static void Main(string[] args)
        {
            string ent1, ent2;
            double h, b, area;

            Console.WriteLine();
            Console.Write("Digite a Base: ");
            ent1 = Console.ReadLine();
            Console.Write("Digite a Altura: ");
            ent2 = Console.ReadLine();

            h = Convert.ToDouble(ent1);
            b = Convert.ToDouble(ent2);

            area = (h * b) / 2;
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"A base é {b}");
            Console.WriteLine($"A altura é {h}");
            Console.WriteLine();
            Console.WriteLine($"O valor da área é {area}");


        }
    }
}
