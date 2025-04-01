namespace TextRPG_YS

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game.Start();
            Game.Run();
            Game.GameOver("게임을 종료합니다.");

        }



    }
}
