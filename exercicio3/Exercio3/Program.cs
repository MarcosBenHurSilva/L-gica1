using System;
using System.Globalization;
using System.Xml.Linq;
using System.Xml.Schema;

Console.Clear();
Console.WriteLine("\nMENU\n====\n");
Console.WriteLine("1 - Cachorro Quente - R$ 4,00");
Console.WriteLine("2 - X-Salada - R$ 4,50");
Console.WriteLine("3 - X-Bacon - R$ 5,00");
Console.WriteLine("4 - Torrada Simples - R$ 2,00");
Console.WriteLine("5 - Refrigerante - R$ 1,50");

Console.Write("Qual o código do seu pedido: ");
char opcao = Console.ReadKey().KeyChar;
Console.WriteLine();
Console.Write("Quantos pedidos: ");
double Quant = double.Parse(Console.ReadLine());

switch (opcao) {
    case '1':
        double Total = Quant * 4.00;
        Console.WriteLine(("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture)));
        break;
    case '2':
        Total = Quant * 4.50;
        Console.WriteLine(("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture)));
        break;
    case '3':
        Total = Quant * 5.00;
        Console.WriteLine(("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture)));
        break;
    case '4':
        Total = Quant * 2.00;
        Console.WriteLine(("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture)));
        break;
    case '5':
        Total = Quant * 1.00;
        Console.WriteLine(("Total: R$ " + Total.ToString("F2", CultureInfo.InvariantCulture)));
        break;
    default:
        Console.WriteLine("Pede direito!");
        break;  
}
