using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;



    class ClsConexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ClsConexion()
        {
            try
            {
              cn = new SqlConnection("Data Source=INOUKY-PC\\SQLEXPRESS;Initial Catalog=Tarea;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            }
             catch(Exception ex)
            {
                MessageBox.Show("Error! No se pudo conectar a la base de datos"+ex.ToString());
            }
        }
        public string insertar(string descripcion)
        {
            string salida = "Si se incerto";
            try
            {
                cmd = new SqlCommand("Insert into Producto(descripcion) Values('" + descripcion + "')",cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No hubo una conexion " + ex.ToString();
            }
            return salida;
        }
    }

