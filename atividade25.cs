using System;
class Program{
   public static void Main(){

        int seg1, seg2, seg3;

        Console.WriteLine("Digite o tamanho do segmento 1:");
        seg1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o tamanho do segmento 2:");
        seg2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o tamanho do segmento 3:");
        seg3 = Convert.ToInt32(Console.ReadLine());

        if(seg1 < seg2 + seg3 || seg2 < seg3 + seg1 || seg3 < seg1 + seg2){

            Console.WriteLine("É um triangulo!");

        }
        else{

            Console.WriteLine("Não é um triangulo");

        }
    }
}