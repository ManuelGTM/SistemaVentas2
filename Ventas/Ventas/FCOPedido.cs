﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Ventas;

namespace Control_Ventas
{
    public partial class FCOPedido : Form
    {
        
        public static int vidPedido = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = ""; 
        public string mensaje = "";
        CNPedido objPedido = new CNPedido();
        
        public FCOPedido()
        {
            InitializeComponent();
        }

        private void FCOPedido_FormClosing(object sender, FormClosingEventArgs e)
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

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if(DGVDatos.CurrentRow != null)
            {
                indice = DGVDatos.CurrentRow.Index;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Text != String.Empty)
            {
                vtieneparametro = 1;
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else
            {
                vtieneparametro =0;
                valorparametro = "";
            }
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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

            try
            {
                string Texto_Html = Ventas.Properties.Resources.ReportePedido.ToString();
                string filas = string.Empty;
                foreach (DataGridViewRow row in DGVDatos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["id_pedido"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["fecha_pedido"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                    filas += "</tr>";
                }

                Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.ToString("dd/MM/yyyy"));
                Texto_Html = Texto_Html.Replace("@filas", filas);

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReportePedido_{0}.pdf", DateTime.Now.ToString("ddMMyyyy"));
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
     
        private void FCOPedido_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidPedido = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        public void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if(objPedido.ObtenerPedido(valorparametro) != null)
            {
                DGVDatos.DataSource = objPedido.ObtenerPedido(valorparametro);
                DGVDatos.Columns["id_pedido"].Width = 80;  // id_pedido
                DGVDatos.Columns["fecha_pedido"].Width = 200; // fecha_pedido
                DGVDatos.Columns[2].Width = 200; // id_cliente
                DGVDatos.Columns[3].Width = 200; // id_empleado
                DGVDatos.Columns["observacion"].Width = 200; // observacion
                DGVDatos.Columns["Estado"].Width = 80;  // Estado
            }
            else
            {
                MessageBox.Show("No se retorno ningun valor!");
            }
            DGVDatos.Refresh();
            LCantPedido.Text = Convert.ToString(DGVDatos.RowCount);
            if (DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningun valor que mostrar!");
            }
 

        }


    }
}
