namespace SCM
{
    partial class ajustarExistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajustarExistencias));
            this.gbxMovimientos = new System.Windows.Forms.GroupBox();
            this.cmbSalida = new System.Windows.Forms.ComboBox();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.btnAjustar = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLineas = new System.Windows.Forms.DataGridView();
            this.dgvBodega = new System.Windows.Forms.DataGridView();
            this.dgvDetalleInventarioFisico = new System.Windows.Forms.DataGridView();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCongelar = new System.Windows.Forms.Button();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.lblBodega = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.gbxMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleInventarioFisico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMovimientos
            // 
            this.gbxMovimientos.Controls.Add(this.cmbSalida);
            this.gbxMovimientos.Controls.Add(this.cmbEntrada);
            this.gbxMovimientos.Controls.Add(this.label17);
            this.gbxMovimientos.Controls.Add(this.label18);
            this.gbxMovimientos.Controls.Add(this.label19);
            this.gbxMovimientos.Controls.Add(this.txtReferencia);
            this.gbxMovimientos.Location = new System.Drawing.Point(12, 265);
            this.gbxMovimientos.Name = "gbxMovimientos";
            this.gbxMovimientos.Size = new System.Drawing.Size(510, 134);
            this.gbxMovimientos.TabIndex = 5;
            this.gbxMovimientos.TabStop = false;
            this.gbxMovimientos.Text = "Movimiento de Inventarios";
            this.gbxMovimientos.Visible = false;
            // 
            // cmbSalida
            // 
            this.cmbSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalida.FormattingEnabled = true;
            this.cmbSalida.Location = new System.Drawing.Point(266, 59);
            this.cmbSalida.Name = "cmbSalida";
            this.cmbSalida.Size = new System.Drawing.Size(150, 21);
            this.cmbSalida.TabIndex = 9;
            // 
            // cmbEntrada
            // 
            this.cmbEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Location = new System.Drawing.Point(266, 26);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(150, 21);
            this.cmbEntrada.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(94, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "Movimiento de Salida";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(94, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 16);
            this.label18.TabIndex = 6;
            this.label18.Text = "Movimiento de Entrada";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(155, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Referencia";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(266, 100);
            this.txtReferencia.MaxLength = 25;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(120, 22);
            this.txtReferencia.TabIndex = 5;
            // 
            // btnAjustar
            // 
            this.btnAjustar.Enabled = false;
            this.btnAjustar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustar.Location = new System.Drawing.Point(181, 420);
            this.btnAjustar.Name = "btnAjustar";
            this.btnAjustar.Size = new System.Drawing.Size(150, 25);
            this.btnAjustar.TabIndex = 132;
            this.btnAjustar.Text = "Ajustar existencias";
            this.btnAjustar.UseVisualStyleBackColor = true;
            this.btnAjustar.Click += new System.EventHandler(this.btnAjustar_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(264, 50);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.Size = new System.Drawing.Size(428, 65);
            this.dgvMarcas.TabIndex = 130;
            this.dgvMarcas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marcas";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(86, 45);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(121, 21);
            this.cmbMarca.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbMarca);
            this.groupBox3.Location = new System.Drawing.Point(264, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 100);
            this.groupBox3.TabIndex = 128;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Marcas";
            // 
            // dgvLineas
            // 
            this.dgvLineas.AllowUserToDeleteRows = false;
            this.dgvLineas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLineas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineas.Location = new System.Drawing.Point(287, 192);
            this.dgvLineas.Name = "dgvLineas";
            this.dgvLineas.ReadOnly = true;
            this.dgvLineas.Size = new System.Drawing.Size(428, 65);
            this.dgvLineas.TabIndex = 126;
            this.dgvLineas.Visible = false;
            // 
            // dgvBodega
            // 
            this.dgvBodega.AllowUserToDeleteRows = false;
            this.dgvBodega.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBodega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBodega.Location = new System.Drawing.Point(287, 121);
            this.dgvBodega.Name = "dgvBodega";
            this.dgvBodega.ReadOnly = true;
            this.dgvBodega.Size = new System.Drawing.Size(428, 65);
            this.dgvBodega.TabIndex = 127;
            this.dgvBodega.Visible = false;
            // 
            // dgvDetalleInventarioFisico
            // 
            this.dgvDetalleInventarioFisico.AllowUserToAddRows = false;
            this.dgvDetalleInventarioFisico.AllowUserToDeleteRows = false;
            this.dgvDetalleInventarioFisico.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDetalleInventarioFisico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleInventarioFisico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleInventarioFisico.Location = new System.Drawing.Point(0, 264);
            this.dgvDetalleInventarioFisico.Name = "dgvDetalleInventarioFisico";
            this.dgvDetalleInventarioFisico.Size = new System.Drawing.Size(534, 134);
            this.dgvDetalleInventarioFisico.TabIndex = 131;
            this.dgvDetalleInventarioFisico.Visible = false;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.AllowUserToAddRows = false;
            this.dgvExistencias.AllowUserToDeleteRows = false;
            this.dgvExistencias.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvExistencias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Location = new System.Drawing.Point(0, 266);
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            this.dgvExistencias.Size = new System.Drawing.Size(534, 134);
            this.dgvExistencias.TabIndex = 129;
            this.dgvExistencias.Visible = false;
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
            // btnCongelar
            // 
            this.btnCongelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongelar.Location = new System.Drawing.Point(186, 226);
            this.btnCongelar.Name = "btnCongelar";
            this.btnCongelar.Size = new System.Drawing.Size(175, 25);
            this.btnCongelar.TabIndex = 124;
            this.btnCongelar.Text = "Seleccionar existencias";
            this.btnCongelar.UseVisualStyleBackColor = true;
            this.btnCongelar.Click += new System.EventHandler(this.btnCongelar_Click);
            // 
            // cmbLinea
            // 
            this.cmbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(86, 45);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(121, 21);
            this.cmbLinea.TabIndex = 8;
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
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(85, 44);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(121, 21);
            this.cmbBodega.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBodega);
            this.groupBox1.Controls.Add(this.cmbBodega);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bodegas";
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
            this.txtHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasta.Location = new System.Drawing.Point(86, 62);
            this.txtHasta.MaxLength = 6;
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
            this.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(86, 27);
            this.txtDesde.MaxLength = 6;
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(120, 22);
            this.txtDesde.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmbLinea);
            this.groupBox4.Location = new System.Drawing.Point(264, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 100);
            this.groupBox4.TabIndex = 125;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Líneas";
            // 
            // gbxProductos
            // 
            this.gbxProductos.Controls.Add(this.lblHasta);
            this.gbxProductos.Controls.Add(this.txtHasta);
            this.gbxProductos.Controls.Add(this.lblDesde);
            this.gbxProductos.Controls.Add(this.txtDesde);
            this.gbxProductos.Location = new System.Drawing.Point(12, 8);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(258, 100);
            this.gbxProductos.TabIndex = 122;
            this.gbxProductos.TabStop = false;
            this.gbxProductos.Text = "Clave de Productos";
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.AllowUserToDeleteRows = false;
            this.dgvEntrada.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(337, 393);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.ReadOnly = true;
            this.dgvEntrada.Size = new System.Drawing.Size(428, 65);
            this.dgvEntrada.TabIndex = 133;
            this.dgvEntrada.Visible = false;
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToDeleteRows = false;
            this.dgvSalida.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(-253, 393);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.ReadOnly = true;
            this.dgvSalida.Size = new System.Drawing.Size(428, 65);
            this.dgvSalida.TabIndex = 134;
            this.dgvSalida.Visible = false;
            // 
            // ajustarExistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.gbxMovimientos);
            this.Controls.Add(this.btnAjustar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvBodega);
            this.Controls.Add(this.dgvExistencias);
            this.Controls.Add(this.btnCongelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbxProductos);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.dgvLineas);
            this.Controls.Add(this.dgvDetalleInventarioFisico);
            this.Controls.Add(this.dgvSalida);
            this.Controls.Add(this.dgvEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ajustarExistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCM | Ajustar Existencias";
            this.Load += new System.EventHandler(this.ajustarExistencias_Load);
            this.gbxMovimientos.ResumeLayout(false);
            this.gbxMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleInventarioFisico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbxProductos.ResumeLayout(false);
            this.gbxProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMovimientos;
        private System.Windows.Forms.ComboBox cmbSalida;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Button btnAjustar;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLineas;
        private System.Windows.Forms.DataGridView dgvBodega;
        private System.Windows.Forms.DataGridView dgvDetalleInventarioFisico;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCongelar;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbxProductos;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.DataGridView dgvSalida;
    }
}