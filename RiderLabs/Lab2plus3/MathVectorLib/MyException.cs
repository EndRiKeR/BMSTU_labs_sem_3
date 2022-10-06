using System;
using System.Collections.Generic;
using System.Text;

namespace MathVectorSpace
{
    public class Exception_Riker : Exception
    {
        public Exception_Riker() : base("Error MF!") { }
        public Exception_Riker(string? message) : base(message) { }

    }

    class IncorrectIndex_Riker : Exception_Riker
    {
        public IncorrectIndex_Riker() : base("Incorrect Index in []!") { }

    }

    class DivideByZero_Riker : Exception_Riker
    {
        public DivideByZero_Riker() : base("U divide by zero!") { }

    }

    class WrongVecSizes_Riker : Exception_Riker
    {
        public WrongVecSizes_Riker() : base("Vectors sizes is differnt!") { }
    }

    class UncorrectValue_Riker : Exception_Riker
    {
        public UncorrectValue_Riker() : base("Uncorrect Value!") { }
    }

    class ErrorMF_Riker : Exception_Riker
    {
        public ErrorMF_Riker() : base() { }
    }
}
