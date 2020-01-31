using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCS_Royal_Assignment_Web.Logging
{
    /// <summary>
    /// Log class which is using log4net dll to write the logs
    /// </summary>
    /// 
    public class Log
    {
        private static readonly Log _instance = new Log();
        protected ILog monitoringLogger;
       

        private Log()
        {
            monitoringLogger = LogManager.GetLogger("MonitoringLogger");
        }

        public static void Info(string message)
        {
            _instance.monitoringLogger.Info(message);
        }

        public static void Error(string message)
        {
            _instance.monitoringLogger.Error(message);
        }
    }
}