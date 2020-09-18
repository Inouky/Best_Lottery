using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Best_Lottery
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            
        }


        public void gridupdate() // Metodo para actualizar el datagrid
        {
            string gridquery = string.Format("SELECT id_jugadaTemp AS PR, tipo_loteria AS Loteria, tipo_jugada AS Tipo, numeros AS Numeros, monto AS Valor FROM JugadasTemporal");
            con.consulta(gridquery, "JugadasTemporal");
            dgvVentas.DataSource = con.ds.Tables[0];
        }

        Conexion con = new Conexion();

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  // Para seleccionar las celdas del datagridview
        {
            if (dgvVentas.SelectedCells.Count > 0)
            {
                int selectedIndex = dgvVentas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvVentas.Rows[selectedIndex];

                txtID.Text = selectedRow.Cells[0].Value.ToString();
                cmbLoteria.Text = selectedRow.Cells[1].Value.ToString();
                cmbTipo.Text = selectedRow.Cells[2].Value.ToString();
                txtNumero.Text = selectedRow.Cells[3].Value.ToString();
                txtValor.Text = selectedRow.Cells[4].Value.ToString();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbLoteria.Text == "" || cmbTipo.Text == "" || txtNumero.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("No deje campos vacíos.");
                return;
            }

            string QuerySQL;

            if (txtID.Text.Length > 0) // Modificando lineas
            {
                QuerySQL = string.Format("UPDATE JugadasTemporal SET tipo_loteria ='{0}', tipo_jugada ='{1}', numeros ='{2}', monto ='{3}' WHERE id_jugadaTemp ='{4}'", cmbLoteria.Text, cmbTipo.Text, txtNumero.Text, txtValor.Text, txtID.Text);
                if (con.insertar(QuerySQL))
                {
                    MessageBox.Show("Se ha modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error al tratar de modificar");
                }

            }
            else
            {
                QuerySQL = string.Format("INSERT INTO JugadasTemporal(tipo_loteria,tipo_jugada,numeros,monto) VALUES ('{0}','{1}','{2}','{3}')", cmbLoteria.Text, cmbTipo.Text, txtNumero.Text, txtValor.Text);
                if (con.insertar(QuerySQL))
                {
                    MessageBox.Show("Se ha guardado correctamente");
                }

                else
                {
                    MessageBox.Show("No se ha podido guardar correctamente");

                }
            }

            gridupdate();


            // Reset de los txt y cmb valores

            txtID.Clear();
            cmbLoteria.ResetText();
            cmbTipo.ResetText();
            txtNumero.Clear();
            txtValor.Clear();

            // Suma de Valores en el Txt

            int sum = 0;
            for (int i=0; i < dgvVentas.Rows.Count;++i ) // Sumando
            {
                sum += Convert.ToInt32(dgvVentas.Rows[i].Cells[4].Value);  // Seleccionando las celdas

            }

            txtMonto.Text = ("$") + sum.ToString(); // Mostrando la suma en el txt

        }


        private void btnFinalizar_Click(object sender, EventArgs e) // Pasar los datos de la tabla JugadasTemporal a la tabla Jugadas
        {

            string QuerySQLFinal; 

            QuerySQLFinal = string.Format("INSERT INTO Jugadas(tipo_loteria,tipo_jugada,numeros,monto) SELECT tipo_loteria, tipo_jugada, numeros, monto FROM JugadasTemporal");
            con.consulta(QuerySQLFinal, "Jugadas");

            MessageBox.Show("Se ha guardado correctamente");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            FrmReportes frm = new FrmReportes();
            frm.Show();
            btnImprimir.Enabled = false;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
