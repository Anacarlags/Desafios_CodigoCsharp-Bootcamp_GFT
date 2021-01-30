using System;
namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] entrada;
          var distancia = 0;
          var horas = 0;
          var viagem = 0;
          decimal gasolina = 0;

          entrada = (Console.ReadLine().Split(' '));
          horas = Convert.ToInt32(entrada[0]);
          distancia = Convert.ToInt32(entrada[1]);            
          viagem = (horas * distancia);
          gasolina = ((decimal)viagem / 12);
          Console.WriteLine(gasolina.ToString("N3"));
        }
    }
}