using System;
namespace ABC087B
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            int Max = 500*A + 100*B + 50*C;
            int Count = 0;
            
            if(X > Max){
                Console.WriteLine(0);
            }
            else{
                for(int i = 0;i<=A;i++){
                    if(500*i>X){continue;}
                    for(int j =0;j<=B;j++){
                        if(500*i+100*j>X){continue;}
                        for(int k = 0;k<=C;k++){
                            if (500*i+100*j+50*k == X){Count +=1;}
                        }
                    }
                }
                Console.WriteLine(Count);
            }
        }
    }
}