using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChessSchedule.Vista
{
    class GestorConexion
    {
        public SqlConnection conexion;
        public void AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS01;Initial Catalog=ChessSchedule;User ID=sa;Password=giandjoe");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la BD" + ex.ToString());

                throw;
            }
        }
        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cerrar la conexión a la BD" + ex.ToString());

                throw;
            }
        }
    }
}
