using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PetClinicLocal.Models
{
    public class Veterinarian
    {
        [PrimaryKey, AutoIncrement]
        public int VeterinarianId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ClinicName { get; set; }
        public string ClinicAddress { get; set; }
        public string ServiceHours { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Observations { get; set; }
        
        [OneToMany]
        public IEnumerable<Appointment> Appointments { get; set; }
    }
}
