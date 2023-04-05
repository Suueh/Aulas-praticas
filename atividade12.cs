using System;

class Program{
    static void Main(){

        double valor;
        Console.WriteLine("Digite o valor do produto:");
        valor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O preço promocional é: {0}", valor /1.15);

    }
}