using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerImplemetation
{
    // nlog /nlog.config
    //storage of logger -> xml txt db .ro
    //storing in tis format -> dates - time - method message
    internal class Nlog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
        public void LogError(string message)
        {
            logger.Error(message);
        }
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
