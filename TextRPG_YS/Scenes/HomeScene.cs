using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_YS.utility;

namespace TextRPG_YS.Scenes
{
    class HomeScene : Scene
    {
        public override void Choice()
        {
            Console.WriteLine("1.먼저 창문을 살핀다.");
            Console.WriteLine("2.우선 스마트 폰을 챙긴다.");
            Console.WriteLine("3.천천히 문을 열어보기로 한다.");
        }

        public override void Next()
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
           
            WordEffect.Print("주말이 맞아 늦잠을 자고 일어났다. 생각했다.", ConsoleColor.White);
            WordEffect.Print("문득 깨달았을 때는 어둠이 까린 밤이였다.",ConsoleColor.White,3000);
            Console.WriteLine("키를 눌러 다음으로");
            Console.ReadKey(true);
            Console.WriteLine("평소보다 밖은 어두었고 숲속에 있는 느낌이다.");
            WordEffect.Print("방문 밖이 평소와는 다른 분위기다.", ConsoleColor.White, 3000);
            
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void wait()
        {
            Console.WriteLine("선택 후 진행하기 위해 아무키나 눌러주세요.");
            Console.ReadKey(true);

        }
    }
}
