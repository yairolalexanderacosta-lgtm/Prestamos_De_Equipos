using System;

namespace Cap.Negocio
{
    // Clase modelo: representa un préstamo de un equipo.
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdEquipo { get; set; }
        public string Solicitante { get; set; } = "";
        public DateTime FechaPrestamo { get; set; }

        // Nulo mientras el equipo no se ha devuelto.
        public DateTime? FechaDevolucion { get; set; }
    }
}