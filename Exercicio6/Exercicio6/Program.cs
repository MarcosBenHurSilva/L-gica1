internal class Program {
    private static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine()); // Lê o valor de N

        int dentro = 0; // Variável para armazenar a quantidade de valores dentro do intervalo
        int fora = 0; // Variável para armazenar a quantidade de valores fora do intervalo

        for (int i = 0; i < n; i++) { // Loop para ler os valores de X
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20) { // Verifica se o valor de X está dentro do intervalo
                dentro++;
            }
            else {
                fora++;
            }
        }

        Console.WriteLine(dentro + " in"); // Imprime a quantidade de valores dentro do intervalo
        Console.WriteLine(fora + " out"); // Imprime a quantidade de valores fora do intervalo
    }
}