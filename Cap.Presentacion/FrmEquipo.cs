using Cap.Negocio;

namespace Cap.Presentacion
{
    // Solo captura datos, llama a la capa de negocio y muestra mensajes.
    public partial class FrmEquipo : Form
    {
        private readonly EquipoNegocio negocio = new EquipoNegocio();
        private int idSeleccionado = 0;

        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void CargarEquipos()
        {
            try
            {
                dgvEquipos.DataSource = negocio.Listar();
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = new Equipo();
                equipo.Codigo = txtCodigo.Text;
                equipo.Nombre = txtNombre.Text;

                negocio.Guardar(equipo);

                MessageBox.Show("Equipo guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarEquipos();
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = new Equipo();
                equipo.IdEquipo = idSeleccionado;
                equipo.Codigo = txtCodigo.Text;
                equipo.Nombre = txtNombre.Text;

                negocio.Modificar(equipo);

                MessageBox.Show("Equipo modificado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarEquipos();
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            using (FrmPrestamo frm = new FrmPrestamo())
            {
                frm.ShowDialog();
            }

            // Al volver, los estados pueden haber cambiado.
            CargarEquipos();
        }

        // Al hacer clic en una fila, pasa sus datos a los TextBox para modificarla.
        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvEquipos.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdEquipo"].Value);
            txtCodigo.Text = Convert.ToString(fila.Cells["Codigo"].Value);
            txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtCodigo.Clear();
            txtNombre.Clear();
            dgvEquipos.ClearSelection();
            txtCodigo.Focus();
        }

        private void MostrarAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
