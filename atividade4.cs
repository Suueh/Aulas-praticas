using System;

class Program{
    static void Main(){

        int num, num2;

        Console.WriteLine("Digite um numero inteiro:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite um numero inteiro:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A soma entre {0} e {1} é igual a {2}", num, num2, num + num2);

    }
}