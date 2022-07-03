using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string messege) : base(data, false, messege)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string messege) : base(default, false, messege)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
