/*
 * Copyright (c) 2012-2019 Snowflake Computing Inc. All rights reserved.
 */

namespace Snowflake.Data.Log
{
    class SFLoggerFactory
    {
        public static SFLogger GetLogger<T>()
        {
            return new Log4netImpl();
        }
    }
}
