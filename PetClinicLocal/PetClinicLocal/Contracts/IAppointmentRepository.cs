using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Contracts
{
    public interface IAppointmentRepository
    {
        void AddAppointment(Appointment appointment);
        Appointment UpdateAppointment(Appointment appointment);
        void RemoveAppointment(int id);
        IEnumerable<Appointment> GetAppointments();
        Appointment GetAppointment(int id);
    }
}
