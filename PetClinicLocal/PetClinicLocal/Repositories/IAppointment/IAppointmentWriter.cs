using PetClinicLocal.Models;

namespace PetClinicLocal.Repositories.IAppointment
{
    public interface IAppointmentWriter
    {
        void RegistraCita(Appointment appointment);
        Appointment ModificaCita(Appointment appointment);
        void EliminaCita(int id);
    }
}