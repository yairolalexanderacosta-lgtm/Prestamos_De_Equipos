using System.Data;
using Microsoft.Data.SqlClient;

namespace Cap.Datos
{
    // Solo consulta, inserta y actualiza. No valida reglas.
    public class EquipoDatos
    {
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "SELECT IdEquipo, Codigo, Nombre, Estado FROM Equipo ORDER BY Codigo";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Para llenar el ComboBox del formulario de préstamos.
        public DataTable ListarDisponibles()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "SELECT IdEquipo, Codigo + ' - ' + Nombre AS Descripcion " +
                             "FROM Equipo WHERE Estado = @Estado ORDER BY Codigo";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@Estado", "Disponible");
                da.Fill(tabla);
            }
            return tabla;
        }

        public void Insertar(string codigo, string nombre)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "INSERT INTO Equipo (Codigo, Nombre, Estado) VALUES (@Codigo, @Nombre, @Estado)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Estado", "Disponible");
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(int idEquipo, string codigo, string nombre)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "UPDATE Equipo SET Codigo = @Codigo, Nombre = @Nombre WHERE IdEquipo = @IdEquipo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Cuenta cuántos equipos tienen ese código, excluyendo uno (para modificar).
        // Al insertar se pasa idExcluir = 0.
        public int ContarPorCodigo(string codigo, int idExcluir)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Equipo WHERE Codigo = @Codigo AND IdEquipo <> @IdExcluir";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@IdExcluir", idExcluir);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // Devuelve "Disponible", "Prestado" o una cadena vacía si no existe.
        public string ObtenerEstado(int idEquipo)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "SELECT Estado FROM Equipo WHERE IdEquipo = @IdEquipo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                con.Open();
                object resultado = cmd.ExecuteScalar();
                if (resultado == null)
                {
                    return "";
                }
                else
                {
                    return resultado.ToString();
                }
            }
        }
    }
}