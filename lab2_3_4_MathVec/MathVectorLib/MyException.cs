using System;
using System.Collections.Generic;
using System.Text;

namespace MathVectorSpace
{
    public class Exception_Riker : Exception
    {
        public Exception_Riker() : base("Error MF!") { }
        public Exception_Riker(string message) : base(message) { }

    }

    public class IncorrectIndex_Riker : Exception_Riker
    {
        public IncorrectIndex_Riker() : base("Incorrect Index in []!") { }

    }

    public class DivideByZero_Riker : Exception_Riker
    {
        public DivideByZero_Riker() : base("U divide by zero!") { }

    }

    public class WrongVecSizes_Riker : Exception_Riker
    {
        public WrongVecSizes_Riker() : base("Vectors sizes is differnt!") { }
    }

    public class UncorrectValue_Riker : Exception_Riker
    {
        public UncorrectValue_Riker() : base("Uncorrect Value!") { }
    }

    class ErrorMF_Riker : Exception_Riker
    {
        public ErrorMF_Riker() : base() { }
    }
}
