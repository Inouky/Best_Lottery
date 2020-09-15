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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnVentas.Height;
            Sidepanel.Top = btnVentas.Top;
            frmVentas frm = new frmVentas();
            frm.Show();
        }

        private void btnLoterias_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnLoterias.Height;
            Sidepanel.Top = btnLoterias.Top;
        }

        private void btnSorteos_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnSorteos.Height;
            Sidepanel.Top = btnSorteos.Top;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = btnUsuarios.Height;
            Sidepanel.Top = btnUsuarios.Top;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
