using System;

namespace Lesson012_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DOCHandler doc = new DOCHandler();
            doc.Open();
            doc.Create();
            doc.Chenge();
            doc.Save();
            Console.WriteLine(" ");
            XMLHandler xml = new XMLHandler();
            xml.Open();
            xml.Create();
            xml.Chenge();
            xml.Save();
            Console.WriteLine(" ");
            TXTHandler txt = new TXTHandler();
            txt.Open();
            txt.Create();
            txt.Chenge();
            txt.Save();
            Console.WriteLine(" ");
        }
    }
}
