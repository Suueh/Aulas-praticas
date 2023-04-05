using System;
class Program{
    static void Main(){

        double metros;

        Console.WriteLine("Digite uma distancia em metros");
        metros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("A distancia {0} em metros corresponde a:");

        Console.WriteLine("{0}km \n{1}hm \n{2}Dam \n{3}m \n{4}dm \n{5}cm \n{6}mm", metros/1000, metros/100, metros/10, metros, metros*10, metros*100, metros*1000);


    }
}