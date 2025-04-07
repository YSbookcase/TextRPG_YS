using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_YS.utility;

namespace TextRPG_YS.Scenes
{
    public class HomeBackScene : Scene
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
                    Game.ChangeScene("OutsideScene");
                    break;
            }
        }

        public override void Render()
        {
            WordEffect.Print("다시 돌아왔다 무엇을 할까?", ConsoleColor.White, 1000);
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Item item = ItemDatabase.GetItemById(1);

                    if (Game.firstPlayer == null || item == null || !Game.firstPlayer.Inventory.HasItem(item.Id))
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
