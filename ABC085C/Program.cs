
using System;

namespace ABC085C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            bool isOutput = false;
            int a =-1;
            int b =-1;
            int c =-1;
                for(int i = 0;i<=N;i++){
                    // if(10000*i>Y){continue;}
                    for(int j =0;j<=N-i;j++){
                        // if(10000*i+5000*j>Y){continue;}
                            if (9000*i+4000*j+1000*N==Y){
                                a = i;
                                b = j;
                                c = 9-i-j;
                                isOutput =true;
                                break;}
                    }
                    if(isOutput){break;}
                }
                Console.WriteLine($"{a} {b} {c}");

            // if (!isOutput){Console.WriteLine("-1 -1 -1");}
            
        }
    }
}
