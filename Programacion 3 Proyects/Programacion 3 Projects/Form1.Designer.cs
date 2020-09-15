namespace Programacion_3_Projects
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tareaDataSet1 = new Programacion_3_Projects.TareaDataSet1();
            this.tareaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tareaDataSet = new Programacion_3_Projects.TareaDataSet();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Programacion_3_Projects.TareaDataSetTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new Programacion_3_Projects.TareaDataSetTableAdapters.TableAdapterManager();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.historialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialTableAdapter = new Programacion_3_Projects.TareaDataSetTableAdapters.HistorialTableAdapter();
            this.historialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tareaDataSet1
            // 
            this.tareaDataSet1.DataSetName = "TareaDataSet1";
            this.tareaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tareaDataSet1BindingSource
            // 
            this.tareaDataSet1BindingSource.DataSource = this.tareaDataSet1;
            this.tareaDataSet1BindingSource.Position = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tareaDataSet
            // 
            this.tareaDataSet.DataSetName = "TareaDataSet";
            this.tareaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.tareaDataSet;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlmacenTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExistenciaTableAdapter = null;
            this.tableAdapterManager.HistorialTableAdapter = null;
            this.tableAdapterManager.IDTableAdapter = null;
            this.tableAdapterManager.MundoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.test_ClienteTableAdapter = null;
            this.tableAdapterManager.test_FacturaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Programacion_3_Projects.TareaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(776, 103);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.RowHeadersWidth = 51;
            this.productoDataGridView.RowTemplate.Height = 24;
            this.productoDataGridView.Size = new System.Drawing.Size(353, 161);
            this.productoDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.tareaDataSet;
            // 
            // productoComboBox
            // 
            this.productoComboBox.DataSource = this.productoBindingSource1;
            this.productoComboBox.DisplayMember = "descripcion";
            this.productoComboBox.FormattingEnabled = true;
            this.productoComboBox.Location = new System.Drawing.Point(332, 578);
            this.productoComboBox.Name = "productoComboBox";
            this.productoComboBox.Size = new System.Drawing.Size(300, 24);
            this.productoComboBox.TabIndex = 6;
            this.productoComboBox.ValueMember = "id_Producto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // historialBindingSource
            // 
            this.historialBindingSource.DataMember = "Historial";
            this.historialBindingSource.DataSource = this.tareaDataSet;
            // 
            // historialTableAdapter
            // 
            this.historialTableAdapter.ClearBeforeFill = true;
            // 
            // historialDataGridView
            // 
            this.historialDataGridView.AutoGenerateColumns = false;
            this.historialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.historialDataGridView.DataSource = this.historialBindingSource;
            this.historialDataGridView.Location = new System.Drawing.Point(61, 109);
            this.historialDataGridView.Name = "historialDataGridView";
            this.historialDataGridView.RowHeadersWidth = 51;
            this.historialDataGridView.RowTemplate.Height = 24;
            this.historialDataGridView.Size = new System.Drawing.Size(684, 181);
            this.historialDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_historial";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_historial";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserta producto, guarda registro de usuario, producto, fecha y hora.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 313);
            this.Controls.Add(this.historialDataGridView);
            this.Controls.Add(this.productoComboBox);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Francis Castro 201900074";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tareaDataSet1BindingSource;
        private TareaDataSet1 tareaDataSet1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private TareaDataSet tareaDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private TareaDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private TareaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.ComboBox productoComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource historialBindingSource;
        private TareaDataSetTableAdapters.HistorialTableAdapter historialTableAdapter;
        private System.Windows.Forms.DataGridView historialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
    }
}