using System.Reflection.Metadata.Ecma335;

internal class Program {
    private static void Main(string[] args) {

        int senha_correta = 2002;
        int senha;

        do {
            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha != senha_correta) {
                Console.WriteLine("Senha Inválida");
            }

        } while (senha != senha_correta);

        Console.WriteLine("Acesso Permitido");
    }
}