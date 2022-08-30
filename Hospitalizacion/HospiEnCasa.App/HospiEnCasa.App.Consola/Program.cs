using System;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente =new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarPaciente();
        }
        private static void AdicionarPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Juan Camilo",
                Apellidos="Mora Lopez",
                NumeroTelefono="123456",
                Genero=Genero.Masculino,
                Direccion=" Calle 45 Carrera 34",
                Latitud=2.56F,
                Longitud=-6.3F,
                Ciudad="Bogotá",
                FechaNacimiento=new DateTime(1990,08,22)
            };
            _repoPaciente.CrearPaciente(paciente);
        }
    }
}
