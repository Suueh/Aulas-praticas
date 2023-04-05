using System;

class Program{

    static void Main(){

        double valor;

        Console.WriteLine("Digite um valor:");
        valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Você tem {0} em dolar", valor/3.45);
        

    }

}