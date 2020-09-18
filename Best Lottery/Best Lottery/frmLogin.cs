using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Best_Lottery
{
    public partial class frmLogin : Form
    {
        Conexion con = new Conexion();
        frmMain menu = new frmMain();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region PlaceHolders
        private void txtLoginUsuario_Enter(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "USUARIO")
            {
                txtLoginUsuario.Text = "";
                txtLoginUsuario.ForeColor = Color.White;
            }
        }

        private void txtLoginUsuario_Leave(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "")
            {
                txtLoginUsuario.Text = "USUARIO";
                txtLoginUsuario.ForeColor = Color.DimGray;
            }

        }

        private void txtLoginPassword_Enter(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "CONTRASEÑA")
            {
                txtLoginPassword.Text = "";
                txtLoginPassword.ForeColor = Color.White;
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "")
            {
                txtLoginPassword.Text = "CONTRASEÑA";
                txtLoginPassword.ForeColor = Color.DimGray;
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            #endregion
        }

        private void btnLoginAcceder_Click(object sender, EventArgs e)
        {
            entrar();
        }
        public void entrar()
        {
            // aqui tenemos la conexion de la base de datos con el programa para que podamos ver los campos que ya estan en nuestra base de datos
            con.con.Open();

            SqlCommand cmd = new SqlCommand("SELECT nombre,contrasena FROM Usuarios WHERE nombre = '" + txtLoginUsuario.Text + "' AND contrasena='" + txtLoginPassword.Text + "'", con.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                this.Visible = false;
                menu.Visible = true;
                con.con.Close();

            }
            else
            {
                MessageBox.Show("Datos erroneos");
                con.con.Close();
            }
        }

        private void btnLoginAcceder_Click_1(object sender, EventArgs e)
        {
            entrar();
        }
    }
}
