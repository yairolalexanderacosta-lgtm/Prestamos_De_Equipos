namespace Cap.Presentacion
{
    partial class FrmPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnPrestar = new Button();
            btnDevolver = new Button();
            btnVerTodos = new Button();
            btnVerPendientes = new Button();
            lblEquipo = new Label();
            lblSolicitante = new Label();
            lblLista = new Label();
            txtSolicitante = new TextBox();
            cboEquipo = new ComboBox();
            dgvPrestamos = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrestar
            // 
            btnPrestar.BackColor = Color.FromArgb(30, 60, 114);
            btnPrestar.Cursor = Cursors.Hand;
            btnPrestar.FlatAppearance.BorderSize = 0;
            btnPrestar.FlatStyle = FlatStyle.Flat;
            btnPrestar.ForeColor = Color.White;
            btnPrestar.Location = new Point(1471, 53);
            btnPrestar.Name = "btnPrestar";
            btnPrestar.Size = new Size(308, 53);
            btnPrestar.TabIndex = 0;
            btnPrestar.Text = "Registrar préstamo";
            btnPrestar.UseVisualStyleBackColor = false;
            btnPrestar.Click += btnPrestar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.FromArgb(30, 60, 114);
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(1471, 161);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(306, 45);
            btnDevolver.TabIndex = 1;
            btnDevolver.Text = "Registrar devolución";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnVerTodos
            // 
            btnVerTodos.BackColor = Color.FromArgb(108, 117, 125);
            btnVerTodos.Cursor = Cursors.Hand;
            btnVerTodos.FlatAppearance.BorderSize = 0;
            btnVerTodos.FlatStyle = FlatStyle.Flat;
            btnVerTodos.ForeColor = Color.White;
            btnVerTodos.Location = new Point(28, 320);
            btnVerTodos.Name = "btnVerTodos";
            btnVerTodos.Size = new Size(173, 53);
            btnVerTodos.TabIndex = 2;
            btnVerTodos.Text = "Ver todos";
            btnVerTodos.UseVisualStyleBackColor = false;
            btnVerTodos.Click += btnVerTodos_Click;
            // 
            // btnVerPendientes
            // 
            btnVerPendientes.BackColor = Color.FromArgb(108, 117, 125);
            btnVerPendientes.Cursor = Cursors.Hand;
            btnVerPendientes.FlatAppearance.BorderSize = 0;
            btnVerPendientes.FlatStyle = FlatStyle.Flat;
            btnVerPendientes.ForeColor = Color.White;
            btnVerPendientes.Location = new Point(353, 328);
            btnVerPendientes.Name = "btnVerPendientes";
            btnVerPendientes.Size = new Size(293, 53);
            btnVerPendientes.TabIndex = 3;
            btnVerPendientes.Text = "Ver pendientes";
            btnVerPendientes.UseVisualStyleBackColor = false;
            btnVerPendientes.Click += btnVerPendientes_Click;
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(12, 118);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(107, 37);
            lblEquipo.TabIndex = 4;
            lblEquipo.Text = "Equipo:";
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Location = new Point(3, 219);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(147, 37);
            lblSolicitante.TabIndex = 5;
            lblSolicitante.Text = "Solicitante:";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(469, 222);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(399, 37);
            lblLista.TabIndex = 6;
            lblLista.Text = "Mostrando: todos los préstamos";
            // 
            // txtSolicitante
            // 
            txtSolicitante.Location = new Point(171, 216);
            txtSolicitante.MaxLength = 100;
            txtSolicitante.Name = "txtSolicitante";
            txtSolicitante.Size = new Size(250, 43);
            txtSolicitante.TabIndex = 7;
            // 
            // cboEquipo
            // 
            cboEquipo.BackColor = Color.FromArgb(30, 60, 114);
            cboEquipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEquipo.FormattingEnabled = true;
            cboEquipo.Location = new Point(142, 118);
            cboEquipo.Name = "cboEquipo";
            cboEquipo.Size = new Size(279, 45);
            cboEquipo.TabIndex = 8;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 60, 114);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.Location = new Point(28, 431);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.RowHeadersWidth = 82;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1703, 253);
            dgvPrestamos.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(413, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 99);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(79, 23);
            label1.Name = "label1";
            label1.Size = new Size(484, 51);
            label1.TabIndex = 0;
            label1.Text = "Préstamos y devoluciones";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(1471, 320);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(225, 46);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 228, 240);
            ClientSize = new Size(1937, 791);
            Controls.Add(btnLimpiar);
            Controls.Add(lblLista);
            Controls.Add(panel1);
            Controls.Add(dgvPrestamos);
            Controls.Add(cboEquipo);
            Controls.Add(txtSolicitante);
            Controls.Add(lblSolicitante);
            Controls.Add(lblEquipo);
            Controls.Add(btnVerPendientes);
            Controls.Add(btnVerTodos);
            Controls.Add(btnDevolver);
            Controls.Add(btnPrestar);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrestamo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Préstamos de equipos";
            Load += FrmPrestamo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrestar;
        private Button btnDevolver;
        private Button btnVerTodos;
        private Button btnVerPendientes;
        private Label lblEquipo;
        private Label lblSolicitante;
        private Label lblLista;
        private TextBox txtSolicitante;
        private ComboBox cboEquipo;
        private DataGridView dgvPrestamos;
        private Panel panel1;
        private Label label1;
        private Button btnLimpiar;
    }
}