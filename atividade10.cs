using System;

class Program{
    static void Main(){

        double l, a;

        Console.WriteLine("Digite a altura de sua parede:");
        l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a largura de sua parede:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Você vai precisar de {0} litros de tinta", l*a/2);
    }
}