using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseModels.Entity
{
    //Навигационное поле
    //В теории, табличка должна понять, принять и зафигачить туда
    //только PK Доктора - 13:03
    // public Doctor DoctorId { get; set; }
    // Внешний ключ = <Имя навигационки> + <Название РК у сущности>
    //DoctorId xor DocId
    //public int DoсId { get; set; } 
    // НЕОБЯЗАТЕЛЕН, ТК ЕСТЬ НАВИГАЦИОНКА

    [PrimaryKey("Id")]
    public class Certificate
    {
        public int Id { get; set; }
        public Doctor DoctorId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Certificate() { }
        public Certificate(Doctor doctorId, string description, DateTime date)
        {
            DoctorId = doctorId;
            Description = description;
            Date = date;
        }

        public override string ToString() => $"Certificate {Id} to {DoctorId}: {Description}";
    }
}
