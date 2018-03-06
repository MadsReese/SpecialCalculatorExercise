using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class AsyncLogger : ILogger
    {
        //private readonly BlockingCollection<LogMessage> _pendingMessages;
        private readonly Type _loggerFor;
        //private readonly IThreadAdapter _threadAdapter

        public void Critical(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
