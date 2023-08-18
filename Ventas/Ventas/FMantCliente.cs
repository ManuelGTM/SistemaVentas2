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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Ventas
{
    public partial class FMantCliente : Form
    {
        public static int vidVentas = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "";
        public string mensaje = "";
        CNCliente objCliente = new CNCliente();
        public FMantCliente()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Boton Buscar
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
            //MostrarDatos();
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

        private void FMantCliente_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidVentas = 0;
            //MostrarDatos();
            tbBuscar.Focus();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
          /*  try
            {
                string Texto_Html = Ventas.Properties.Resources.PlantillaCliente.ToString();
                string filas = string.Empty;
                foreach (DataGridViewRow row in DGVDatos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["id_cliente"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["nombre"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["apellido"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["telefono"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["ciudad"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["pais"].Value.ToString() + "</td>";
                    filas += "</tr>";

                }

                Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.ToString("dd/mm/yyyy"));
                Texto_Html = Texto_Html.Replace("@filas", filas);

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteCliente{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy"));
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
            }*/
        }

        private void BtnUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)
            {
                indice = DGVDatos.Rows.Count - 1;
                DGVDatos.CurrentCell = DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        public void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (objCliente.ObtenerCliente(valorparametro) != null)
            {
                DGVDatos.DataSource = objCliente.ObtenerCliente(valorparametro);
                DGVDatos.Columns["id_cliente"].Width = 80;  // id_pedido
                DGVDatos.Columns["nombre"].Width = 150; // fecha_pedido
                DGVDatos.Columns["apellido"].Width = 150; // id_cliente
                DGVDatos.Columns["telefono"].Width = 150; // id_empleado
                DGVDatos.Columns["ciudad"].Width = 150; // observacion
                DGVDatos.Columns["pais"].Width = 150; // pais
                DGVDatos.Columns["Estado"].Width = 80;  // Estado
            }
            else
            {
                MessageBox.Show("No se retorno ningun valor!");
            }
            DGVDatos.Refresh();
            LBcantVentas.Text = Convert.ToString(DGVDatos.RowCount);
            if (DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningun valor que mostrar!");
            }


        }



    }
}
