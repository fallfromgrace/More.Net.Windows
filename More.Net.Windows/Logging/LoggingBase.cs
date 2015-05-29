using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace EZMetrology.Logging
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class LoggerBase
    {
        protected LoggerBase(ILog logger)
        {
            this.logger = logger;
        }

        public ILog Logger
        {
            get { return logger; }
        }

        private readonly ILog logger;
    }
}
