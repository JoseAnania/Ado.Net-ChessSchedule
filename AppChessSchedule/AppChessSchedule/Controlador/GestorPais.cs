using AppChessSchedule.Modelo;
using AppChessSchedule.Vista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChessSchedule.Controlador
{
    class GestorPais
    {
        GestorConexion gc = new GestorConexion();
        private SqlCommand comando;
        private SqlDataReader dr;
        public void AgregarPais(Pais nuevoPais)
        {
            try
            {
                gc.AbrirConexion();
                comando = new SqlCommand("SP_InsertarPais", gc.conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@nombre", nuevoPais.nombre));
                comando.ExecuteNonQuery();
                gc.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el País" + ex.ToString());
                throw;
            }
        }
        public List<Pais> ListarPais()
        {
            List<Pais> lista = new List<Pais>();
            try
            {
                gc.AbrirConexion();
                comando = new SqlCommand("SELECT * FROM V_ConsultaPais", gc.conexion);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    int idPais = Convert.ToInt32(dr.GetInt32(0));
                    string nombre = dr.GetString(1);
                    Pais p = new Pais(idPais, nombre);
                    lista.Add(p);
                }
                gc.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede mostrar la lista" + ex.ToString());
                throw;
            }
            return lista;
        }
    }
}
