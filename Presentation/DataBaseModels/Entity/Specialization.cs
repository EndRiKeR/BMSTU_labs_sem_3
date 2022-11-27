using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels.Entity
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Specialization(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString() => $"Specialization {Id}: {Name}";

    }
}
