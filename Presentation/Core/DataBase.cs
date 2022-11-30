using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DataBaseContext;
using DataBaseModels.Entity;


namespace Core
{
    public class DataBase
    {

        public void InitializeWithTestData()
        {
            using (Context db = new Context())
            {
                Specialization[] specs =
                {
                    new Specialization("Терапевт"),
                    new Specialization("Психиатр"),
                    new Specialization("Хирург")
                };


                Doctor[] docs =
                {
                    new Doctor (specs[2], "Рома" ),
                    new Doctor (specs[0], "Петя" ),
                    new Doctor(specs[1], "Вова"),
                    new Doctor(specs[2], "Коля"),
                    new Doctor(specs[2], "Поля")
                };

                Certificate[] cers =
                {
                    new Certificate(docs[0], "Молодец", new DateTime()),
                    new Certificate(docs[2], "Умничка", new DateTime()),
                    new Certificate(docs[2], "Бусенька", new DateTime()),
                    new Certificate(docs[3], "Просто хороший человек", new DateTime()),
                    new Certificate(docs[1], "Крутой", new DateTime())
                };

                db.Specializations.AddRange(specs);
                db.Doctors.AddRange(docs);
                db.Certificates.AddRange(cers);

                db.SaveChanges();
            }
        
        }

        public List<Doctor> GetListOfDocs()
        {
            List<Doctor> docs = new();

            using (Context db = new Context())
            {
                //прогружаем столбец
                db.Specializations.ToList();

                //забираем данные
                docs = db.Doctors.ToList();
            }

            return docs;
        }

        public List<Certificate> GetListOfCerfs()
        {
            List<Certificate> cerf = new();

            using (Context db = new Context())
            {
                //прогружаем столбец
                db.Doctors.ToList();

                //забираем данные
                cerf = db.Certificates.ToList();
            }

            return cerf;
        }

        public List<Specialization> GetListOfSpecs()
        {
            List<Specialization> specs = new();

            using (Context db = new Context())
            {
                specs = db.Specializations.ToList();
            }

            return specs;
        }


        public void AddToDoctors(Doctor doc)
        {
            using (Context db = new Context())
            {
                var specs = db.Specializations.ToList();
                db.Doctors.Add(new Doctor(specs.FirstOrDefault(x => doc.SpecializationId.Id == x.Id), doc.Name));

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
                var docs = db.Doctors.ToList();
                db.Certificates.Add(new Certificate(docs.FirstOrDefault(x => cerf.DoctorId.Id == x.Id), cerf.Description, cerf.Date.ToUniversalTime()));

                db.SaveChanges();
            }
        }

        public void ChangeDoctor(Doctor newDoc)
        {
            using (Context db = new Context())
            {
                var specs = db.Specializations.ToList();
                var doc = db.Doctors.FirstOrDefault(x => x.Id == newDoc.Id);

                if (doc != null)
                {
                    doc.Name = newDoc.Name;
                    doc.SpecializationId = specs.FirstOrDefault(x => newDoc.SpecializationId.Id == x.Id);
                }
                    

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

        public void ChangeCertificates(Certificate newCerf)
        {
            using (Context db = new Context())
            {
                var docs = db.Doctors.ToList();
                var cerf = db.Certificates.FirstOrDefault(x => x.Id == newCerf.Id);

                if (cerf != null)
                {
                    cerf.DoctorId = docs.FirstOrDefault(x => x.Id == newCerf.Id);
                    cerf.Description = newCerf.Description;
                    cerf.Date = newCerf.Date.ToUniversalTime();
                }

                db.SaveChanges();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (Context db = new Context())
            {
                var delete = db.Doctors.FirstOrDefault(x => x.Id == id);
                db.Doctors.Remove(delete);

                var deleteList = db.Certificates.Where(x => x.DoctorId.Id == id);
                db.Certificates.RemoveRange(deleteList);

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
                var delete = db.Certificates.FirstOrDefault(x => x.Id == id);
                db.Certificates.Remove(delete);

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
                var tmp = db.Specializations.ToArray();
                doc = db.Doctors.Find(id);
            }

            return doc;
        }

        public Certificate GetCertificate(int id)
        {
            Certificate cerf;
            using (Context db = new Context())
            {
                var tmp = db.Doctors.ToArray();
                cerf = db.Certificates.Find(id);
            }

            return cerf;
        }


    }
}
