using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels.Entity
{
    public class Certificate
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Certificate(int id, int doctorId, string description, DateTime date)
        {
            Id = id;
            DoctorId = doctorId;
            Description = description;
            Date = date;
        }
        public override string ToString() => $"Certificate {Id} to {DoctorId}: {Description}";
    }
}
