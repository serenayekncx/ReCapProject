using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult
    {
        public SuccessResult(string message) : base(false, message)
        {

        }
        public SuccessResult() : base(false)
        {


        }
    }
}
