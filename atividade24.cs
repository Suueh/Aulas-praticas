using System;
class Program{
    static void Main(){

        int dista;

        Console.WriteLine("Digite a distancia que deseja percorrer:");
        dista = Convert.ToInt32(Console.ReadLine());

        if(dista>= 200){

            Console.WriteLine("O valor da passagem fica{0:c}", 0.45*dista);

        }
        else{
            
            Console.WriteLine("O valor da passagem fica{0:c}", 0.50*dista);
        }


    }
}