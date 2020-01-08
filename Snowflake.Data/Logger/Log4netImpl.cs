/*
 * Copyright (c) 2012-2019 Snowflake Computing Inc. All rights reserved.
 */

// using log4net;
// using System;

using System;

namespace Snowflake.Data.Log
{
    class Log4netImpl : SFLogger
    {
        public bool IsDebugEnabled() => false;

        public bool IsInfoEnabled() => false;

        public bool IsWarnEnabled() => false;

        public bool IsErrorEnabled() => false;

        public bool IsFatalEnabled() => false;

        public void Debug(string msg, Exception ex = null)
        {
            Console.WriteLine(msg);
            
            if (ex != null)
                Console.WriteLine(ex);
        }

        public void DebugFmt(string fmt, params object[] args)
        {
            Console.WriteLine(fmt, args);
        }

        public void Info(string msg, Exception ex = null)
        {
            Console.WriteLine(msg);
            
            if (ex != null)
                Console.WriteLine(ex);
        }

        public void InfoFmt(string fmt, params object[] args)
        {
            Console.WriteLine(fmt, args);
        }

        public void Warn(string msg, Exception ex = null)
        {
            Console.WriteLine(msg);
            
            if (ex != null)
                Console.WriteLine(ex);
        }

        public void WarnFmt(string fmt, params object[] args)
        {
            Console.WriteLine(fmt, args);
        }

        public void Error(string msg, Exception ex = null)
        {
            Console.WriteLine(msg);
            
            if (ex != null)
                Console.WriteLine(ex);
        }

        public void ErrorFmt(string fmt, params object[] args)
        {
            Console.WriteLine(fmt, args);
        }

        public void Fatal(string msg, Exception ex = null)
        {
            Console.WriteLine(msg);
            
            if (ex != null)
                Console.WriteLine(ex);
        }

        public void FatalFmt(string fmt, params object[] args)
        {
            Console.WriteLine(fmt, args);
        }
    }
}
