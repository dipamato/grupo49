using HospiEnCasa.App.Dominio;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente CrearPaciente(Paciente paciente);
        Paciente ConsultarPaciente(int idPaciente);
        IEnumerable<Paciente> ConsultarPacientes();
        Paciente ActualizarPaciente(Paciente paciente);
        void EliminarPaciente(int idPaciente);
    }

}
