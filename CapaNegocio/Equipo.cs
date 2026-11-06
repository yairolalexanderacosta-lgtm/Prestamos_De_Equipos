namespace Cap.Negocio
{
    // Clase modelo: representa un equipo del laboratorio.
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Estado { get; set; } = "Disponible";
    }
}
