using System;
class Program{
    static void Main(){
        
        int km, dias;

        Console.WriteLine("Digite quantos km foram pecorridos:");
        km = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite quantos dias você ficou com o carro:");
        dias = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Você vai precisar pagar {0:c}", (km*90)+(dias*0.20));
    }
}