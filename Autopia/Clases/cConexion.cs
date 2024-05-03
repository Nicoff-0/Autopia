using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Autopia.Clases
{
    class cConexion
    {

         static private string CadenaConexion = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\MSI\\Documents\\Autopia.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

       //Definir una variablep para cargar la base de datos
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        //Metodo para abrir la base de datos

        public SqlConnection AbrirConexion() 
        {
            if (Conexion.State==ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        //Metodo para cerrar la base de datos

        public SqlConnection CerrarConexion()
        { 
            if(Conexion.State==ConnectionState.Open)
                Conexion.Close();
        
        return Conexion;
        }


    }
}
