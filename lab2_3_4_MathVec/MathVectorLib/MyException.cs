using System;
using System.Collections.Generic;
using System.Text;

namespace MathVectorSpace
{
    public class RikerException : Exception
    {
        public RikerException() : base("Error MF!") { }
        public RikerException(string message) : base(message) { }

    }

    public class RikerIncorrectIndex : RikerException
    {
        public RikerIncorrectIndex() : base("Incorrect Index in []!") { }

    }

    public class RikerDivideByZero : RikerException
    {
        public RikerDivideByZero() : base("U divide by zero!") { }

    }

    public class RikerWrongVecSizes : RikerException
    {
        public RikerWrongVecSizes() : base("Vectors sizes is differnt!") { }
    }

    public class RikerUncorrectValue : RikerException
    {
        public RikerUncorrectValue() : base("Uncorrect Value!") { }
    }

    public class RikerUnexpectedException : RikerException
    {
        public RikerUnexpectedException() : base() { }
    }
}
