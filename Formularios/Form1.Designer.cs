namespace PARCIAL_2.Formularios
{
    partial class frmRegistrarNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarNota));
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtLaboratorio = new TextBox();
            lblLaboratorio = new Label();
            txtParcial = new TextBox();
            lblParcial = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtAsistencia = new TextBox();
            lblAsistencia = new Label();
            btnAgregar = new Button();
            dgvRegistro = new DataGridView();
            btnRemover = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(205, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(285, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(243, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.BorderStyle = BorderStyle.FixedSingle;
            txtLaboratorio.Location = new Point(336, 128);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(82, 27);
            txtLaboratorio.TabIndex = 3;
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.BackColor = Color.Transparent;
            lblLaboratorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLaboratorio.ForeColor = SystemColors.ControlText;
            lblLaboratorio.Location = new Point(216, 135);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(114, 20);
            lblLaboratorio.TabIndex = 2;
            lblLaboratorio.Text = "LABORATORIO";
            // 
            // txtParcial
            // 
            txtParcial.BorderStyle = BorderStyle.FixedSingle;
            txtParcial.Location = new Point(513, 128);
            txtParcial.Name = "txtParcial";
            txtParcial.Size = new Size(82, 27);
            txtParcial.TabIndex = 5;
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.BackColor = Color.Transparent;
            lblParcial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblParcial.ForeColor = SystemColors.ControlText;
            lblParcial.Location = new Point(436, 135);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(71, 20);
            lblParcial.TabIndex = 4;
            lblParcial.Text = "PARCIAL";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(638, 59);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(178, 27);
            txtCodigo.TabIndex = 7;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCodigo.ForeColor = SystemColors.ControlText;
            lblCodigo.Location = new Point(565, 66);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(67, 20);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "CODIGO";
            // 
            // txtAsistencia
            // 
            txtAsistencia.BorderStyle = BorderStyle.FixedSingle;
            txtAsistencia.Location = new Point(710, 128);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Size = new Size(82, 27);
            txtAsistencia.TabIndex = 11;
            // 
            // lblAsistencia
            // 
            lblAsistencia.AutoSize = true;
            lblAsistencia.BackColor = Color.Transparent;
            lblAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAsistencia.ForeColor = SystemColors.ControlText;
            lblAsistencia.Location = new Point(609, 135);
            lblAsistencia.Name = "lblAsistencia";
            lblAsistencia.Size = new Size(95, 20);
            lblAsistencia.TabIndex = 10;
            lblAsistencia.Text = "ASISTENCIA";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(300, 208);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 46);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dgvRegistro
            // 
            dgvRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistro.Location = new Point(12, 260);
            dgvRegistro.Name = "dgvRegistro";
            dgvRegistro.RowHeadersWidth = 51;
            dgvRegistro.Size = new Size(886, 301);
            dgvRegistro.TabIndex = 13;
            dgvRegistro.CellClick += dgvRegistro_CellClick;
            dgvRegistro.CellContentClick += dgvRegistro_CellContentClick;
            dgvRegistro.CellDoubleClick += dgvRegistro_CellDoubleClick;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.Red;
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(488, 208);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(118, 46);
            btnRemover.TabIndex = 14;
            btnRemover.Text = "REMOVER";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yet R", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Indigo;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(285, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 30);
            label2.TabIndex = 27;
            label2.Text = "REGISTRAR ESTUDIANTE";
            // 
            // frmRegistrarNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(910, 581);
            Controls.Add(label2);
            Controls.Add(btnRemover);
            Controls.Add(dgvRegistro);
            Controls.Add(btnAgregar);
            Controls.Add(txtAsistencia);
            Controls.Add(lblAsistencia);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtParcial);
            Controls.Add(lblParcial);
            Controls.Add(txtLaboratorio);
            Controls.Add(lblLaboratorio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistrarNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Estudiante";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtLaboratorio;
        private Label lblLaboratorio;
        private TextBox txtParcial;
        private Label lblParcial;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtAsistencia;
        private Label lblAsistencia;
        private Button btnAgregar;
        private DataGridView dgvRegistro;
        private Button btnRemover;
        private Label label2;
    }
}