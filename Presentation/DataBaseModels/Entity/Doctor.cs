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
    [PrimaryKey("Id")]
    //[Table("SpecificDoctors")] - если не указан,
    //то табличка называется как сущность
    //
    public class Doctor
    {
        //[Column("SpecificId")] - свое название колонки
        //[Key] - установка РК
        public int Id { get; set; }
        //Навигационное поле
        public Specialization SpecializationId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        //Обязательность полей
        //public string Name { get; set; } - Обязательное поле (NOT NULL)
        //public string? Name { get; set; } - НЕ обязательное поле
        //[Required] public string? Name { get; set; } - обязательное

        public Doctor() { }
        public Doctor(Specialization specializationId, string name)
        {
            SpecializationId = specializationId;
            Name = name;
        }
        public override string ToString() => $"Doctor {Id} : {Name} with speciId {SpecializationId}";
    }
}
