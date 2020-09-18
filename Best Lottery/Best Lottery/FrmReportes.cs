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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        Conexion con = new Conexion();

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string reportQuery = "SELECT fecha AS Fecha, tipo_jugada AS 'Tipo de jugada', tipo_loteria AS 'Tipo de loteria', numeros AS Numeros, monto AS Valor FROM Jugadas WHERE (fecha BETWEEN '" + dtpReportes.Value.ToString("yyyy/MM/dd") + "' AND '" + dtpReportes2.Value.ToString("yyyy/MM/dd") + "')";
            if (cmbLoteria.Text != "Todos")
            {
                reportQuery += " AND tipo_loteria ='" + cmbLoteria.Text + "'";
            }
            if (cmbTipoJugada.Text != "Todos")
            {
                reportQuery += " AND tipo_jugada ='" + cmbTipoJugada.Text + "'";
            }

            con.consulta(string.Format(reportQuery, dtpReportes.Value.ToString("yyyy/MM/dd"), dtpReportes2.Value.ToString("yyyy/MM/dd")), "Jugadas");
            dgvReportes.DataSource = con.ds.Tables[0];

        }
    }
}
