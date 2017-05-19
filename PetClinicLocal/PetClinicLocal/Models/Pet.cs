using System;
using System.Collections.Generic;
using PetClinicLocal.Models.Enums;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PetClinicLocal.Models
{
    public class Pet
    {
        [PrimaryKey, AutoIncrement]
        public int PetId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Sex { get; set; }
        public string Breed { get; set; }
        public string Coulors { get; set; }
        public PetType PetType { get; set; }
        public string Observations { get; set; }

        [ForeignKey(typeof(OwnerUser))]
        public int OwnerUserId { get; set; }

        [ForeignKey(typeof(Appointment))]
        public int AppointmentId { get; set; }

        [OneToMany]
        public IEnumerable<Appointment> Appointments { get; set; }
    }
}
