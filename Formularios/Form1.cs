using PARCIAL_2.Clases;
using PARCIAL_2.UoW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PARCIAL_2.Formularios
{
    //AUTOEVALUACION: 8
    //William Ismael Zavala Alvarenga
    public partial class frmRegistrarNota : Form
    {
        //Conexion
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
        public frmRegistrarNota()
        {
            InitializeComponent();
        }

        //Variable global, sirve para obtener el id del usuario seleccionado
        private int usuarioSeleccionadoId = 0;

        //Metodo para cargar a los alumnos
        private void CargarAlumno()
        {
            using (var uow = new UnitOfWork(_connectionString))
            {
                var lista = uow.Alumno.GetByEstado(true).ToList();
                dgvRegistro.DataSource = lista;
                dgvRegistro.Columns["Id"].Visible = false;
                dgvRegistro.Refresh();
            }

            // Adaptar el contenido de las columnas
            dgvRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            txtLaboratorio.Clear();
            txtParcial.Clear();
            txtAsistencia.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumno();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtLaboratorio.Text) || string.IsNullOrEmpty(txtParcial.Text) || string.IsNullOrEmpty(txtAsistencia.Text))
            {
                MessageBox.Show("Porfavor complete todos los campos. ");
                return;
            }

            //Comvertimos a mayusculas
            string Nombre = txtNombre.Text.Trim().ToUpper();
            string Codigo = txtCodigo.Text.Trim().ToUpper();

            // validamos el rango de las notas (0 - 10)
            if (!decimal.TryParse(txtLaboratorio.Text, out decimal laboratorio) ||
                !decimal.TryParse(txtParcial.Text, out decimal parcial) ||
                !decimal.TryParse(txtAsistencia.Text, out decimal asistencia))
            {
                MessageBox.Show("Notas inválidas. ");
                return;
            }

            if (laboratorio < 0 || laboratorio > 10 || parcial < 0 || parcial > 10 || asistencia < 0 || asistencia > 10)
            {
                MessageBox.Show("Las notas deben ser entre 0.00 y 10.00");
                return;
            }

            //Nota final
            decimal notaFinal = Math.Round((laboratorio * 0.5m) + (parcial * 0.4m) + (asistencia * 0.1m), 2);

            //objeto alumno
            var alumno = new Alumno
            {
                Nombre = txtNombre.Text.Trim(),
                Codigo = txtCodigo.Text.Trim(),
                Laboratorio = laboratorio,
                Parcial = parcial,
                Asistencia = asistencia,
                NotaFinal = notaFinal,
                Activo = true
            };

            using (var uow = new UnitOfWork(_connectionString))
            {
                uow.Alumno.Insert(alumno);
                uow.Commit();

                MessageBox.Show("Alumno guardado correctamente. ");

                LimpiarCampos();
                CargarAlumno();
            }
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var alumno = (Alumno)dgvRegistro.Rows[e.RowIndex].DataBoundItem;

                using (var formEditar = new frmRegistrarNotaCmd(alumno.Id, _connectionString))
                {
                    var result = formEditar.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        CargarAlumno();//si hubo cambios se recarga el grid
                    }
                }
            }
        }

        private void dgvRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionadoId == 0)
            {
                MessageBox.Show("Seleccione el usuario para eliminar. ");
                return;
            }

            var confirmar = MessageBox.Show("¿Esta seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }
    }
}
