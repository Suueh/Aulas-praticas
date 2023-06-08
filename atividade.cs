using System;
class Program{
    static void Main(){
        int[] nums = new int [20];
        int[] pares = new int [20];
        int[] impares = new int [20];

        Console.WriteLine("Digite 20 numeros abaixo:");

        for(int n = 0;n<20;n++){
            nums[n] = Convert.ToInt32(Console.ReadLine());

            if(nums[n] % 2 == 0){
                pares[n] = nums[n];
            }
            else{
                impares[n] = nums[n];
            }
        }
        Console.Clear();
        Console.WriteLine("Esses numeros são impares:");
        for(int b = 0;b<20;b++){
            if(impares[b] == 0){
                    
                }
                else{
                    Console.WriteLine(impares[b]);
            }
        }
        Console.WriteLine("Esses numeros são pares:");
        for(int c = 0;c<20;c++){
            if(pares[c] == 0){
                    
            }
            else{
                Console.WriteLine(pares[c]);
            }
        }
    }
}
