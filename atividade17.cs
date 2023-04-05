using System;
class Program{
    static void Main(){
        int km;

        Console.WriteLine("Digite a velocidade do carro:");
        km = Convert.ToInt32(Console.ReadLine());
        
        if(km>80){
            Console.WriteLine("Você tomou uma muta de {0}", (km-80)*5);
        }
    }
}