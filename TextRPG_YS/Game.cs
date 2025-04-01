using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TextRPG_YS.Scenes;

namespace TextRPG_YS
{
    public static class Game
    {

        private static bool gameOver;
        private static  Scene curScene;
        private static Dictionary<string, Scene> sceneDic;




        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("TitleScene", new TitleScene());
            sceneDic.Add("HomeScene", new HomeScene());

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


        // 뭘 클래스로 만들고 함수로 만들어야하나?
        //시작 및 초기화

        //랜더
        //put
        //update

        //끝


    }
}
