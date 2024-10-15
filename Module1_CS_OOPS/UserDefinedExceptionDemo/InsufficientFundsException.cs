﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionDemo
{
    //1.define the exception class
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string errMsg) 
            :base(errMsg)
        {
            ErrorLogger.LogError(this);
        }
    }
}