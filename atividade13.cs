using System;

class Program{
    static void Main(){

        double  salario;

        Console.WriteLine("Digite o salario do funcionario:");
        salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("O salario com aumento:{0}", salario*1.15);
    }
}