using System;
using Microsoft.EntityFrameworkCore;
using DataBaseModels;
using DataBaseModels.Entity;

namespace DataBaseContext
{
    public class Context : DbContext
    {
        // В DbModel передается класс, реализующий IDbModel
        // DbModel - модель базы данных (набор таблиц и сущностей)
        //public IDbModel DbModel { get; set; }

        public DbSet<Specialization> Specializations { get; set; } //найти как PK установить
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }

        //Создавая объект контекста автоматически пробуем подключиться к БД
        public Context()
        {
            Database.EnsureCreated();
            //DbModel = model;
        }

        // Как я понял, это метод настройки подключения.
        // Я использую подключение через длиииииинную строку параметров.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=testDbLaptop;Username=postgres;Password=Uthfym5144172");
        }

    }
}
