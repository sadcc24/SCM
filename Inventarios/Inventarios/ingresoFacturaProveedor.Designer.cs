namespace Inventarios
{
    partial class ingresoFacturaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoFacturaProveedor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorrelativoFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalle = new System.Windows.Forms.TabPage();
            this.grdDetalleFactura = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarDetalle = new System.Windows.Forms.Button();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "CORRELATIVO FACTURA:";
            // 
            // txtCorrelativoFactura
            // 
            this.txtCorrelativoFactura.Location = new System.Drawing.Point(212, 112);
            this.txtCorrelativoFactura.Name = "txtCorrelativoFactura";
            this.txtCorrelativoFactura.Size = new System.Drawing.Size(172, 20);
            this.txtCorrelativoFactura.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "CODIGO OC:";
            // 
            // txtOC
            // 
            this.txtOC.Location = new System.Drawing.Point(212, 141);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(172, 20);
            this.txtOC.TabIndex = 6;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(529, 112);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(172, 20);
            this.txtSerie.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "SERIE:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDetalle);
            this.tabControl1.Location = new System.Drawing.Point(81, 180);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 322);
            this.tabControl1.TabIndex = 11;
            // 
            // tabDetalle
            // 
            this.tabDetalle.Controls.Add(this.grdDetalleFactura);
            this.tabDetalle.Location = new System.Drawing.Point(4, 22);
            this.tabDetalle.Name = "tabDetalle";
            this.tabDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalle.Size = new System.Drawing.Size(564, 296);
            this.tabDetalle.TabIndex = 0;
            this.tabDetalle.Text = "Detalle Factura";
            this.tabDetalle.UseVisualStyleBackColor = true;
            // 
            // grdDetalleFactura
            // 
            this.grdDetalleFactura.AllowUserToAddRows = false;
            this.grdDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.Cantidad,
            this.Precio});
            this.grdDetalleFactura.Location = new System.Drawing.Point(6, 3);
            this.grdDetalleFactura.Name = "grdDetalleFactura";
            this.grdDetalleFactura.Size = new System.Drawing.Size(555, 285);
            this.grdDetalleFactura.TabIndex = 1;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // button1
            // 
            this.button1.Image = global::Inventarios.Properties.Resources.buscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(98, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "BUSCAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.Image = global::Inventarios.Properties.Resources.guardar;
            this.btnGuardarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDetalle.Location = new System.Drawing.Point(716, 454);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(132, 48);
            this.btnGuardarDetalle.TabIndex = 12;
            this.btnGuardarDetalle.Text = "Guardar Detalle";
            this.btnGuardarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDetalle.UseVisualStyleBackColor = true;
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Image = global::Inventarios.Properties.Resources.aceptar;
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(731, 113);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(132, 48);
            this.btnBuscarOC.TabIndex = 10;
            this.btnBuscarOC.Text = "Registrar Factura";
            this.btnBuscarOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            // 
            // ingresoFacturaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarDetalle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBuscarOC);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOC);
            this.Controls.Add(this.txtCorrelativoFactura);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(936, 553);
            this.MinimumSize = new System.Drawing.Size(936, 553);
            this.Name = "ingresoFacturaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Factura Proveedores";
            this.tabControl1.ResumeLayout(false);
            this.tabDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorrelativoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDetalle;
        private System.Windows.Forms.DataGridView grdDetalleFactura;
        private System.Windows.Forms.DataGridViewComboBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnGuardarDetalle;
        private System.Windows.Forms.Button button1;
    }
}