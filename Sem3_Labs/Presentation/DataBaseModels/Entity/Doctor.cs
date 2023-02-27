using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataBaseModels.Entity
{
    //Не обязательно
    //VS ищет поля с Id в названии
    //[PrimaryKey("Id")]
    //[Table("SpecificDoctors")] - если не указан,
    //то табличка называется как сущность
    //
    //[Column("SpecificId")] - свое название колонки
    //[Key] - установка РК

    //Навигационное поле
    //public Specialization SpecializationId { get; set; }

    //Обязательность полей
    //public string Name { get; set; } - Обязательное поле (NOT NULL)
    //public string? Name { get; set; } - НЕ обязательное поле
    //[Required] public string? Name { get; set; } - обязательное

    [PrimaryKey("Id")]
    public class Doctor
    {
        public int Id { get; set; }
        public Specialization SpecializationId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Pay { get; set; }
        public List<Certificate> certificates { get; set; } = new();

        public Doctor() { }

        public Doctor(Specialization specializationId, string name)
        {
            SpecializationId = specializationId;
            Name = name;
            Pay = 0;
        }
        public Doctor(Specialization specializationId, string name, int pay)
        {
            SpecializationId = specializationId;
            Name = name;
            Pay = pay;
        }


        public override string ToString() => $"{Id}: ({Name})";
    }
}
