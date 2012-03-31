using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linguist.Logger
{
    public interface ILogger
    {
        void LogError(string message);
        void LogDebug(string message);
        void LogInfo(string message);
    }
}
