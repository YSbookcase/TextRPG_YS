using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_YS.utility;

namespace TextRPG_YS.Scenes
{
    class HomeWindow : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1.다시 침대 쪽으로 돌아간다.");
            Console.WriteLine("2.창문을 열어본다.");
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            Console.WriteLine("이상하게도 불빛이 없는 한치 앞도 보이지 않는 어둠이다.");
            WordEffect.Print("내가 알고 있는 장소가 아닌것 같다.", ConsoleColor.Red, 5000);

        }

        public override void Result()
        {
            switch(input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Homescene");
                    break;

                case ConsoleKey.D2:
                    Game.GameOver("갑작스러운 어둠이 덥쳤다. 순간의 정적지 찾아온다.");
                    break;

            }
        }

        public override void wait()
        {
            throw new NotImplementedException();
        }
    }
}
