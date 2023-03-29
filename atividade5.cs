using System;

class Program{
    static void Main(){
        int num;

        Console.WriteLine("Digite um numero:");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O antecessor de {0} é {1} \n O sucessor de {0} é {2}", num, num-1, num+1);

    }
}