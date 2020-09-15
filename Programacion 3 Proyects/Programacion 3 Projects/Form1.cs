using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3_Projects
{
    public partial class Form1 : Form
    {
        ClsConexion c = new ClsConexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.insertar(textBox1.Text);
            MessageBox.Show("La descripción se inserto de manera correcta.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tareaDataSet.Historial' table. You can move, or remove it, as needed.
            this.historialTableAdapter.Fill(this.tareaDataSet.Historial);
            // TODO: This line of code loads data into the 'tareaDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.tareaDataSet.Producto);
            ClsConexion c = new ClsConexion();

 


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
