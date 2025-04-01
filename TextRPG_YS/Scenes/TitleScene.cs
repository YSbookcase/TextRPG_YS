using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS.Scenes
{
    public class TitleScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1.처음부터");
            Console.WriteLine("2.이어하기(미구현)");
            Console.WriteLine("3.게임종료");
        }

        public override void Next()
        {
            switch(input)
            {
                case ConsoleKey.D3:
                    Game.GameOver("게임을 종료합니다.");
                    break;

            }
        }

        public override void Render()
        {
            Console.WriteLine("############################");
            Console.WriteLine("#        YS의 모험         #");
            Console.WriteLine("############################");
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void wait()
        {
            Console.WriteLine("계속하려면 아무키나 입력하세요.");
            Console.ReadKey();
        }
    }
}
