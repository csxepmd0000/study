
// 問題文
// 高橋君はデータの加工が行いたいです。

// 整数 
// a,b,cと、文字列 
// s が与えられます。 
// a+b+c の計算結果と、文字列 
// s を並べて表示しなさい。

// 制約
// 1≤a,b,c≤1,000
// 1≤∣s∣≤100
using System;

namespace PracticeA
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数の入力
            int a = int.Parse(Console.ReadLine());
            // スペース区切りの整数の入力
            string[] input = Console.ReadLine().Split(' ');
            int b = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            // 文字列の入力
            string s = Console.ReadLine();
            //出力
            Console.WriteLine((a + b + c) + " " + s);
        }
    }
}
