using System;
using System.Runtime.Intrinsics.X86;

internal class Program {
    private static void Main(string[] args) {
        Console.Write("Escreva a variável a: ");
        double a = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Escreva a variável b: ");
        double b = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Escreva a variável c: ");
        double c = float.Parse(Console.ReadLine());
        Console.WriteLine();

        double delta = (b * b) - (4 * a * c);
        double X1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
        double X2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("X1 = " + X1);
        Console.WriteLine("X2 = " + X2);
    }
}