using HospiEnCasa.App.Dominio;
using System.Linq;
using System.Collections.Generic;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioPaciente:IRepositorioPaciente
    {
        private readonly AppContext _appContext;
        public RepositorioPaciente(AppContext appContext)
        {
            this._appContext=appContext;
        }
        public Paciente CrearPaciente(Paciente paciente)
        {
            var pacienteAdicionado=_appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        public Paciente ConsultarPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
             
        }
        public IEnumerable<Paciente> ConsultarPacientes()
        {
            return _appContext.Pacientes;
        }
        public Paciente ActualizarPaciente(Paciente paciente)
        {
            var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p=>p.Id==paciente.Id);
            if(pacienteEncontrado!=null){
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono=paciente.NumeroTelefono;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Direccion=paciente.Direccion;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                pacienteEncontrado.Medico=paciente.Medico;
                pacienteEncontrado.Enfermera=paciente.Enfermera;
                pacienteEncontrado.Familiar=paciente.Familiar;
                pacienteEncontrado.Historia=paciente.Historia;

                _appContext.SaveChanges();
            }

            return pacienteEncontrado;

        }

        public void EliminarPaciente(int idPaciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p=>p.Id==idPaciente);
            if(pacienteEncontrado==null)
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
    }       
}