using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Ventas
{
    public partial class FDash : Form
    {
        CNProducto objProducto = new CNProducto();
        public string parametro = "";

        public FDash()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FDash_Load(object sender, EventArgs e)
        {

        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }
        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void MostrarDatos()
        {

            if(objProducto.ObtenerProducto(parametro) != null)
            {
                DGVDatos.DataSource = objProducto.ObtenerProducto(parametro);
                //DGVDatos.Columns["nombreProducto"].Width = 120;
                //DGVDatos.Columns["existencia"].Width = 120;
            }
            else
            {
                MessageBox.Show("No se retorno ningun valor!");

            }
            DGVDatos.Refresh();
            lblNumProducts.Text = DGVDatos.RowCount.ToString();
            
            if(DGVDatos.RowCount <= 0)
            {
                MessageBox.Show("Ningun Valor devuelto");
            }

        }


        }
    }
