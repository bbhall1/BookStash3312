using System;

namespace EFCoreDemo
{
    public class Patient
    {
        public int PatientID {get; set;} // Primary Key
        public string FirstName {get; set;} = string.Empty;
        public string? LastName {get;set;}

        public override string ToString()
        {
            return $"{PatientID}   {FirstName} {LastName}";
        }
    }
}    