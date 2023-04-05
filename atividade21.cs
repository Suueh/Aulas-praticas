using System;
class Program{
    static void Main(){
        
        int ano;

        Console.WriteLine("Digite um ano");
        ano = Convert.ToInt32(Console.ReadLine());

        if(ano % 2 == 0){

            Console.WriteLine("Ano Bissexto");

        }
        if(ano % 3 == 0){

            Console.WriteLine("O ano não é bissexto");

        }

    }
}