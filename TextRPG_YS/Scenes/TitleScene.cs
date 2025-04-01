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
            throw new NotImplementedException();
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override void Result()
        {
            throw new NotImplementedException();
        }

        public override void wait()
        {
            throw new NotImplementedException();
        }
    }
}
