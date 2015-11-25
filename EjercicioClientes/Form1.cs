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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mClientes = new List<Cliente>();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var d = new Registrar(mClientes);
            d.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var d = new Buscar(mClientes);
            d.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            mClientes.Add(new Cliente(1, "Carlos Duarte", "CEDO", "Esperanza", "Sonora", "Hermosillo", "6623382297", "Pedro López", Image.FromFile(@"C:\Users\cedo\Documents\Descargas\User.png")));
            mClientes.Add(new Cliente(2, "Ana Duarte", "ANAD", "Esperanza", "Sonora", "Hermosillo", "6623382298", "Pedro López", Image.FromFile(@"C:\Users\cedo\Documents\Descargas\User.png")));
            mClientes.Add(new Cliente(3, "Pedro Duarte", "PEDRD", "Esperanza", "Sonora", "Hermosillo", "6623382299", "Pedro López", Image.FromFile(@"C:\Users\cedo\Documents\Descargas\User.png")));
            mClientes.Add(new Cliente(4, "Luis Duarte", "LUISD", "Esperanza", "Sonora", "Hermosillo", "6623382277", "Pedro López", Image.FromFile(@"C:\Users\cedo\Documents\Descargas\User.png")));
            mClientes.Add(new Cliente(5, "Erick Duarte", "ERICKD", "Esperanza", "Sonora", "Hermosillo", "6623382278", "Pedro López", Image.FromFile(@"C:\Users\cedo\Documents\Descargas\User.png")));
        }

        private List<Cliente> mClientes;
    }
}
