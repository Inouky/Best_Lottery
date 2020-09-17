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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnVentas.Height;
            Sidepanel.Top = btnVentas.Top;
            Sidepanel.Visible = true;
            frmVentas frm = new frmVentas();
            frm.Show();
            btnVentas.Enabled = false;
        }

        private void btnLoterias_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnLoterias.Height;
            Sidepanel.Top = btnLoterias.Top;
            Sidepanel.Visible = true;
        }

        private void btnSorteos_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnSorteos.Height;
            Sidepanel.Top = btnSorteos.Top;
            Sidepanel.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnUsuarios.Height;
            Sidepanel.Top = btnUsuarios.Top;
            Sidepanel.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
