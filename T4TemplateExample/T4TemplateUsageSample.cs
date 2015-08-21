namespace T4TemplateExample
{
    using System;
    using System.Xml;

    /// <summary>
    /// Sample for demonstration of T4 templates usage.
    /// </summary>
    public static class T4TemplateUsageSample
    {
        /// <summary>
        /// Start point for this application.
        /// </summary>
        public static void Main()
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
