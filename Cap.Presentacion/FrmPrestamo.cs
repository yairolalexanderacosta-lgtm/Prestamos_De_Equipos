using Cap.Negocio;

namespace Cap.Presentacion
{
    // Solo captura datos, llama a la capa de negocio y muestra mensajes.
    public partial class FrmPrestamo : Form
    {
        private readonly PrestamoNegocio prestamoNegocio = new PrestamoNegocio();
        private readonly EquipoNegocio equipoNegocio = new EquipoNegocio();
        private bool soloPendientes = false;

        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            CargarEquiposDisponibles();
            CargarPrestamos();
        }

        private void CargarEquiposDisponibles()
        {
            try
            {
                cboEquipo.DisplayMember = "Descripcion";
                cboEquipo.ValueMember = "IdEquipo";
                cboEquipo.DataSource = equipoNegocio.ListarDisponibles();
                cboEquipo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void CargarPrestamos()
        {
            try
            {
                if (soloPendientes)
                {
                    dgvPrestamos.DataSource = prestamoNegocio.ListarPendientes();
                    lblLista.Text = "Mostrando: préstamos pendientes de devolución";
                }
                else
                {
                    dgvPrestamos.DataSource = prestamoNegocio.Listar();
                    lblLista.Text = "Mostrando: todos los préstamos";
                }

                DataGridViewColumn? columnaIdEquipo = dgvPrestamos.Columns["IdEquipo"];
                if (columnaIdEquipo != null)
                {
                    columnaIdEquipo.Visible = false;
                }
                dgvPrestamos.ClearSelection();
                dgvPrestamos.CurrentCell = null;
                DataGridViewColumn? columnaDevolucion = dgvPrestamos.Columns["FechaDevolucion"];
                if (columnaDevolucion != null)
                {
                    columnaDevolucion.DefaultCellStyle.NullValue = "Pendiente";
                }
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = new Prestamo();
                if (cboEquipo.SelectedValue != null)
                {
                    prestamo.IdEquipo = Convert.ToInt32(cboEquipo.SelectedValue);
                }
                prestamo.Solicitante = txtSolicitante.Text;

                prestamoNegocio.RegistrarPrestamo(prestamo);

                MessageBox.Show("Préstamo registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarEquiposDisponibles();
                CargarPrestamos();
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                int idPrestamo = 0;
                if (dgvPrestamos.SelectedRows.Count > 0)
                {
                    idPrestamo = Convert.ToInt32(dgvPrestamos.SelectedRows[0].Cells["IdPrestamo"].Value);
                }

                if (idPrestamo > 0)
                {
                    string equipo = Convert.ToString(dgvPrestamos.CurrentRow!.Cells["Equipo"].Value) + "";
                    string solicitante = Convert.ToString(dgvPrestamos.CurrentRow.Cells["Solicitante"].Value) + "";
                    DialogResult respuesta = MessageBox.Show(
                        "¿Registrar la devolución de \"" + equipo + "\" prestado a " + solicitante + "?",
                        "Confirmar devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.No)
                    {
                        return;
                    }
                }

                prestamoNegocio.RegistrarDevolucion(idPrestamo);

                MessageBox.Show("Devolución registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquiposDisponibles();
                CargarPrestamos();
            }
            catch (Exception ex)
            {
                MostrarAviso(ex.Message);
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            soloPendientes = false;
            CargarPrestamos();
        }

        private void btnVerPendientes_Click(object sender, EventArgs e)
        {
            soloPendientes = true;
            CargarPrestamos();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvPrestamos.ClearSelection();
        }

        private void LimpiarCampos()
        {
            cboEquipo.SelectedIndex = -1;
            txtSolicitante.Clear();
            cboEquipo.Focus();
        }

        private void MostrarAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
