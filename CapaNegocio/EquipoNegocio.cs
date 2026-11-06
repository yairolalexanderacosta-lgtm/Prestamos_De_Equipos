using System;
using System.Data;
using Cap.Datos;

namespace Cap.Negocio
{
    // Valida las reglas de los equipos y llama a la capa de datos.
    public class EquipoNegocio
    {
        private readonly EquipoDatos datos = new EquipoDatos();

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public DataTable ListarDisponibles()
        {
            return datos.ListarDisponibles();
        }

        public void Guardar(Equipo equipo)
        {
            Validar(equipo);

            if (datos.ContarPorCodigo(equipo.Codigo, 0) > 0)
            {
                throw new Exception("Ya existe un equipo con el código " + equipo.Codigo + ".");
            }

            // Todo equipo nuevo entra como Disponible.
            datos.Insertar(equipo.Codigo, equipo.Nombre);
        }

        public void Modificar(Equipo equipo)
        {
            if (equipo.IdEquipo <= 0)
            {
                throw new Exception("Seleccione en la lista el equipo que desea modificar.");
            }

            Validar(equipo);

            if (datos.ContarPorCodigo(equipo.Codigo, equipo.IdEquipo) > 0)
            {
                throw new Exception("Ya existe otro equipo con el código " + equipo.Codigo + ".");
            }

            datos.Actualizar(equipo.IdEquipo, equipo.Codigo, equipo.Nombre);
        }

        private void Validar(Equipo equipo)
        {
            equipo.Codigo = equipo.Codigo.Trim();
            equipo.Nombre = equipo.Nombre.Trim();

            if (equipo.Codigo == "")
            {
                throw new Exception("El código del equipo es obligatorio.");
            }

            if (equipo.Nombre == "")
            {
                throw new Exception("El nombre del equipo es obligatorio.");
            }
        }
    }
}
