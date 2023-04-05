using System;
class Program{
    static void Main(){

        double A, B, C;

        Console.WriteLine("Digite um valor pra A:");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite um valor pra B:");
        B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite um valor pra C:");
        C = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("O valor de Delta é: {0}", B*B - 4*A*C);
        

    }
}