using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TextRPG_YS.Scenes;
using TextRPG_YS.utility;

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
            if (!sceneDic.ContainsKey(sceneName))
            {
                Console.WriteLine($"씬 '{sceneName}'이 등록되지 않았습니다.");
                return;
            }

            curScene = sceneDic[sceneName];
            // 바로 출력하고 싶으면 여기에 실행 흐름 넣기
            // 그렇지 않으면 Run() 루프에서 반영됨
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

        public static void GoToTiltle(string goComment)
            {
            Console.Clear();
            Console.WriteLine();
            WordEffect.Print(goComment, ConsoleColor.Red, 0);
            Game.ChangeScene("TitleScene");
            
          


                
                }



        public static void GameOver(string gameoverCommet="")
        {
            Console.Clear();
            Console.WriteLine(gameoverCommet);

            gameOver = true;
        }


       


    }
}
