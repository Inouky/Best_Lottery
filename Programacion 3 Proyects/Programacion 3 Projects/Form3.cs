using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_3_Projects
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void mundoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mundoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.paisesDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tareaDataSet.Almacen' table. You can move, or remove it, as needed.
            this.almacenTableAdapter.Fill(this.tareaDataSet.Almacen);
            // TODO: This line of code loads data into the 'paisesDataSet.Mundo' table. You can move, or remove it, as needed.
            this.mundoTableAdapter.Fill(this.paisesDataSet.Mundo);

        }
    }
}
