using System;
using System.Linq;

class Program {
  
    static void Main(string[] args) {
        int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
        int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
        int totalDeFigurinhas = 0;

        int[] albumDeFigurinha = new int[numeroDeFigurinhas];

        
            // IMPLEMENTE AQUI A SOLUÇÃO
        for (int i = 0; i < numeroDeFigurinhasCompradas; i++) {
            int figurinha = int.Parse(Console.ReadLine());
            if (!albumDeFigurinha.Contains(figurinha)) {
                albumDeFigurinha[i] = figurinha;
                numeroDeFigurinhas -= 1;
            }
            if (numeroDeFigurinhas == 0) {
                break;
            }
            }

        totalDeFigurinhas = numeroDeFigurinhas;

        Console.WriteLine(totalDeFigurinhas);
    }
}