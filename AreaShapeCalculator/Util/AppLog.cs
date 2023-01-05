using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapeCalculator.Util
{
    public static class AppLog<T>
    {
        public static readonly ILog Logger = LogManager.GetLogger(typeof(T));
        public static void Log(string message)
        {
            Logger.Debug(message);
        }

        public static void Error(string message)
        {
            Logger.Error(message);
        }
    }
}
