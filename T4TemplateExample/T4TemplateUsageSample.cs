using System;
using System.Xml;

namespace T4TemplateExample
{
    class T4TemplateUsageSample
    {
        static void Main(string[] args)
        {
            ClassWitItemProperties classWithItems = new ClassWitItemProperties();
            classWithItems.Item4 = 10;
            Console.WriteLine(classWithItems.Item4);

            Console.WriteLine();

            XmlDocument projectXml = new XmlDocument();
            projectXml.PreserveWhitespace = true;
            projectXml.Load("ProjectXml.xml");
            Console.WriteLine(projectXml.OuterXml);
        }
    }
}
