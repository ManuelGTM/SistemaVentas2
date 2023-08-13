using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;

namespace Capa_Datos
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class DashBoard
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductList { get; private set; } 
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List <RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get ; set; }
        
        public DashBoard()
        {

        }

        private void GetNumberItems()
        {
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Sistema_Conexion.miconexion;
                SqlCommand micomando = new SqlCommand();
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.CommandText = "select count(id_cliente) as CantCliente from Cliente";
                NumCustomers = (int) micomando.ExecuteScalar();


            }catch(Exception e)
            {
                Console.WriteLine("error" + e.Message);

            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            GetNumberItems();
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if(startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

              //  GetNumberItems();
                Console.WriteLine("Refreshed data : {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }

    }
}
