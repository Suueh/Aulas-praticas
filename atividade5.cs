using System;

class Program{
    static void Main(){
       
        double nt1, nt2, media;

        Console.WriteLine("Digite a primeira nota:");
        nt1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota:");
        nt2 = Convert.ToDouble(Console.ReadLine());

        media = (nt1 + nt2)/2;
        
        Console.WriteLine("A media entre {0} e {1} é {2}", nt1, nt2, media);

    }
}