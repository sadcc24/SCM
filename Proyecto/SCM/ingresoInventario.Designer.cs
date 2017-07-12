namespace SCM
{
    partial class ingresoInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoInventario));
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.grdInventario = new System.Windows.Forms.DataGridView();
            this.OP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtbodega = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprovee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocRef = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Image = global::SCM.Properties.Resources.buscar;
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(365, 53);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(41, 42);
            this.btnBuscarOC.TabIndex = 0;
            this.btnBuscarOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            this.btnBuscarOC.Click += new System.EventHandler(this.btnBuscarOC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(29, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 286);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Inventario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Location = new System.Drawing.Point(11, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 249);
            this.tabControl1.TabIndex = 7;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.grdInventario);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(845, 223);
            this.tabProductos.TabIndex = 0;
            this.tabProductos.Text = "Movimiento Inventario";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // grdInventario
            // 
            this.grdInventario.AllowUserToAddRows = false;
            this.grdInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OP});
            this.grdInventario.Location = new System.Drawing.Point(6, 6);
            this.grdInventario.Name = "grdInventario";
            this.grdInventario.Size = new System.Drawing.Size(833, 211);
            this.grdInventario.TabIndex = 0;
            // 
            // OP
            // 
            this.OP.HeaderText = "Sel";
            this.OP.Name = "OP";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(860, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 52);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOperacion);
            this.groupBox4.Controls.Add(this.txtbodega);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cmbProveedor);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtprovee);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmbBodega);
            this.groupBox4.Controls.Add(this.cmbTipoMovimiento);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnBuscarOC);
            this.groupBox4.Controls.Add(this.txtDocRef);
            this.groupBox4.Location = new System.Drawing.Point(29, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(803, 109);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encabezado:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(366, 27);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(41, 13);
            this.lblOperacion.TabIndex = 40;
            this.lblOperacion.Text = "label13";
            this.lblOperacion.Visible = false;
            // 
            // txtbodega
            // 
            this.txtbodega.Location = new System.Drawing.Point(736, 77);
            this.txtbodega.Name = "txtbodega";
            this.txtbodega.ReadOnly = true;
            this.txtbodega.Size = new System.Drawing.Size(61, 20);
            this.txtbodega.TabIndex = 39;
            this.txtbodega.Visible = false;
            this.txtbodega.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(569, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Bodega:";
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(141, 74);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(218, 21);
            this.cmbProveedor.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Proveedores:";
            // 
            // txtprovee
            // 
            this.txtprovee.Location = new System.Drawing.Point(736, 44);
            this.txtprovee.Name = "txtprovee";
            this.txtprovee.ReadOnly = true;
            this.txtprovee.Size = new System.Drawing.Size(61, 20);
            this.txtprovee.TabIndex = 16;
            this.txtprovee.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Proveedor:";
            this.label7.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 35;
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(141, 47);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(218, 21);
            this.cmbBodega.TabIndex = 34;
            this.cmbBodega.SelectedIndexChanged += new System.EventHandler(this.cmbBodega_SelectedIndexChanged);
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(141, 20);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(218, 21);
            this.cmbTipoMovimiento.TabIndex = 6;
            this.cmbTipoMovimiento.SelectedValueChanged += new System.EventHandler(this.cmbTipoMovimiento_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Movimiento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Bodega:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Documento Referencia:";
            this.label4.Visible = false;
            // 
            // txtDocRef
            // 
            this.txtDocRef.Location = new System.Drawing.Point(736, 18);
            this.txtDocRef.Name = "txtDocRef";
            this.txtDocRef.ReadOnly = true;
            this.txtDocRef.Size = new System.Drawing.Size(61, 20);
            this.txtDocRef.TabIndex = 10;
            this.txtDocRef.Visible = false;
            this.txtDocRef.TextChanged += new System.EventHandler(this.txtSolTras_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtserie);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtfecha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcorr);
            this.groupBox2.Location = new System.Drawing.Point(29, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encabezado Factura:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(530, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(218, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Serie:";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(141, 21);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(218, 20);
            this.txtserie.TabIndex = 16;
            this.txtserie.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha:";
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(141, 47);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(218, 20);
            this.dtfecha.TabIndex = 13;
            this.dtfecha.Value = new System.DateTime(2017, 7, 8, 23, 15, 29, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correlativo:";
            // 
            // txtcorr
            // 
            this.txtcorr.Location = new System.Drawing.Point(530, 21);
            this.txtcorr.Name = "txtcorr";
            this.txtcorr.Size = new System.Drawing.Size(218, 20);
            this.txtcorr.TabIndex = 12;
            // 
            // ingresoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(936, 553);
            this.MinimumSize = new System.Drawing.Size(936, 553);
            this.Name = "ingresoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Inventario";
            this.Load += new System.EventHandler(this.ingresoInventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtDocRef;
        public System.Windows.Forms.ComboBox cmbTipoMovimiento;
        public System.Windows.Forms.ComboBox cmbBodega;
        public System.Windows.Forms.DataGridView grdInventario;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtprovee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtcorr;
        public System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OP;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtbodega;
        private System.Windows.Forms.Label lblOperacion;
    }
}

