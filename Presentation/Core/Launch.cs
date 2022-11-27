using System;
using System.Linq;
using DataBaseContext;
using DataBaseModels.Entity;


namespace Core
{
    public class Launch
    {


        public void Test()
        {
            using (Context db = new Context())
            {
                Specialization[] specs =
                {
                    new Specialization(1, "Терапевт"),
                    new Specialization(2, "Психиатр"),
                    new Specialization(3, "Хирург")
                };


                Doctor[] docs =
                {
                    new Doctor ( 1, 3, "Рома" ),
                    new Doctor ( 2, 1, "Петя" ),
                    new Doctor(3, 2, "Вова"),
                    new Doctor(4, 3, "Коля"),
                    new Doctor(5, 3, "Поля")
                };

                Certificate[] cers =
                {
                    new Certificate(1, 1, "Молодец", new DateTime()),
                    new Certificate(2, 3, "Умничка", new DateTime()),
                    new Certificate(3, 3, "Бусенька", new DateTime()),
                    new Certificate(4, 4, "Просто хороший человек", new DateTime()),
                    new Certificate(5, 2, "Крутой", new DateTime())
                };

                db.Specializations.AddRange(specs);
                db.Doctors.AddRange(docs);
                db.Certificates.AddRange(cers);

                db.SaveChanges();
            }


            using (Context db = new Context())
            {
                var docs = db.Doctors.ToList();
                Console.WriteLine("Users list:");
                foreach (Doctor doc in docs)
                {
                    Console.WriteLine(doc);
                }
            }
        }
        

    }
}
