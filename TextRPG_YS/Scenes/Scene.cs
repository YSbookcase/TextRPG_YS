using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS.Scenes
{
    public abstract class Scene
    {
        protected ConsoleKey input;

        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }


        public abstract void Render();

        public abstract void Choice();

        public abstract void Result();


        public abstract void wait();

        public abstract void Next();



    }
}
