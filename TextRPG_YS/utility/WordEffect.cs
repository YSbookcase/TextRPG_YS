using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS.utility
{
    public class WordEffect
    {

        public static void Print(string context = "문자열을 입력해 주세요.", ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Thread.Sleep(delay);
            Console.WriteLine(context);
            Console.ResetColor();


        }
    }
}
