using System;
using log4net;
using log4net.Config;

namespace Log4NetUsageExample
{
    public class Log4NetUsageSample
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Log4NetUsageSample));

        public static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            logger.Debug("Some debug information from log4net.");
            logger.Error("Some error message from log4net.");
        }
    }
}
