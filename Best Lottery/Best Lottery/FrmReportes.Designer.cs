namespace Best_Lottery
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.dtpReportes2 = new System.Windows.Forms.DateTimePicker();
            this.dtpReportes = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoJugada = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoteria = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(970, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(970, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Desde";
            // 
            // dgvReportes
            // 
            this.dgvReportes.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(23, 62);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(932, 524);
            this.dgvReportes.TabIndex = 20;
            // 
            // dtpReportes2
            // 
            this.dtpReportes2.Location = new System.Drawing.Point(973, 120);
            this.dtpReportes2.Name = "dtpReportes2";
            this.dtpReportes2.Size = new System.Drawing.Size(200, 20);
            this.dtpReportes2.TabIndex = 19;
            // 
            // dtpReportes
            // 
            this.dtpReportes.Location = new System.Drawing.Point(973, 62);
            this.dtpReportes.Name = "dtpReportes";
            this.dtpReportes.Size = new System.Drawing.Size(200, 20);
            this.dtpReportes.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(977, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo de jugada";
            // 
            // cmbTipoJugada
            // 
            this.cmbTipoJugada.FormattingEnabled = true;
            this.cmbTipoJugada.Items.AddRange(new object[] {
            "Todos",
            "Quiniela",
            "Pale",
            "Tripleta"});
            this.cmbTipoJugada.Location = new System.Drawing.Point(980, 251);
            this.cmbTipoJugada.Name = "cmbTipoJugada";
            this.cmbTipoJugada.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoJugada.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(977, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lotería";
            // 
            // cmbLoteria
            // 
            this.cmbLoteria.FormattingEnabled = true;
            this.cmbLoteria.Items.AddRange(new object[] {
            "Todos",
            "Nacional",
            "Leidsa",
            "Loteka",
            "Real"});
            this.cmbLoteria.Location = new System.Drawing.Point(980, 189);
            this.cmbLoteria.Name = "cmbLoteria";
            this.cmbLoteria.Size = new System.Drawing.Size(121, 21);
            this.cmbLoteria.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(1020, 296);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 49);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 51);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReportes);
            this.Controls.Add(this.dtpReportes2);
            this.Controls.Add(this.dtpReportes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoJugada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLoteria);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.DateTimePicker dtpReportes2;
        private System.Windows.Forms.DateTimePicker dtpReportes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoJugada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoteria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}