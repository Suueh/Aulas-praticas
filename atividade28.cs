using System;
class Program{
    static void Main(){
        double comp, larg, area;

        Console.WriteLine("Digite a largura do terreno:");
        larg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o comprimento do terreno:");
        comp = Convert.ToDouble(Console.ReadLine());

        area = larg * comp;

        if(area < 100){

            Console.WriteLine("Terreno popular");
        }
        if(area > 100 && area <= 500){

            Console.WriteLine("Terreno Master");
        }
        if(area > 500){

            Console.WriteLine("Terreno Vip");
        }
    }
}