using System;

namespace Lesson012_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IPlayable player1 = new Player();
            player1.Play();
            player1.Pause();
            player1.Stop();
            IRecodable rec1 = new Player();
            rec1.Record();
            rec1.Stop2();
            rec1.Pause2();
        }
    }
}
