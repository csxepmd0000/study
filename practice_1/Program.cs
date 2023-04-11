using System;
namespace practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            string[] B = Console.ReadLine().Split(' ');
            string X = Console.ReadLine();
            string intResult = Convert.ToString(A + int.Parse(B[0]) + int.Parse(B[1]));

            Console.WriteLine(intResult + ' ' + X);
        }
    }
}
