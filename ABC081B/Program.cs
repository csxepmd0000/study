using System;
namespace ABC081B{
    class Program{
        static void Main(string[] args)
        {
            //入力する数字の数を入れる。
            int a = int.Parse(Console.ReadLine());
            string[] StrInput = Console.ReadLine().Split(' ');
            //string 配列をint配列に変換。
            int[] IntInput = new int[StrInput.Length];

            for (int i = 0; i < IntInput.Length; i++){
                IntInput[i] = int.Parse(StrInput[i]);
            }
            //配列に偶数があるかどうかのフラッグ。割り算回数アカウントする変数。
            bool Evenflag = false;
            int ModCount = 0;
            while(!Evenflag)
            {
                for (int i = 0;i < a; i++)
                {
                    if(IntInput[i] % 2 == 1){
                        Evenflag = true;
                        break;
                        }
                    else{IntInput[i] = IntInput[i] / 2;}
                }
                if(!Evenflag){
                    ModCount += 1;
                }
            }
            Console.WriteLine(ModCount);
        }

    }
}