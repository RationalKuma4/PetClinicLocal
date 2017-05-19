using System.Collections.Generic;
using PetClinicLocal.Contracts;
using PetClinicLocal.Models;
using SQLite.Net;
using Xamarin.Forms;
using System.Linq;

namespace PetClinicLocal.Data
{
    public class PetClinicDatabaseService : IOwnerService, IPetService, IVeterinarianService, IAppointmentService
    {
        private readonly SQLiteConnection _connection;

        public PetClinicDatabaseService()
        {
            _connection = DependencyService.Get<IData>().GetConnection();
            CreateDataBaseTables();
        }

        private void CreateDataBaseTables()
        {
            _connection.CreateTable<OwnerUser>();
            _connection.CreateTable<Pet>();
            _connection.CreateTable<Veterinarian>();
            _connection.CreateTable<Appointment>();
        }

        public void AddOwner(OwnerUser user)
        {
            _connection.Insert(user, typeof(OwnerUser));
        }

        public OwnerUser UpdateOwnerUser(OwnerUser user)
        {
            _connection.Update(user, typeof(OwnerUser));
            return _connection.Table<OwnerUser>().FirstOrDefault(u => u.OwnerUserId == user.OwnerUserId);
        }

        public void RemoveOwnerUser(int id)
        {
            _connection.Delete<OwnerUser>(id);
        }

        public IEnumerable<OwnerUser> GetOwnerUsers()
        {
            return _connection.Table<OwnerUser>();
        }

        public OwnerUser GetOwnerUser(int id)
        {
            return _connection.Table<OwnerUser>().FirstOrDefault(u => u.OwnerUserId == id);
        }

        public void AddPet(Pet pet)
        {
            _connection.Insert(pet, typeof(Pet));
        }

        public Pet UpdatePet(Pet pet)
        {
            _connection.Update(pet, typeof(Pet));
            return _connection.Table<Pet>().FirstOrDefault(p => p.PetId == pet.PetId);
        }

        public void RemovePet(int id)
        {
            _connection.Delete<Pet>(id);
        }

        public IEnumerable<Pet> GetPets()
        {
            return _connection.Table<Pet>();
        }

        public Pet GetPet(int id)
        {
            return _connection.Table<Pet>().FirstOrDefault(p => p.PetId == id);
        }

        public void AddVeterinarian(Veterinarian veterinarian)
        {
            _connection.Insert(veterinarian, typeof(Veterinarian));
        }

        public Veterinarian UpdateVeterinarian(Veterinarian veterinarian)
        {
            _connection.Update(veterinarian, typeof(Veterinarian));
            return _connection.Table<Veterinarian>().FirstOrDefault(v => v.VeterinarianId == veterinarian.VeterinarianId);
        }

        public void RemoveVeterinarian(int id)
        {
            _connection.Delete<Veterinarian>(id);
        }

        public IEnumerable<Veterinarian> GetVeterinarians()
        {
            return _connection.Table<Veterinarian>();
        }

        public Veterinarian GetVeterinarian(int id)
        {
            return _connection.Table<Veterinarian>().FirstOrDefault(v => v.VeterinarianId == id);
        }

        public void AddAppointment(Appointment appointment)
        {
            _connection.Insert(appointment, typeof(Appointment));
        }

        public Appointment UpdateAppointment(Appointment appointment)
        {
            _connection.Update(appointment, typeof(Appointment));
            return _connection.Table<Appointment>().FirstOrDefault(a => a.AppointmentId == appointment.AppointmentId);
        }

        public void RemoveAppointment(int id)
        {
            _connection.Delete<Appointment>(id);
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            return _connection.Table<Appointment>();
        }

        public Appointment GetAppointment(int id)
        {
            return _connection.Table<Appointment>().FirstOrDefault(a => a.AppointmentId == id);
        }
    }
}
