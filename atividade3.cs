using System;

class Program{
    static void Main(){
        
        string nome;
        double salario;


        Console.WriteLine("Digite o nome do funcionario:");
        nome = Console.ReadLine();
        Console.WriteLine("Digite o salario do funcionario:");
        salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nome do funcionario:{0} \n Salario:{1:c}", nome, salario);


    }
}