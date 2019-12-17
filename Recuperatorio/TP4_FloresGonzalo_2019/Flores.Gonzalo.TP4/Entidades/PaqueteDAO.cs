using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection("Data Source = GONZALO-PC; Initial Catalog = correo-sp-2017; Integrated Security = True");
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = CommandType.Text;
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }
        /// <summary>
        /// guarda los datos de los paquetes en la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            string query = "INSERT INTO dbo.Paquetes (direccionEntrega, trackingID, alumno) VALUES ('" + p.DireccionEntrega + "', '" + p.TrackingID + "','Gonzalo Flores')";
            
            PaqueteDAO.comando.CommandText = query;
            
            try
            {
                conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
