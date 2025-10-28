namespace PARCIAL_2.Formularios
{
    partial class frmRegistrarNotaCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarNotaCmd));
            txtAsistencia = new TextBox();
            lblAsistencia = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtParcial = new TextBox();
            lblParcial = new Label();
            txtLaboratorio = new TextBox();
            lblLaboratorio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnActualizar = new Button();
            label1 = new Label();
            chbActivo = new CheckBox();
            btnCancelar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtAsistencia
            // 
            txtAsistencia.BorderStyle = BorderStyle.FixedSingle;
            txtAsistencia.Location = new Point(592, 146);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Size = new Size(94, 27);
            txtAsistencia.TabIndex = 21;
            // 
            // lblAsistencia
            // 
            lblAsistencia.AutoSize = true;
            lblAsistencia.BackColor = Color.Transparent;
            lblAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAsistencia.Location = new Point(491, 157);
            lblAsistencia.Name = "lblAsistencia";
            lblAsistencia.Size = new Size(95, 20);
            lblAsistencia.TabIndex = 20;
            lblAsistencia.Text = "ASISTENCIA";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(519, 75);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(167, 27);
            txtCodigo.TabIndex = 19;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCodigo.Location = new Point(446, 82);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(67, 20);
            lblCodigo.TabIndex = 18;
            lblCodigo.Text = "CODIGO";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // txtParcial
            // 
            txtParcial.BorderStyle = BorderStyle.FixedSingle;
            txtParcial.Location = new Point(366, 146);
            txtParcial.Name = "txtParcial";
            txtParcial.Size = new Size(94, 27);
            txtParcial.TabIndex = 17;
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.BackColor = Color.Transparent;
            lblParcial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblParcial.Location = new Point(289, 156);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(71, 20);
            lblParcial.TabIndex = 16;
            lblParcial.Text = "PARCIAL";
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.BorderStyle = BorderStyle.FixedSingle;
            txtLaboratorio.Location = new Point(160, 146);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(94, 27);
            txtLaboratorio.TabIndex = 15;
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.BackColor = Color.Transparent;
            lblLaboratorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLaboratorio.Location = new Point(40, 153);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(114, 20);
            lblLaboratorio.TabIndex = 14;
            lblLaboratorio.Text = "LABORATORIO";
            lblLaboratorio.Click += lblLaboratorio_Click;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(133, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 27);
            txtNombre.TabIndex = 13;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(53, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "NOMBRE";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Orange;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.DarkCyan;
            btnActualizar.Location = new Point(205, 248);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(116, 48);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(592, 194);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 23;
            label1.Text = "ACTIVO";
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.BackColor = Color.Transparent;
            chbActivo.Location = new Point(668, 197);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(18, 17);
            chbActivo.TabIndex = 24;
            chbActivo.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(391, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 48);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yet R", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Indigo;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(189, 9);
            label2.Name = "label2";
            label2.Size = new Size(361, 30);
            label2.TabIndex = 26;
            label2.Text = "ACTUALIZAR ESTUDIANTE";
            // 
            // frmRegistrarNotaCmd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(755, 308);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(chbActivo);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
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
            Name = "frmRegistrarNotaCmd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Actualizar Estudiante";
            Load += frmRegistrarNotaCmd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAsistencia;
        private Label lblAsistencia;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtParcial;
        private Label lblParcial;
        private TextBox txtLaboratorio;
        private Label lblLaboratorio;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnActualizar;
        private Label label1;
        private CheckBox chbActivo;
        private Button btnCancelar;
        private Label label2;
    }
}