using System;
class Program{
    static void Main(){

        int pdias, cig, vida;

        Console.WriteLine("Digite quantos cigarros você fuma por dia:");
        pdias = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a quantos anos você fuma:");
        cig = Convert.ToInt32(Console.ReadLine());

        vida = (360*cig)+(pdias*10);

        Console.WriteLine("Você perdeu {0} dias da sua vida", vida);

    }
}