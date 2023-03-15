using System;

internal class Program {
    private static void Main(string[] args) {
        while (true) {
            Console.Write("Qual o raio do circulo: ");
            float raio = float.Parse(Console.ReadLine());

            float raio2 = raio * raio;
            float A = (float)Math.PI * raio2;


            Console.Write("A = " + A);
            Console.WriteLine();
        }
    }
}