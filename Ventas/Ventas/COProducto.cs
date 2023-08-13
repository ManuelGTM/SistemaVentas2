using CapaNegocio;
//using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;
using Ventas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string Texto_Html = Ventas.Properties.Resources.ReporteProducto.ToString();
                string filas = string.Empty;
                foreach (DataGridViewRow row in DGVDatos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["idProducto"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["nombreProducto"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["existencia"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["precio"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["nombreMarca"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    
                }

                Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.ToString("dd/mm/yyyy"));
                Texto_Html = Texto_Html.Replace("@filas", filas);

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto_{0}.pdf",DateTime.Now.ToString("ddMMyyyy"));
                saveFile.Filter = "Pdf Files|*.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();


                        using (StringReader sr = new StringReader(Texto_Html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                        MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        public void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (objProducto.ObtenerProducto(valorparametro) != null)
            {
                DGVDatos.DataSource = objProducto.ObtenerProducto(valorparametro);
                DGVDatos.Columns["IdProducto"].Width = 80;  // id_pedido
                DGVDatos.Columns["nombreProducto"].Width = 150; // fecha_pedido
                DGVDatos.Columns["existencia"].Width = 150; // fecha_pedido
                DGVDatos.Columns["precio"].Width = 150; // id_cliente
                DGVDatos.Columns["nombreMarca"].Width = 150; // id_empleado
                DGVDatos.Columns["estado"].Width = 80; // observacion
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
