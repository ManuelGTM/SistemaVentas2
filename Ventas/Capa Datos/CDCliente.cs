using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Reflection.Emit;

namespace CapaDatos
{
    public class CDCliente
    {
        //Atributos de Cliente

        private int Id_Cliente;
        private string Nombre;
        private string Apellido;
        private string Telefono;
        private string Ciudad;
        private string Pais;
        private string Estado;
        public CDCliente()
        {
        }

        public CDCliente(int Id_Cliente, string Nombre, string Apellido, string Telefono,  string Cuidad, string Pais, string estado)
        {

            this.Id_Cliente = Id_Cliente;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Telefono = Telefono;
            this.Ciudad = Cuidad;
            this.Pais = Pais;
            Estado = estado;
        }

        // getters y setters
        public int _Id_Cliente { get => Id_Cliente; set => Id_Cliente = value; }
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public string _Apellido { get => Apellido; set => Apellido = value; }
        public string _Telefono { get => Telefono; set => Telefono = value; }
        public string _Ciudad { get => Ciudad; set => Ciudad = value; }
        public string _Pais { get => Pais; set => Pais = value; }
        public string _Estado { get => Estado; set => Estado = value; }



        public string InsertarCliente(CDCliente objCliente)
        {

            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {

                sqlCon.ConnectionString = Sistema_Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;

                micomando.Parameters.AddWithValue("@pid_cliente", objCliente._Id_Cliente);
                micomando.Parameters.AddWithValue("@pnombre", objCliente._Nombre);
                micomando.Parameters.AddWithValue("@papellido", objCliente._Apellido);
                micomando.Parameters.AddWithValue("@ptelefono", objCliente._Telefono);
                micomando.Parameters.AddWithValue("@pciudad", objCliente._Ciudad);
                micomando.Parameters.AddWithValue("@ppais", objCliente._Pais);
                micomando.Parameters.AddWithValue("@pEstado", objCliente._Estado);         

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Insercion de datos completada correctamente"
                                                             : "No se pudo insertar correctamente los nuevos datos";

            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return mensaje;
        }

        public string ActualizarCliente(CDCliente objCliente)
        {

            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {

                sqlCon.ConnectionString = Sistema_Conexion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;


                micomando.Parameters.AddWithValue("@pid_cliente", objCliente._Id_Cliente);
                micomando.Parameters.AddWithValue("@pnombre", objCliente._Nombre);
                micomando.Parameters.AddWithValue("@papellido", objCliente._Apellido);
                micomando.Parameters.AddWithValue("@ptelefono", objCliente._Telefono);
                micomando.Parameters.AddWithValue("@pciudad", objCliente._Ciudad);
                micomando.Parameters.AddWithValue("@ppais", objCliente._Pais);
                micomando.Parameters.AddWithValue("@pEstado", objCliente._Estado);

                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente"
                                                             : "No se pudo actualizar correctamente los nuevos datos";

            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }


            return mensaje;
        }


        public DataTable DataTableCliente(string miparametro)
        {
            DataTable dt = new DataTable(); // Creacion de la tabla que muestra el carg0
            SqlDataReader leerDatos; //Creacion del data Reader

            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establece un comando
                sqlCmd.Connection = new Sistema_Conexion().dbconexion;//Conexion que usara el comando
                sqlCmd.Connection.Open();// Abrir la base de datos
                sqlCmd.CommandText = "ClienteConsultar"; //Nombr3 de proc. Almacenado
                sqlCmd.CommandType = CommandType.StoredProcedure; // Se trata de un Proc. Almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); // Se pasa el valor a buscar 
                leerDatos = sqlCmd.ExecuteReader(); // Lenamos el data reader con los datos resultantes
                dt.Load(leerDatos); // Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); // Se cierra la conexion
            }
            catch (Exception )
            {
                dt = null; //si ocurre un erro se anula el DataTable
            }


            return dt;
        }




    }
}
