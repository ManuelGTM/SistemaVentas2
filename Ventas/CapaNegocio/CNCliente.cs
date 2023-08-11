using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using CapaDatos;


namespace CapaNegocio
{
    public class CNCliente
    {
        public static string InsertarCliente(string Nombre, string Apellido, string Telefono, string Cuidad, string Pais, string Estado)
        {
            CDCliente objCliente = new CDCliente();

            objCliente._Nombre = Nombre;
            objCliente._Apellido = Apellido;
            objCliente._Telefono = Telefono;
            objCliente._Ciudad = Cuidad;
            objCliente._Pais = Pais;
            objCliente._Estado = Estado;

            return objCliente.InsertarCliente(objCliente);
        }

        public static string ActualizarCliente(int Id_Cliente, string Nombre, string Apellido, string Telefono, string Cuidad,  string Pais, string Estado)
        {
            CDCliente objCliente = new CDCliente();

            objCliente._Id_Cliente = Id_Cliente;
            objCliente._Nombre = Nombre;
            objCliente._Apellido = Apellido;
            objCliente._Telefono = Telefono;
            objCliente._Ciudad = Cuidad;
            objCliente._Pais = Pais;
            objCliente._Estado = Estado;

            return objCliente.ActualizarCliente(objCliente);
        }

        public DataTable ObtenerCliente(string miparametro)
        {
            CDCliente objCliente = new CDCliente();
            DataTable dt = new DataTable();

            dt = objCliente.DataTableCliente(miparametro);

            return dt;
        }





    }
}
