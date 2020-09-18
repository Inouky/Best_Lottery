using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Best_Lottery
{
    public class Conexion
    {

        public SqlConnection con = new SqlConnection("Data Source=D19B0211\\SQLEXPRESS;Initial Catalog=Loteria;Integrated Security=True");

        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;


        public void conectar()
        {
            //Utilizamo el try para capturar los errores que puede producir la funcion Open
            try
            { //Abrimos conexión
                con.Open();
                MessageBox.Show("Conectado");
            }
            catch
            {
                MessageBox.Show("No conectado");
            }
            finally
            { //Cerramos la conexión porque cada vez que la abrimos debemos cerrarla para ejecutar una acción
                con.Close();
            }
        }
        public void consulta(string sql, string tabla)
        {

            ds.Tables.Clear(); //Para limpiar el data set
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public bool insertar(string sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            if (i > 0) // Para validar que la sentencia sql se ejecuta correctamente
            {
                con.Close(); //Para que se cierre la conexion
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public bool iniciartrans(List<String> losQuerys) // Esa lista recibirá los datos
        {
            con.Open();
            SqlTransaction trans = con.BeginTransaction(); // Empiezo la transacción

            try
            {
                foreach (string query in losQuerys)
                {
                    new SqlCommand(query, con, trans).ExecuteNonQuery();
                }
                trans.Commit(); // Detengo la transacción
                con.Close();
                return true;

            }
            catch (SqlException fail)
            {
                trans.Rollback();       // En caso de que un query se haya hecho mal, el rollback me devuelve todo para atras.
                con.Close();
                return false;
            }
        }

    }
}
