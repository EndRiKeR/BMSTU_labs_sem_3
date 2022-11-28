using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DataBaseContext;
using DataBaseModels.Entity;


namespace Core
{
    public class DataBase
    {
        public Limits GetIdLimits()
        {
            Limits limits;

            using (Context db = new Context())
            {
                limits = new Limits(db.Doctors.Select(x => x.Id).ToList(),
                                    db.Certificates.Select(x => x.Id).ToList(),
                                    db.Specializations.Select(x => x.Id).ToList());
            }

            return limits;
        }

        public void InitializeWithTestData()
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
        
        }

        public void AddToDoctors(Doctor doc)
        {
            using (Context db = new Context())
            {
                db.Doctors.Add(doc);

                db.SaveChanges();
            }
        }

        public void AddToSpecializations(Specialization spec)
        {
            using (Context db = new Context())
            {
                db.Specializations.Add(spec);

                db.SaveChanges();
            }
        }

        public void AddToCertificates(Certificate cerf)
        {
            using (Context db = new Context())
            {
                db.Certificates.Add(cerf);

                db.SaveChanges();
            }
        }

        public void ChangeDoctor(Doctor newDoc)
        {
            using (Context db = new Context())
            {
                var docs = db.Doctors.Where(x => x.Id == newDoc.Id).ToList();

                if (docs.Count == 1) //ERROR!!!!!
                    docs[0] = newDoc;

                db.SaveChanges();
            }
        }

        public void ChangeSpecialization(int id, Specialization newSpec)
        {
            using (Context db = new Context())
            {
                var specs = db.Specializations.Where(x => x.Id == id).ToList();

                if (specs.Count == 1)
                    specs[0] = newSpec;

                db.SaveChanges();
            }
        }

        public void ChangeCertificates(int id, Certificate newCerf)
        {
            using (Context db = new Context())
            {
                var cerfs = db.Certificates.Where(x => x.Id == id).ToList();

                if (cerfs.Count == 1)
                    cerfs[0] = newCerf;

                db.SaveChanges();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (Context db = new Context())
            {
                var deleteList = db.Doctors.Where(x => x.Id == id).ToList();
                db.Doctors.RemoveRange(deleteList);

                db.SaveChanges();
            }
        }

        public void DeleteSpecialization(int id)
        {
            using (Context db = new Context())
            {
                var deleteList = db.Specializations.Where(x => x.Id == id).ToList();
                db.Specializations.RemoveRange(deleteList);

                db.SaveChanges();
            }
        }

        public void DeleteCertificate(int id)
        {
            using (Context db = new Context())
            {
                var deleteList = db.Certificates.Where(x => x.Id == id).ToList();
                db.Certificates.RemoveRange(deleteList);

                db.SaveChanges();
            }
        }

        public void Test()
        {

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

        public Doctor GetDoctor(int id)
        {
            Doctor doc;
            using (Context db = new Context())
            {
                doc = db.Doctors.Find(id);
            }

            return doc;
        }
        

    }
}
