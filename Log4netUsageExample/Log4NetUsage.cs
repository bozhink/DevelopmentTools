namespace Log4NetUsageExample
{
    using System;
    using log4net;
    using log4net.Config;

    /// <summary>
    /// This class is a small log4net usage sample.
    /// </summary>
    public static class Log4NetUsageSample
    {
        /// <summary>
        /// log4net logger instance.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Log4NetUsageSample));

        /// <summary>
        /// Entry point for the console application.
        /// </summary>
        public static void Main()
        {
            BasicConfigurator.Configure();
            Logger.Debug("Some debug information from log4net.");
            Logger.Error("Some error message from log4net.");
        }
    }
}
