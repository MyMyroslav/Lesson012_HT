using System;
namespace Lesson012_HT
{
    public class DOCHandler : AbstractHandler
    {
        public DOCHandler()
        {
        }
        public override void Open()
        {
            Console.WriteLine("DOC is opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC is created");
        }

        public override void Chenge()
        {
            Console.WriteLine("DOC is changed");
        }

        public override void Save()
        {
            Console.WriteLine("DOC is saved");
        }
    }
}
