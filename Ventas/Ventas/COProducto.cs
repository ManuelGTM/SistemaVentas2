using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas;

namespace Control_Ventas
{
    public partial class COProducto : Form
    {
        public static int vidProducto = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "";
        public string mensaje = "";
        CNProducto objProducto = new CNProducto();
        public COProducto()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void COProducto_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidProducto = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else
            {
                vtieneparametro = 0;
                valorparametro = "";
            }
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice = indice - 1;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }


        public void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (objProducto.ObtenerProducto(valorparametro) != null)
            {
                DGVDatos.DataSource = objProducto.ObtenerProducto(valorparametro);
                DGVDatos.Columns[0].Width = 80;  // id_pedido
                DGVDatos.Columns[1].Width = 150; // fecha_pedido
                DGVDatos.Columns[2].Width = 150; // id_cliente
                DGVDatos.Columns[3].Width = 150; // id_empleado
                DGVDatos.Columns[4].Width = 150; // observacion
                DGVDatos.Columns[5].Width = 80; // pais
            }
            else
            {
                MessageBox.Show("No se retorno ningun valor!");
            }
            DGVDatos.Refresh();
            LCantProducto.Text = Convert.ToString(DGVDatos.RowCount);
            if (DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningun valor que mostrar!");
            }


        }



    }
}
