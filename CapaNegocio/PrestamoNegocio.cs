using System;
using System.Data;
using Cap.Datos;

namespace Cap.Negocio
{
    // Valida las reglas de préstamos y devoluciones y llama a la capa de datos.
    public class PrestamoNegocio
    {
        private readonly PrestamoDatos datos = new PrestamoDatos();
        private readonly EquipoDatos equipoDatos = new EquipoDatos();

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public DataTable ListarPendientes()
        {
            return datos.ListarPendientes();
        }

        public void RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo.IdEquipo <= 0)
            {
                throw new Exception("Seleccione el equipo que se va a prestar.");
            }

            prestamo.Solicitante = prestamo.Solicitante.Trim();
            if (prestamo.Solicitante == "")
            {
                throw new Exception("El nombre del solicitante es obligatorio.");
            }
            foreach (char c in prestamo.Solicitante)
            {
                if (char.IsDigit(c))
                {
                    throw new Exception("El nombre del solicitante no puede contener números.");
                }
            }
            string estado = equipoDatos.ObtenerEstado(prestamo.IdEquipo);
            if (estado == "")
            {
                throw new Exception("El equipo seleccionado no existe.");
            }

            // Regla 1: no se puede prestar un equipo que ya está prestado.
            if (estado == "Prestado")
            {
                throw new Exception("Este equipo ya está prestado. Debe devolverse antes de prestarlo otra vez.");
            }

            prestamo.FechaPrestamo = DateTime.Now;

            // Regla 3: la capa de datos cambia el estado del equipo a Prestado.
            datos.RegistrarPrestamo(prestamo.IdEquipo, prestamo.Solicitante, prestamo.FechaPrestamo);
        }

        public void RegistrarDevolucion(int idPrestamo)
        {
            if (idPrestamo <= 0)
            {
                throw new Exception("Seleccione en la lista el préstamo que se va a devolver.");
            }

            // Regla 2: no se puede devolver un préstamo ya devuelto.
            if (datos.EstaDevuelto(idPrestamo))
            {
                throw new Exception("Este préstamo ya fue devuelto.");
            }

            // Regla 3: la capa de datos regresa el equipo a Disponible.
            datos.RegistrarDevolucion(idPrestamo, DateTime.Now);
        }
    }
}