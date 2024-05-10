using EFCoreDemo;

Patient patientOne = new Patient() {FirstName = "Kareem", LastName = "Dana"};

using (var db = new AppDbConnect()) //logs into the database
{
    if(db.Database.EnsureCreated())
    {
    db.Add(patientOne);
    db.SaveChanges();
    }
}

using(var db = new AppDbConnect())
{
    foreach(Patient p in db.Patients)
    {
        Console.WriteLine($"{p.PatientID}   {p.FirstName} {p.LastName}");
    }
}    

//Update
using(var db = new AppDbConnect())
{
    //Step1
    Patient patientToUpdate = db.Patients.First();

    //Step2
    patientToUpdate.FirstName = "Amjad";
    db.SaveChanges();
}

using(var db = new AppDbConnect())
{
    foreach(Patient p in db.Patients)
    {
        Console.WriteLine($"{p.PatientID}   {p.FirstName} {p.LastName}");
    }
}

using (var db = new AppDbConnect())
{
    Patient patientTwo = new Patient() {FirstName = "Jeff", LastName = "Babb"};
    db.Add(patientTwo);
    db.SaveChanges();
}

using (var db = new AppDbConnect())
{
    Patient patientToRemove = db.Patients.Find(2)!;
    db.Remove(patientToRemove);
    db.SaveChanges();
}

using(var db = new AppDbConnect())
{
    foreach(Patient p in db.Patients)
    {
        Console.WriteLine($"{p.PatientID}   {p.FirstName} {p.LastName}");
    }
}  

List<Patient> patients = new List<Patient> {
    new Patient {FirstName = "Jeff", LastName = "Babb"},
    new Patient {FirstName = "Sean", LastName = "Humphreys"},
    new Patient {FirstName = "Walter", LastName = "Wendler"}
};

using (var db = new AppDbConnect())
{
    db.AddRange(patients);
    db.SaveChanges();
}

Hospital myHospital = new Hospital();
myHospital.ListPatients();