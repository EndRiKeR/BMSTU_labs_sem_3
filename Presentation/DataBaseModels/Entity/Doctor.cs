using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels.Entity
{
    public class Doctor
    {
        public int Id { get; set; }
        public int SpecializationId { get; set; }
        public string Name { get; set; }
        public Doctor(int id, int specializationId, string name)
        {
            Id = id;
            SpecializationId = specializationId;
            Name = name;
        }
        public override string ToString() => $"Doctor {Id} : {Name} with speciId {SpecializationId}";
    }
}
