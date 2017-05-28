using System;
using System.Collections.Generic;
using PetClinicLocal.Contracts;
using PetClinicLocal.Models;
using PetClinicLocal.Repositories.IAppointment;

namespace PetClinicLocal.Repositories
{
    public class AppointmentRepository : IAppointmentWriter, IAppointmentReader
    {
        private readonly IAppointmentService _service;
        public AppointmentRepository(IAppointmentService service)
        {
            _service = service;
        }

        public void RegistraCita(Appointment appointment)
        {
            _service.AddAppointment(appointment);
        }

        public Appointment ModificaCita(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void EliminaCita(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> VariasCitas()
        {
            return _service.GetAppointments();
        }

        public Appointment Cita(int id)
        {
            throw new NotImplementedException();
        }
    }
}
