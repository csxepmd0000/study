using System;

namespace ABC081A
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int OneCount = 0;
            foreach (char word in input){
                if (word == '1')
                {
                    OneCount += 1;
                }
            }
            Console.WriteLine(OneCount);
        }
    }
}