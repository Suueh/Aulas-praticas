using System;

class Program{
    static void Main(){

        double num, dobro, terca;

        Console.WriteLine("Digite um numero:");
        num = Convert.ToDouble(Console.ReadLine());

        dobro = num * 2;
        terca = num /3;

        Console.WriteLine("O dobro de {0} é {1} \nA terça parte de {0} é {2}", num, dobro, terca);
        

    }
}