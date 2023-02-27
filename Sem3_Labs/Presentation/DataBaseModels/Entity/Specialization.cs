using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels.Entity
{
    [PrimaryKey("Id")]
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Doctor> doctors { get; set; }

        public Specialization() { }
        public Specialization(string name)
        {
            Name = name;
        }
        public override string ToString() => $"{Id}: ({Name})";

    }
}
