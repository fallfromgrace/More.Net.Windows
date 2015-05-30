using log4net.Appender;
using log4net.Core;
using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace More.Net.EZStudio.Logging
{
    /// <summary>
    /// 
    /// </summary>
    public class ObservableMemoryAppender : MemoryAppender
    {
        /// <summary>
        /// 
        /// </summary>
        public IObservable<LoggingEvent> WhenEventLogged
        {
            get { return loggingEventSubject.AsObservable(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public ObservableMemoryAppender() : 
            base()
        {
            loggingEventSubject = new Subject<LoggingEvent>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loggingEvent"></param>
        protected override void Append(LoggingEvent loggingEvent)
        {
            base.Append(loggingEvent);
            loggingEventSubject.OnNext(loggingEvent);
        }

        private readonly ISubject<LoggingEvent> loggingEventSubject;
    }
}
