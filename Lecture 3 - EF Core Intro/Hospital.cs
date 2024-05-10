using System;

namespace EFCoreDemo;


    public class Hospital
    {
        public void ListPatients()
        {
            using (var db = new AppDbConnect())
            {
                foreach(Patient p in db.Patients)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
