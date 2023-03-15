using System;

internal class Program {

    private static void Main(string[] args) {

        Console.Write("Qual o códido da primeira peça: ");
        int cod_1 = int.Parse(Console.ReadLine());       
        Console.Write("Digite o número de peças: ");
        float quant_1 = float.Parse(Console.ReadLine());
        Console.Write("Digite o número de peças: ");
        float val_1 = float.Parse(Console.ReadLine());
        Console.Write("Qual o códido da segunda peça: ");
        int cod_2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de peças: ");
        float quant_2 = float.Parse(Console.ReadLine());
        Console.Write("Digite o número de peças: ");
        float val_2 = float.Parse(Console.ReadLine());

        float soma_1 = val_1 * quant_1;
        float soma_2 = val_2 * quant_2;
        float SomaPecas = soma_1 + soma_2;


        Console.Write("VALOR A PAGAR: R$ " + SomaPecas);
    }
}