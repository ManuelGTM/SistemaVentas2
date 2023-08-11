using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CapaDatos
{
    public class Sistema_Conexion
    {
        public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MT\workbench\repos\MiProyecto\Ventas\Capa Datos\Database1.mdf;Integrated Security=True";
        //public static string miconexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rapto\repos\ventas\Sistema-Ventas\Control_Ventas\CapaDatos\Db1.mdf;Integrated Security=True";
        public SqlConnection dbconexion = new SqlConnection(miconexion);
    }
}
