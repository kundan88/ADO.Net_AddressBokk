﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetDatabaseCon
{
    public class Exceptions : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            ConnectionFailed
        }
        public Exceptions(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}


