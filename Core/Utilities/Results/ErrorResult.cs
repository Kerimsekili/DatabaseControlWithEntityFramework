using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string messege) : base(false, messege)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
