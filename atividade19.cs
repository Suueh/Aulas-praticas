using System;
class Program{
    static void Main(){

        double nt1, nt2, media;
        string nome;

        Console.WriteLine("Digite o nome do aluno:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a primeira nota do aluno:");
        nt1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno:");
        nt2 = Convert.ToDouble(Console.ReadLine());

        media = (nt1+nt2)/2;

        if(media>7){
            Console.WriteLine("O aluno {0} teve um bom aproveitamento \nNota {1}", nome, media);
        }
        else{
            Console.WriteLine("O aluno {0} não teve um bom aproveitamento \nNota {1}", nome, media);
        }
    }
}