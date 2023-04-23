using System;
class Program{
    static void Main(){
        int vl1, vl2;

        Console.WriteLine("Digite um numero:");
        vl1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Outro numero:");
        vl2 = Convert.ToInt32(Console.ReadLine());

        if(vl1 > vl2){

            Console.WriteLine("O primeiro valor é maior");

        }
        else{
            //DUVIDA:Ta sempre quebrando no primeiro if enquanto no segundo ta seguindo de boa.
            //Quando o primeiro if é verdadeiro ele imprimi o que deve mprimir, mas tambem imprimi o else.

            Console.WriteLine("Os dois são iguais");

        }
        if(vl2 > vl1){

            Console.WriteLine("O segundo valor é maior");

        }
        else{

            Console.WriteLine("Os dois são iguais");

        }
        
    }
}