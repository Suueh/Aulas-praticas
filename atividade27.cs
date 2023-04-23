using System;
class Program{
    static void Main(){

        double nt1, nt2;

        Console.WriteLine("Digite a primeira nota:");
        nt1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        nt2 = Convert.ToDouble(Console.ReadLine());

        double media = (nt1 + nt2)/2;

        if(media >= 7){

            Console.WriteLine("Aprovado");

        }

        if(media < 7 && media >= 5){

            Console.WriteLine("Recuperação");

        }
        if(media < 5){

            Console.WriteLine("Reprovado");
        }

    }
}