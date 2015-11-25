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
    public partial class Buscar : Form
    {
        public Buscar(List<Cliente> clientes)
        {
            InitializeComponent();
            mClientes = clientes;
        }

        private Cliente BuscaPorId(int id)
        {
            foreach (var clienteIx in mClientes)
            {
                if (clienteIx.Id == id)
                {
                    return clienteIx;
                }
            }
            return null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            var cliente = BuscaPorId(SelectedId);
            if (cliente == null)
            {
                return;
            }
            mClientes.Remove(cliente);
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            string[] columnsTitles = { "ID", "Nombre", "RFC", "Dirección",
                                       "Estado", "Municipio", "Teléfono",
                                       "Nombre del encargado" };
            int size = columnsTitles.Length;
            dataGridView1.ColumnCount = size;
            for (int ix = 0; ix < size; ++ix)
            {
                dataGridView1.Columns[ix].Name = columnsTitles[ix];
            }
            int count = mClientes.Count();
            for (int ix = 0; ix < count; ++ix)
            {
                dataGridView1.Rows.Add(mClientes[ix].ConvertToArrayString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            SelectedId = id;
            foreach (var ix in mClientes)
            {
                if (ix.Id == id)
                {
                    fotoPictureBox.Image = ix.FotoEncargado;
                    fotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    return;
                }
            }
        }

        private int SelectedId;
        private List<Cliente> mClientes;
    }
}
