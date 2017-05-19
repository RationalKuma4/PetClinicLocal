using System;
using PetClinicLocal.Models.Enums;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PetClinicLocal.Models
{
    public class Appointment
    {
        [PrimaryKey, AutoIncrement]
        public int AppointmentId { get; set; }

        public DateTime DateAppointment { get; set; }
        public bool Completed { get; set; }
        public AppointmentType AppointmentType { get; set; }
        public string Observations { get; set; }

        [ForeignKey(typeof(Pet))]
        public int PetId { get; set; }

        [ForeignKey(typeof(Veterinarian))]
        public int VeterinarianId { get; set; }
    }
}
