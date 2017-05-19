using System.Collections.Generic;
using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IAppointment
{
    public interface IAppointmentReader
    {
        IEnumerable<Appointment> VariasCitas();
        Appointment Cita(int id);
    }
}