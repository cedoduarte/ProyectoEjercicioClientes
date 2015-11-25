using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClientes
{
    public partial class Registrar : Form
    {
        public Registrar(List<Cliente> clientes)
        {
            InitializeComponent();
            mClientes = clientes;
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            d.Filter = "All files (*.*)|*.*|Imagen PNG|*.png|Imagen JPG|*.jpg";
            d.Title = "Abrir imagen";
            if (d.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var nombreArchivo = d.FileName;
            if (nombreArchivo.Length == 0)
            {
                return;
            }
            pictureBoxDelEncargado.Image = Image.FromFile(nombreArchivo);
            pictureBoxDelEncargado.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            string rfc = txtRFC.Text;
            string direccion = txtDireccion.Text;
            string estado = txtEstado.Text;
            string municipio = txtMunicipio.Text;
            string telefono = txtTelefono.Text;
            string nombreEncargado = txtNombreDelEncargado.Text;
            Image fotoEncargado = pictureBoxDelEncargado.Image;
            mClientes.Add(new Cliente(id, nombre, rfc, direccion, estado, 
                municipio, telefono, nombreEncargado, fotoEncargado));
            MessageBox.Show("Correcto!!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<Cliente> mClientes;
    }
}
