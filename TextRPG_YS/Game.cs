using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TextRPG_YS.Scenes;

namespace TextRPG_YS
{
    public static class Game
    {

        private static bool gameOver;
        private static  Scene curScene;
        private static Dictionary<string, Scene> sceneDic;
        public static Player firstPlayer;
        
       


        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("TitleScene", new TitleScene());
            sceneDic.Add("HomeScene", new HomeScene());
            sceneDic.Add("HomeWindow", new HomeWindow());
            sceneDic.Add("HomeBackScene", new HomeBackScene());
            sceneDic.Add("OutsideScene", new OutsideScene());


            curScene = sceneDic["TitleScene"];
           


        }


        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];

        }



        public static void Run()
        {


            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                curScene.Result();
                Console.WriteLine();
                curScene.wait();
                curScene.Next();


            }


        }



        public static void GameOver(string gameoverCommet="")
        {
            Console.Clear();
            Console.WriteLine(gameoverCommet);

            gameOver = true;
        }


       


    }
}
