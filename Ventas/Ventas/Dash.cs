using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Ventas
{
    
    public partial class Dash : Form
    {
        
        private DashBoard model;

        public Dash()
        {
            InitializeComponent();

            LoadData();

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            //btnLast7Days.Select();

            model = new DashBoard();
            LoadData();
        }

        private void LoadData()
        {
            try
            {

            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);

                if (refreshData == true)
                {
                    numCliente.Text = model.NumOrders.ToString();
                    Console.WriteLine("Loaded View :)");
                }
                else
                {
                    Console.WriteLine("View not loaded, same query");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
