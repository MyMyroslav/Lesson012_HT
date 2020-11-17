using System;
namespace Lesson012_HT
{
    public class TXTHandler : AbstractHandler
    {
        public TXTHandler()
        {
        }
        public override void Open()
        {
            Console.WriteLine("TXT is opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT is created");
        }

        public override void Chenge()
        {
            Console.WriteLine("TXT is changed");
        }

        public override void Save()
        {
            Console.WriteLine("TXT is saved");
        }
    }
}
