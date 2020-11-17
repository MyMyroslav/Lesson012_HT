using System;
namespace Lesson012_HT_Task2
{
    public class Player : IPlayable, IRecodable
    {
        public Player()
        {
        }
        public void Play()
        {
            Console.WriteLine("Start playing");
        }
        public void Pause()
        {
            Console.WriteLine("Pause playing");
        }
        public void Stop()
        {
            Console.WriteLine("Stop playing");
        }
        public void Record()
        {
            Console.WriteLine("Start recording");
        }
        public void Pause2()
        {
            Console.WriteLine("Pause recording");
        }
        public void Stop2()
        {
            Console.WriteLine("Stop recording");
        }
    }
}
