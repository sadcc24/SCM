namespace SCM
{
    partial class autorizaPagoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autorizaPagoProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.grdInventario = new System.Windows.Forms.DataGridView();
            this.chkSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAutorizaPago = new System.Windows.Forms.Button();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "SEDE:";
            // 
            // cmbSede
            // 
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(129, 28);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(121, 21);
            this.cmbSede.TabIndex = 9;
            // 
            // grdInventario
            // 
            this.grdInventario.AllowUserToAddRows = false;
            this.grdInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSeleccionar,
            this.Sede,
            this.Factura,
            this.Monto,
            this.Proveedor,
            this.Estado});
            this.grdInventario.Location = new System.Drawing.Point(26, 82);
            this.grdInventario.Name = "grdInventario";
            this.grdInventario.Size = new System.Drawing.Size(636, 269);
            this.grdInventario.TabIndex = 11;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.HeaderText = "Seleccionar";
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Sede
            // 
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // btnAutorizaPago
            // 
            this.btnAutorizaPago.Image = global::SCM.Properties.Resources.cuentasporcobrar;
            this.btnAutorizaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutorizaPago.Location = new System.Drawing.Point(530, 359);
            this.btnAutorizaPago.Name = "btnAutorizaPago";
            this.btnAutorizaPago.Size = new System.Drawing.Size(132, 48);
            this.btnAutorizaPago.TabIndex = 13;
            this.btnAutorizaPago.Text = "Autoriza Pago";
            this.btnAutorizaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAutorizaPago.UseVisualStyleBackColor = true;
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Image = global::SCM.Properties.Resources.buscar;
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(340, 17);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(108, 48);
            this.btnBuscarOC.TabIndex = 10;
            this.btnBuscarOC.Text = "BUSCAR";
            this.btnBuscarOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            // 
            // autorizaPagoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.btnAutorizaPago);
            this.Controls.Add(this.grdInventario);
            this.Controls.Add(this.btnBuscarOC);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(690, 458);
            this.MinimumSize = new System.Drawing.Size(690, 458);
            this.Name = "autorizaPagoProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorización Pago a Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.DataGridView grdInventario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnAutorizaPago;
    }
}