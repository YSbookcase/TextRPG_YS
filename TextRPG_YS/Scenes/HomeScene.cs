using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_YS.utility;
using TextRPG_YS;

namespace TextRPG_YS.Scenes
{
    public class HomeScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1.먼저 창문을 살핀다.");
            Console.WriteLine("2.(미구현)우선 스마트 폰을 챙긴다.");
            Console.WriteLine("3.천천히 문을 열어보기로 한다.");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("HomeWindow");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.WriteLine("천천히 문앞으로 이동해 문을 열었다.");
                    Game.ChangeScene("OutsideScene");
                    break;
            }
            
        }

        public override void Render()
        {
           
            WordEffect.Print("주말을 맞아.", ConsoleColor.White);
            WordEffect.Print("늦잠을 자고 일어났다.", ConsoleColor.White,1000);
            WordEffect.Print("문득 깨달았을 때는 어둠이 깔린 밤이였다.",ConsoleColor.White,2000);
            Console.WriteLine();
            WordEffect.Print("키를 눌러 다음으로", ConsoleColor.White, 2000); 
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("평소보다 밖은 어두었고 숲속에 있는 느낌이다.");
            WordEffect.Print("방문 밖이 평소와는 다른 분위기다.", ConsoleColor.White, 3000);
            WordEffect.Print("", ConsoleColor.White, 1000);
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Item item = ItemDatabase.GetItemById(1);

                    if (Game.firstPlayer != null && item != null && !Game.firstPlayer.Inventory.HasItem(item.Id))
                    {
                        Console.WriteLine("스마트폰을 챙겼다.");
                        Game.firstPlayer.Inventory.AddItem(item);
                    }
                    else
                    {
                        Console.WriteLine("이미 스마트폰을 가지고 있다.");
                    }
                    break;
            }
        }

        public override void wait()
        {
            Console.WriteLine();
            Console.WriteLine("선택 후 진행하기 위해 아무키나 눌러주세요.");
            Console.ReadKey(true);

        }
    }
}
