using PARCIAL_2.Clases;
using PARCIAL_2.UoW;
using RepoDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PARCIAL_2.Formularios
{
    public partial class frmRegistrarNotaCmd : Form
    {
        private readonly string _connectionString;
        private readonly int _alumnoId;
        private decimal notaFinal;
        private decimal asistencia;
        private decimal parcial;
        private decimal laboratorio;

        public frmRegistrarNotaCmd(int alumnoId, string connectionString)
        {
            InitializeComponent();
            _alumnoId = alumnoId;
            _connectionString = connectionString;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtLaboratorio.Text) || string.IsNullOrEmpty(txtParcial.Text) || string.IsNullOrEmpty(txtAsistencia.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // validamos el rango de las notas (0 - 10)
            if (!decimal.TryParse(txtLaboratorio.Text, out decimal laboratorio) ||
                !decimal.TryParse(txtParcial.Text, out decimal parcial) ||
                !decimal.TryParse(txtAsistencia.Text, out decimal asistencia))
            {
                MessageBox.Show("Notas inválidas.");
                return;
            }

            //Nota final
            decimal notaFinal = Math.Round((laboratorio * 0.5m) + (parcial * 0.4m) + (asistencia * 0.1m), 2);

            var alumno = new Alumno
            {
                Id = _alumnoId,
                Nombre = txtNombre.Text.Trim(),
                Codigo = txtCodigo.Text.Trim(),
                Laboratorio = laboratorio,
                Parcial = parcial,
                Asistencia = asistencia,
                NotaFinal = notaFinal,
                Activo = chbActivo.Checked
            };

            var camposActualizar = new List<Field>
            {
                new("Nombre"),
                new("Codigo"),
                new("Laboratorio"),
                new("Parcial"),
                new("Asistencia"),
                new("NotaFinal")
            };

            using (var uow = new UnitOfWork(_connectionString))
            {
                uow.Alumno.Update(alumno, camposActualizar);
                uow.Commit();
                MessageBox.Show("Alumno actualizado con exito. ");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmRegistrarNotaCmd_Load(object sender, EventArgs e)
        {
            chbActivo.Enabled = false;

            using (var uow = new UnitOfWork(_connectionString))
            {
                var alumno = uow.Alumno.GetById(_alumnoId);

                if (alumno == null)
                {
                    MessageBox.Show("Usuario no encontrado. ");
                    this.Close();
                    return;
                }

                txtNombre.Text = alumno.Nombre;
                txtCodigo.Text = alumno.Codigo;
                txtLaboratorio.Text = alumno.Laboratorio.ToString();
                txtParcial.Text = alumno.Parcial.ToString();
                txtAsistencia.Text = alumno.Asistencia.ToString();
                chbActivo.Checked = alumno.Activo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
