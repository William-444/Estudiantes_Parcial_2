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
            SuspendLayout();
            // 
            // txtAsistencia
            // 
            txtAsistencia.BorderStyle = BorderStyle.FixedSingle;
            txtAsistencia.Location = new Point(572, 109);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Size = new Size(125, 27);
            txtAsistencia.TabIndex = 21;
            // 
            // lblAsistencia
            // 
            lblAsistencia.AutoSize = true;
            lblAsistencia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAsistencia.Location = new Point(491, 116);
            lblAsistencia.Name = "lblAsistencia";
            lblAsistencia.Size = new Size(80, 20);
            lblAsistencia.TabIndex = 20;
            lblAsistencia.Text = "Asistencia";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Location = new Point(519, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(178, 27);
            txtCodigo.TabIndex = 19;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCodigo.Location = new Point(440, 37);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 18;
            lblCodigo.Text = "Codigo";
            // 
            // txtParcial
            // 
            txtParcial.BorderStyle = BorderStyle.FixedSingle;
            txtParcial.Location = new Point(347, 109);
            txtParcial.Name = "txtParcial";
            txtParcial.Size = new Size(125, 27);
            txtParcial.TabIndex = 17;
            // 
            // lblParcial
            // 
            lblParcial.AutoSize = true;
            lblParcial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblParcial.Location = new Point(289, 115);
            lblParcial.Name = "lblParcial";
            lblParcial.Size = new Size(55, 20);
            lblParcial.TabIndex = 16;
            lblParcial.Text = "Parcial";
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.BorderStyle = BorderStyle.FixedSingle;
            txtLaboratorio.Location = new Point(133, 109);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(125, 27);
            txtLaboratorio.TabIndex = 15;
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLaboratorio.Location = new Point(40, 112);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(91, 20);
            lblLaboratorio.TabIndex = 14;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(133, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 27);
            txtNombre.TabIndex = 13;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(54, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Orange;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(208, 235);
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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(54, 174);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 23;
            label1.Text = "Activo";
            // 
            // chbActivo
            // 
            chbActivo.AutoSize = true;
            chbActivo.Location = new Point(133, 177);
            chbActivo.Name = "chbActivo";
            chbActivo.Size = new Size(18, 17);
            chbActivo.TabIndex = 24;
            chbActivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(394, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 48);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegistrarNotaCmd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(755, 308);
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
            Text = "Editar Estudiante";
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
    }
}