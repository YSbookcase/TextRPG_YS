using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_YS.utility;

namespace TextRPG_YS.Scenes
{
    public class OutsideScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1. 불빛을 따라 길을 나아간다.");
            Console.WriteLine("2. 다시 집으로 돌아간다.");
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Game.ChangeScene("HomeBackScene");
                    break;

            }
        }

        public override void Render()
        { WordEffect.Print("주변은 어둠이다.", ConsoleColor.White, 1000);
            WordEffect.Print("멀리 불빛이 보인다. 길을 따라갈까?");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Game.ChangeScene("HomeBackScene");
                    break;
                
            }
        }

        public override void wait()
        {
            
        }
    }
}
