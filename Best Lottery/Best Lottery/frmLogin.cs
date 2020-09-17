using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Lottery
{
    public partial class frmLogin : Form
    {
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
    }
    
}
