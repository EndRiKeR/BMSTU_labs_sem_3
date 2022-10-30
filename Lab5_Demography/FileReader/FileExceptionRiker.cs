using System;
using System.Collections.Generic;
using System.Text;

namespace FileReader
{
    public class RikerBaseFileException : Exception
    {
        public RikerBaseFileException(string str) : base(str) { }
    }

    public class RikerFileNotExistsException : RikerBaseFileException
    {
        public RikerFileNotExistsException() : base("") { }
    }

    public class RikerFileWrongSizeException : RikerBaseFileException
    {
        public RikerFileWrongSizeException() : base("Wrong File Size!") { }

    }

    public class RikerFileWrongTypeException : RikerBaseFileException
    {
        public RikerFileWrongTypeException(string typeNeeded) : base($"Wrong File Type! Needed: {typeNeeded}") { }

    }

    public class RikerFileWrongDataException : RikerBaseFileException
    {
        public RikerFileWrongDataException() : base("Wrong Data in File!") { }

    }

    public class RikerFileUnexpectedException : RikerBaseFileException
    {
        public RikerFileUnexpectedException() : base("Unexpected File Exception!") { }

    }


}
