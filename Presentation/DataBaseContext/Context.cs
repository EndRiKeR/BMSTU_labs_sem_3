using System;
using Microsoft.EntityFrameworkCore;
using DataBaseModels;
using DataBaseModels.Entity;

namespace DataBaseContext
{
    public class Context : DbContext
    {
        public DbSet<Specialization> Specializations { get; set; } //null! or Set<Spec>();
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Certificate> Certificates { get; set; }

        //Создавая объект контекста автоматически пробуем подключиться к БД
        public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
            
            //DbModel = model;
        }

        // Как я понял, это метод настройки подключения.
        // Я использую подключение через длиииииинную строку параметров.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=DbV1_testLazyId;Username=postgres;Password=Uthfym5144172");
            optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Состовной ключ - modelBuilder.Entity<Doctor>().HasKey(u => new { u.Id, u.SpecializationId });
            //Также может быть альтернативный ключ
            //он ограничивает уникальностью столбец
            //и он может быть использован как РК
            //установка ограничений - modelBuilder.Entity<Doctor>().ToTable(t => t.HasCheckConstraint("Age", "Age > 0 AND Age < 120"));
            base.OnModelCreating(modelBuilder);
            //
        }

    }
}
