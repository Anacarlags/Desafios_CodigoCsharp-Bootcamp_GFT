using System;

class Program {
  
  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];
    int[] Repetidas = new int[numeroDeFigurinhas];

    // IMPLEMENTE AQUI A SOLUÇÃO

    for(int i=0; i < numeroDeFigurinhas; i++)
      Repetidas[i] = 0;
    for (int j=0; j < numeroDeFigurinhasCompradas; j++)
        {
            albumDeFigurinha[i] = Int32.Parse(Console.ReadLine());
        }
    

    var contadorDeFigurinhas = 0;
    var albumPreenchido = 0;
    for (int k = 0; k < numeroDeFigurinhas; k++)
    {
        for (int l = 0; l < albumDeFigurinha.Length; l++)
        {
            if (l == albumDeFigurinha[l]-1)
            {
              Repetidas[k] = 1;
            }
        }
        if(Repetidas[k] == 1)
          totalDeFigurinhas++;   
    }

    Console.WriteLine(numeroDeFigurinhas - totalDeFigurinhas);

  }

}
