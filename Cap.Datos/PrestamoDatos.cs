using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Cap.Datos
{
    // Solo consulta, inserta y actualiza. No valida reglas.
    public class PrestamoDatos
    {
        private const string ConsultaBase =
            "SELECT p.IdPrestamo, p.IdEquipo, e.Codigo, e.Nombre AS Equipo, p.Solicitante, " +
            "p.FechaPrestamo, p.FechaDevolucion " +
            "FROM Prestamo p INNER JOIN Equipo e ON p.IdEquipo = e.IdEquipo ";

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = ConsultaBase + "ORDER BY p.FechaPrestamo DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Préstamos pendientes de devolución (funcionalidad 4).
        public DataTable ListarPendientes()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = ConsultaBase + "WHERE p.FechaDevolucion IS NULL ORDER BY p.FechaPrestamo";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Inserta el préstamo y marca el equipo como Prestado en una sola transacción.
        public void RegistrarPrestamo(int idEquipo, string solicitante, DateTime fechaPrestamo)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    string sqlInsert = "INSERT INTO Prestamo (IdEquipo, Solicitante, FechaPrestamo, FechaDevolucion) " +
                                       "VALUES (@IdEquipo, @Solicitante, @FechaPrestamo, NULL)";
                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, con, tx);
                    cmdInsert.Parameters.AddWithValue("@IdEquipo", idEquipo);
                    cmdInsert.Parameters.AddWithValue("@Solicitante", solicitante);
                    cmdInsert.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                    cmdInsert.ExecuteNonQuery();

                    string sqlEstado = "UPDATE Equipo SET Estado = @Estado WHERE IdEquipo = @IdEquipo";
                    SqlCommand cmdEstado = new SqlCommand(sqlEstado, con, tx);
                    cmdEstado.Parameters.AddWithValue("@Estado", "Prestado");
                    cmdEstado.Parameters.AddWithValue("@IdEquipo", idEquipo);
                    cmdEstado.ExecuteNonQuery();

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        // Guarda la fecha de devolución y regresa el equipo a Disponible en una sola transacción.
        public void RegistrarDevolucion(int idPrestamo, DateTime fechaDevolucion)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {
                    string sqlDevolucion = "UPDATE Prestamo SET FechaDevolucion = @FechaDevolucion " +
                                           "WHERE IdPrestamo = @IdPrestamo";
                    SqlCommand cmdDevolucion = new SqlCommand(sqlDevolucion, con, tx);
                    cmdDevolucion.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);
                    cmdDevolucion.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                    cmdDevolucion.ExecuteNonQuery();

                    string sqlEstado = "UPDATE Equipo SET Estado = @Estado " +
                                       "WHERE IdEquipo = (SELECT IdEquipo FROM Prestamo WHERE IdPrestamo = @IdPrestamo)";
                    SqlCommand cmdEstado = new SqlCommand(sqlEstado, con, tx);
                    cmdEstado.Parameters.AddWithValue("@Estado", "Disponible");
                    cmdEstado.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                    cmdEstado.ExecuteNonQuery();

                    tx.Commit();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        // Devuelve true si el préstamo ya tiene fecha de devolución.
        public bool EstaDevuelto(int idPrestamo)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                string sql = "SELECT FechaDevolucion FROM Prestamo WHERE IdPrestamo = @IdPrestamo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IdPrestamo", idPrestamo);
                con.Open();
                object resultado = cmd.ExecuteScalar();
                if (resultado == null || resultado == DBNull.Value)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
