using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Linguist.Logger
{
    public class Log4NetLogger : ILogger
    {
        private readonly log4net.ILog logger;

        public Log4NetLogger()
        {
            //var frame = new StackFrame(1);
            //var type = frame.GetMethod().DeclaringType;
            logger = log4net.LogManager.GetLogger(this.GetType());
        }

        public void LogError(string message)
        {
            if (logger.IsErrorEnabled)
            {
                logger.Error(message);
            }
        }

        public void LogDebug(string message)
        {

            if (logger.IsDebugEnabled)
            {
                logger.Debug(message);
            }

        }

        public void LogInfo(string message)
        {
            if (logger.IsInfoEnabled)
            {
                logger.Info(message);
            }
        }
    }
}
