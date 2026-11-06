using Microsoft.Data.SqlClient;

namespace Cap.Datos
{
    // Único lugar donde vive la cadena de conexión (regla técnica 2).
    public static class Conexion
    {
        private static readonly string cadena =
            "Server=localhost;Database=LaboratorioDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
