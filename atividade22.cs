using System;
class Program{
    static void Main(){

        int idade;

        Console.WriteLine("Digite quantos anos você tem:");
        idade = Convert.ToInt32(Console.ReadLine());

        if(idade >= 18){
            Console.WriteLine("Você se alistou a {0} anos", idade - 18);
        }
        else{
            Console.WriteLine("Você vai se alistar em {0} anos", 18 - idade);
        }


    }
}