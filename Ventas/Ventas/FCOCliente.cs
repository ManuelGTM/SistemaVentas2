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
    public partial class FCOCliente : Form
    {
        public static int vidPedido = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "";
        public string mensaje = "";
        CNCliente objCliente = new CNCliente();

        public FCOCliente()
        {
            InitializeComponent();
        }

        private void FCOCliente_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidCliente = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1)
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BtnPrimero_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice = indice - 1;
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void FCOCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

           /* if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                    "Mensaje de SIGEMP",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (objCliente.ObtenerCliente(valorparametro) != null)
            {
                DGVDatos.DataSource = objCliente.ObtenerCliente(valorparametro);
                DGVDatos.Columns[0].Width = 80;  // id_pedido
                DGVDatos.Columns[1].Width = 150; // fecha_pedido
                DGVDatos.Columns[2].Width = 150; // id_cliente
                DGVDatos.Columns[3].Width = 150; // id_empleado
                DGVDatos.Columns[4].Width = 150; // observacion
                DGVDatos.Columns[5].Width = 150; // pais
                DGVDatos.Columns[6].Width = 80;  // Estado
            }
            else
            {
                MessageBox.Show("No se retorno ningun valor!");
            }
            DGVDatos.Refresh();
            LBcantClientes.Text = Convert.ToString(DGVDatos.RowCount);
            if (DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningun valor que mostrar!");
            }


        }
    }
}
