namespace Cap.Presentacion
{
    partial class FrmEquipo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblCodigo = new Label();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            btnPrestamos = new Button();
            dgvEquipos = new DataGridView();
            panel1 = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(14, 158);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(111, 37);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(964, 152);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 37);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(171, 152);
            txtCodigo.MaxLength = 20;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(230, 43);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1181, 149);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 43);
            txtNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(30, 60, 114);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(46, 357);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(207, 68);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(30, 60, 114);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(384, 357);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(209, 68);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(108, 117, 125);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(768, 357);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(187, 68);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.FromArgb(30, 60, 114);
            btnPrestamos.Cursor = Cursors.Hand;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.ForeColor = Color.White;
            btnPrestamos.Location = new Point(1203, 357);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(208, 68);
            btnPrestamos.TabIndex = 7;
            btnPrestamos.Text = "Préstamos...";
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.BackgroundColor = Color.White;
            dgvEquipos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 60, 114);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.EnableHeadersVisualStyles = false;
            dgvEquipos.Location = new Point(14, 481);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.RowHeadersWidth = 82;
            dgvEquipos.Size = new Size(1059, 288);
            dgvEquipos.TabIndex = 8;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(271, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 76);
            panel1.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.DimGray;
            lblTitulo.Location = new Point(45, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(587, 51);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Control de equipos de laboratorio";
            // 
            // FrmEquipo
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 228, 240);
            ClientSize = new Size(1918, 859);
            Controls.Add(panel1);
            Controls.Add(dgvEquipos);
            Controls.Add(btnPrestamos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Equipos de laboratorio";
            Load += FrmEquipo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnLimpiar;
        private Button btnPrestamos;
        private DataGridView dgvEquipos;
        private Panel panel1;
        private Label lblTitulo;
    }
}
