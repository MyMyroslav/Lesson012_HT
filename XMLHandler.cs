using System;
namespace Lesson012_HT
{
    public class XMLHandler : AbstractHandler
    {
        public XMLHandler()
        {
        }
        public override void Open()
        {
            Console.WriteLine("XML is opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML is created");
        }

        public override void Chenge()
        {
            Console.WriteLine("XML is changed");
        }

        public override void Save()
        {
            Console.WriteLine("XML is saved");
        }
    }
}
