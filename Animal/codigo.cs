using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  adj1 ; //declare as suas variaveis
        String  adj2 ;
        String  adj3 ;

        adj1 = Console.ReadLine(); //insira suas variaveis
        adj2 = Console.ReadLine();
        adj3 = Console.ReadLine();

    if (( adj1 == "vertebrado" ) && ( adj2 == "ave" )  && ( adj3 == "carnivoro")) {
      Console.WriteLine("aguia\n");
    }
     else if (( adj1 == "vertebrado" ) && ( adj2 == "ave" )  && ( adj3 == "onivoro" )) {
      Console.WriteLine("pomba\n"); }
      

    if (( adj1 == "vertebrado" ) && ( adj2 == "mamifero" )  && ( adj3 == "onivoro" )) {
      Console.WriteLine("homem\n");
    }
     else if (( adj1 == "vertebrado" ) && ( adj2 == "mamifero" )  && ( adj3 == "herbivoro" )) {
      Console.WriteLine("vaca\n"); }


    if (( adj1 == "invertebrado" ) && ( adj2 == "inseto" )  && ( adj3 == "hematofago" )) {
      Console.WriteLine("pulga\n");
    }
     else if (( adj1 == "invertebrado" ) && ( adj2 == "inseto" )  && ( adj3 == "herbivoro" )) {
      Console.WriteLine("lagarta\n"); }


    if (( adj1 == "invertebrado") && ( adj2 == "anelideo") && ( adj3 == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }
     else if (( adj1 == "invertebrado" ) && ( adj2 == "anelideo" )  && ( adj3 == "onivoro" )) {
      Console.WriteLine("minhoca\n"); }
  }
}