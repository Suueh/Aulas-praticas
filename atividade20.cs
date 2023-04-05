using System;
class Program{
    static void Main(){

        int num;
        Console.WriteLine("Digite um numero:");
        num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0){

            Console.WriteLine("O numero {0} é par", num);

        }
        if(num % 3 == 0){
            Console.WriteLine("O numero {0} é impar", num);
        }

    }
}