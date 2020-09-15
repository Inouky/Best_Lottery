namespace Programacion_3_Projects
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.paisesDataSet = new Programacion_3_Projects.PaisesDataSet();
            this.mundoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mundoTableAdapter = new Programacion_3_Projects.PaisesDataSetTableAdapters.MundoTableAdapter();
            this.tableAdapterManager = new Programacion_3_Projects.PaisesDataSetTableAdapters.TableAdapterManager();
            this.mundoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mundoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mundoComboBox = new System.Windows.Forms.ComboBox();
            this.tareaDataSet = new Programacion_3_Projects.TareaDataSet();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTableAdapter = new Programacion_3_Projects.TareaDataSetTableAdapters.AlmacenTableAdapter();
            this.tableAdapterManager1 = new Programacion_3_Projects.TareaDataSetTableAdapters.TableAdapterManager();
            this.almacenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mundoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mundoBindingNavigator)).BeginInit();
            this.mundoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(341, 272);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activado";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(458, 272);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Desactivado";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // paisesDataSet
            // 
            this.paisesDataSet.DataSetName = "PaisesDataSet";
            this.paisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mundoBindingSource
            // 
            this.mundoBindingSource.DataMember = "Mundo";
            this.mundoBindingSource.DataSource = this.paisesDataSet;
            // 
            // mundoTableAdapter
            // 
            this.mundoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MundoTableAdapter = this.mundoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Programacion_3_Projects.PaisesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mundoBindingNavigator
            // 
            this.mundoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mundoBindingNavigator.BindingSource = this.mundoBindingSource;
            this.mundoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mundoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mundoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mundoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mundoBindingNavigatorSaveItem});
            this.mundoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mundoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mundoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mundoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mundoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mundoBindingNavigator.Name = "mundoBindingNavigator";
            this.mundoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mundoBindingNavigator.Size = new System.Drawing.Size(625, 31);
            this.mundoBindingNavigator.TabIndex = 3;
            this.mundoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // mundoBindingNavigatorSaveItem
            // 
            this.mundoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mundoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mundoBindingNavigatorSaveItem.Image")));
            this.mundoBindingNavigatorSaveItem.Name = "mundoBindingNavigatorSaveItem";
            this.mundoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.mundoBindingNavigatorSaveItem.Text = "Save Data";
            this.mundoBindingNavigatorSaveItem.Click += new System.EventHandler(this.mundoBindingNavigatorSaveItem_Click);
            // 
            // mundoComboBox
            // 
            this.mundoComboBox.DataSource = this.mundoBindingSource;
            this.mundoComboBox.DisplayMember = "Pais";
            this.mundoComboBox.FormattingEnabled = true;
            this.mundoComboBox.Location = new System.Drawing.Point(12, 269);
            this.mundoComboBox.Name = "mundoComboBox";
            this.mundoComboBox.Size = new System.Drawing.Size(300, 24);
            this.mundoComboBox.TabIndex = 4;
            this.mundoComboBox.ValueMember = "Pais";
            // 
            // tareaDataSet
            // 
            this.tareaDataSet.DataSetName = "TareaDataSet";
            this.tareaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.tareaDataSet;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlmacenTableAdapter = this.almacenTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ExistenciaTableAdapter = null;
            this.tableAdapterManager1.IDTableAdapter = null;
            this.tableAdapterManager1.MundoTableAdapter = null;
            this.tableAdapterManager1.ProductoTableAdapter = null;
            this.tableAdapterManager1.test_ClienteTableAdapter = null;
            this.tableAdapterManager1.test_FacturaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Programacion_3_Projects.TareaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // almacenDataGridView
            // 
            this.almacenDataGridView.AutoGenerateColumns = false;
            this.almacenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.almacenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.almacenDataGridView.DataSource = this.almacenBindingSource;
            this.almacenDataGridView.Location = new System.Drawing.Point(12, 30);
            this.almacenDataGridView.Name = "almacenDataGridView";
            this.almacenDataGridView.RowHeadersWidth = 51;
            this.almacenDataGridView.RowTemplate.Height = 24;
            this.almacenDataGridView.Size = new System.Drawing.Size(553, 220);
            this.almacenDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Almacen";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_Almacen";
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
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "eliminado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "eliminado";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 358);
            this.Controls.Add(this.almacenDataGridView);
            this.Controls.Add(this.mundoComboBox);
            this.Controls.Add(this.mundoBindingNavigator);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mundoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mundoBindingNavigator)).EndInit();
            this.mundoBindingNavigator.ResumeLayout(false);
            this.mundoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tareaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private PaisesDataSet paisesDataSet;
        private System.Windows.Forms.BindingSource mundoBindingSource;
        private PaisesDataSetTableAdapters.MundoTableAdapter mundoTableAdapter;
        private PaisesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mundoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mundoBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox mundoComboBox;
        private TareaDataSet tareaDataSet;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private TareaDataSetTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private TareaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView almacenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}