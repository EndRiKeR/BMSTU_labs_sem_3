using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathVectorSpace;

namespace GrafsForIris.GrafsBuilder
{
    public class RikerBaseFileExceptions : RikerException
    {
        public RikerBaseFileExceptions(string str) : base(str) { }

    }

    public class RikerFileNotExistsException : RikerBaseFileExceptions
    {
        public RikerFileNotExistsException() : base("File Doesn't Exist!") { }

    }

    public class RikerFileWrongSizeExceptions : RikerBaseFileExceptions
    {
        public RikerFileWrongSizeExceptions() : base("Wrong File Size!") { }

    }
    
    public class RikerFileWrongTypeExceptions : RikerBaseFileExceptions
    {
        public RikerFileWrongTypeExceptions(string typeNeeded) : base($"Wrong File Type! Needed: {typeNeeded}") { }

    }

    public class RikerFileWrongDataExceptions : RikerBaseFileExceptions
    {
        public RikerFileWrongDataExceptions() : base("Wrong Data in File!") { }

    }

    public class RikerFileUnexpectedExceptions : RikerBaseFileExceptions
    {
        public RikerFileUnexpectedExceptions() : base("Wrong Data in File!") { }

    }

    public class RikerWrongIrisTypeException : RikerBaseFileExceptions
    {
        public RikerWrongIrisTypeException(string catched) : base($"Wrong Iris Type in File! Catched {catched}.") { }

    }


}
