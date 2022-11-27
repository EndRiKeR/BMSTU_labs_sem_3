using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels
{
    public interface IDbModel
    {
        public string Entities { get; }
        string GetValue(string table, string column);
        void SetValue(string table, string column, string valInStr);
    }
}
