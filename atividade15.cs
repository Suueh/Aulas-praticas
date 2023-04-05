using System;
class Program{
    static void Main(){
        int dias;

        Console.WriteLine("Digite quantos dia você trabalhou:");
        dias = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Você vai receber {0:c}", dias*200);
    }
}