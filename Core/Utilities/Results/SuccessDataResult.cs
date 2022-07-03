using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string messege):base(data,true,messege)
        {
            
        }

        public SuccessDataResult(T data):base(data,true)
        {
            
        }

        public SuccessDataResult(string messege):base(default,true,messege)
        {
            
        }

        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
