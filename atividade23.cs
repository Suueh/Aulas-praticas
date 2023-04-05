using System;
class Program{
    static void Main(){

        char sexo;
        string nome;
        double compras;

        Console.WriteLine("Digite seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o seu sexo com M ou F:");
        sexo = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Digite o valor das suas compras:");
        compras = Convert.ToDouble(Console.ReadLine());

        if(sexo == 'f' || sexo == 'F' ){
            Console.WriteLine("Com desconto: {0:c}", compras/1.13);
        }
        if(sexo == 'm' || sexo == 'M' ){
            Console.WriteLine("Com desconto: {0:c}", compras/1.05);
        }
    }
}