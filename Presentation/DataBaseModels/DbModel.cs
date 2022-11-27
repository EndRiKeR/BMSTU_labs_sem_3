using System;
using DataBaseModels.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace DataBaseModels
{
    public class DbModel// : IDbModel
    {
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public string Entities { get; }
        public DbModel()
        {
            Entities = $"{nameof(Specializations)}{nameof(Doctors)}{nameof(Certificates)}";
        }


        /*
         * Я пытался сделать ух какой универсальный код
         * Но я столкнулся с проблемой, тк я игрался с сущностями, которые как бы есть
         * То я не могу нормально считать индекс
         * 
         * //this.GetType().GetProperties().ToString().Contains(table)
         * 
         * string GetValue(string table, string column)
        {
            if (this.GetType().GetProperties().ToString().Contains(table))
            {
               var index = this.GetType().GetProperty(table).GetValue(this, null).indexOf(column);
               return this.GetType().GetProperty(table).GetValue(this, column).ToString();
            }
            return null;
        }
        void SetValue(string table, string column, string valInStr)
        {
            if (this.GetType().GetProperties().ToString().Contains(table))
            {
                this.GetType().GetProperty(table).SetValue(this, (object)valInStr);
            }
        }*/
    }
}
