﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NoStudentSelectedException : ApplicationException
    {
        public NoStudentSelectedException(string excMessage):base(excMessage)
        { }
    }
}
