namespace Best_Lottery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSorteos = new System.Windows.Forms.Button();
            this.btnLoterias = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnSorteos);
            this.panel1.Controls.Add(this.btnLoterias);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 589);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(271, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 168);
            this.panel3.TabIndex = 2;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.Sidepanel.Location = new System.Drawing.Point(4, 57);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(13, 54);
            this.Sidepanel.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(574, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Best_Lottery.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(9, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::Best_Lottery.Properties.Resources.empleados;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogin.Location = new System.Drawing.Point(25, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(210, 54);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Best_Lottery.Properties.Resources.clientes;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(25, 259);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(210, 54);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSorteos
            // 
            this.btnSorteos.FlatAppearance.BorderSize = 0;
            this.btnSorteos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorteos.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteos.ForeColor = System.Drawing.Color.White;
            this.btnSorteos.Image = global::Best_Lottery.Properties.Resources.pagos;
            this.btnSorteos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSorteos.Location = new System.Drawing.Point(25, 187);
            this.btnSorteos.Name = "btnSorteos";
            this.btnSorteos.Size = new System.Drawing.Size(210, 54);
            this.btnSorteos.TabIndex = 5;
            this.btnSorteos.Text = "Sorteos";
            this.btnSorteos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSorteos.UseVisualStyleBackColor = true;
            this.btnSorteos.Click += new System.EventHandler(this.btnSorteos_Click);
            // 
            // btnLoterias
            // 
            this.btnLoterias.FlatAppearance.BorderSize = 0;
            this.btnLoterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoterias.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoterias.ForeColor = System.Drawing.Color.White;
            this.btnLoterias.Image = global::Best_Lottery.Properties.Resources.producto;
            this.btnLoterias.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLoterias.Location = new System.Drawing.Point(22, 115);
            this.btnLoterias.Name = "btnLoterias";
            this.btnLoterias.Size = new System.Drawing.Size(210, 54);
            this.btnLoterias.TabIndex = 4;
            this.btnLoterias.Text = "Loterias";
            this.btnLoterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoterias.UseVisualStyleBackColor = true;
            this.btnLoterias.Click += new System.EventHandler(this.btnLoterias_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = global::Best_Lottery.Properties.Resources.compras_48px;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVentas.Location = new System.Drawing.Point(23, 57);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(210, 54);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Best_Lottery.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(955, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 589);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSorteos;
        private System.Windows.Forms.Button btnLoterias;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

