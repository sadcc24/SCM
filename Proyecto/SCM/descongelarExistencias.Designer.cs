namespace SCM
{
    partial class descongelarExistencias
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
            this.btnDescongelar = new System.Windows.Forms.Button();
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBodega = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvLíneas = new System.Windows.Forms.DataGridView();
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.gbxProductos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLíneas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescongelar
            // 
            this.btnDescongelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescongelar.Location = new System.Drawing.Point(298, 165);
            this.btnDescongelar.Name = "btnDescongelar";
            this.btnDescongelar.Size = new System.Drawing.Size(105, 25);
            this.btnDescongelar.TabIndex = 120;
            this.btnDescongelar.Text = "Descongelar";
            this.btnDescongelar.UseVisualStyleBackColor = true;
            this.btnDescongelar.Click += new System.EventHandler(this.btnDescongelar_Click);
            // 
            // gbxProductos
            // 
            this.gbxProductos.Controls.Add(this.lblHasta);
            this.gbxProductos.Controls.Add(this.txtHasta);
            this.gbxProductos.Controls.Add(this.lblDesde);
            this.gbxProductos.Controls.Add(this.txtDesde);
            this.gbxProductos.Location = new System.Drawing.Point(12, 12);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(258, 100);
            this.gbxProductos.TabIndex = 117;
            this.gbxProductos.TabStop = false;
            this.gbxProductos.Text = "Clave de Productos";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(36, 65);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(44, 16);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // txtHasta
            // 
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(86, 62);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(120, 22);
            this.txtHasta.TabIndex = 5;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(31, 30);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(49, 16);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(86, 27);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(120, 22);
            this.txtDesde.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBodega);
            this.groupBox1.Controls.Add(this.cmbBodega);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multibodega";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBodega.Location = new System.Drawing.Point(19, 47);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(57, 16);
            this.lblBodega.TabIndex = 6;
            this.lblBodega.Text = "Bodega";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(85, 44);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(121, 21);
            this.cmbBodega.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbLinea);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 100);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Líneas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Líneas";
            // 
            // cmbLinea
            // 
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(86, 45);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(121, 21);
            this.cmbLinea.TabIndex = 8;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(419, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvLíneas
            // 
            this.dgvLíneas.AllowUserToDeleteRows = false;
            this.dgvLíneas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLíneas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLíneas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLíneas.Location = new System.Drawing.Point(287, 196);
            this.dgvLíneas.Name = "dgvLíneas";
            this.dgvLíneas.ReadOnly = true;
            this.dgvLíneas.Size = new System.Drawing.Size(428, 65);
            this.dgvLíneas.TabIndex = 122;
            this.dgvLíneas.Visible = false;
            // 
            // dgvBodega
            // 
            this.dgvBodega.AllowUserToDeleteRows = false;
            this.dgvBodega.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBodega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodega.Location = new System.Drawing.Point(287, 125);
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.ReadOnly = true;
            this.dgvBodega.Size = new System.Drawing.Size(428, 65);
            this.dgvBodega.TabIndex = 123;
            this.dgvBodega.Visible = false;
            // 
            // descongelarExistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.btnDescongelar);
            this.Controls.Add(this.gbxProductos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvLíneas);
            this.Controls.Add(this.dgvBodega);
            this.Name = "descongelarExistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCM | Descongelar Existencias";
            this.Load += new System.EventHandler(this.descongelarExistencias_Load);
            this.gbxProductos.ResumeLayout(false);
            this.gbxProductos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLíneas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDescongelar;
        private System.Windows.Forms.GroupBox gbxProductos;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvLíneas;
        private System.Windows.Forms.DataGridView dgvBodega;
    }
}