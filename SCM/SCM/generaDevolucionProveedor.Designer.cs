namespace SCM
{
    partial class generaDevolucionProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generaDevolucionProveedor));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngDev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabProductosDev = new System.Windows.Forms.TabPage();
            this.grdInventario = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDevolver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.tabProductosDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(817, 479);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnIngDev
            // 
            this.btnIngDev.Location = new System.Drawing.Point(588, 454);
            this.btnIngDev.Name = "btnIngDev";
            this.btnIngDev.Size = new System.Drawing.Size(91, 23);
            this.btnIngDev.TabIndex = 20;
            this.btnIngDev.Text = "Ingresar Devolución";
            this.btnIngDev.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "CODIGO OC:";
            // 
            // txtOC
            // 
            this.txtOC.Location = new System.Drawing.Point(588, 86);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(163, 20);
            this.txtOC.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "CORRELATIVO FACTURA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 23;
            // 
            // tabProductosDev
            // 
            this.tabProductosDev.Controls.Add(this.grdInventario);
            this.tabProductosDev.Location = new System.Drawing.Point(4, 22);
            this.tabProductosDev.Name = "tabProductosDev";
            this.tabProductosDev.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductosDev.Size = new System.Drawing.Size(845, 295);
            this.tabProductosDev.TabIndex = 0;
            this.tabProductosDev.Text = "Devolución";
            this.tabProductosDev.UseVisualStyleBackColor = true;
            // 
            // grdInventario
            // 
            this.grdInventario.AllowUserToAddRows = false;
            this.grdInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Descripcion,
            this.CantidadFac,
            this.Precio,
            this.CantidadDevolver});
            this.grdInventario.Location = new System.Drawing.Point(18, 16);
            this.grdInventario.Name = "grdInventario";
            this.grdInventario.Size = new System.Drawing.Size(806, 204);
            this.grdInventario.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProductosDev);
            this.tabControl1.Location = new System.Drawing.Point(23, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 321);
            this.tabControl1.TabIndex = 18;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // CantidadFac
            // 
            this.CantidadFac.HeaderText = "Cantidad Factura";
            this.CantidadFac.Name = "CantidadFac";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // CantidadDevolver
            // 
            this.CantidadDevolver.HeaderText = "Cantidad Devolución";
            this.CantidadDevolver.Name = "CantidadDevolver";
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Image = global::SCM.Properties.Resources.buscar;
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(68, 12);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(108, 48);
            this.btnBuscarOC.TabIndex = 11;
            this.btnBuscarOC.Text = "BUSCAR";
            this.btnBuscarOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            this.btnBuscarOC.Click += new System.EventHandler(this.btnBuscarOC_Click);
            // 
            // generaDevolucionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngDev);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOC);
            this.Controls.Add(this.btnBuscarOC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(936, 553);
            this.MinimumSize = new System.Drawing.Size(936, 553);
            this.Name = "generaDevolucionProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolución a Proveedor";
            this.tabProductosDev.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabProductosDev;
        private System.Windows.Forms.DataGridView grdInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDevolver;
        private System.Windows.Forms.TabControl tabControl1;
    }
}