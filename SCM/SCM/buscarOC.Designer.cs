namespace SCM
{
    partial class buscarOC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarOC));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.grdInventario = new System.Windows.Forms.DataGridView();
            this.btnBuscarOC = new System.Windows.Forms.Button();
            this.chkSeleccionar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.OC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CODIGO OC:";
            // 
            // txtOC
            // 
            this.txtOC.Location = new System.Drawing.Point(134, 41);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(163, 20);
            this.txtOC.TabIndex = 5;
            // 
            // grdInventario
            // 
            this.grdInventario.AllowUserToAddRows = false;
            this.grdInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSeleccionar,
            this.OC,
            this.Sede,
            this.Empresa,
            this.Estado});
            this.grdInventario.Location = new System.Drawing.Point(12, 94);
            this.grdInventario.Name = "grdInventario";
            this.grdInventario.Size = new System.Drawing.Size(636, 313);
            this.grdInventario.TabIndex = 6;
            // 
            // btnBuscarOC
            // 
            this.btnBuscarOC.Image = global::SCM.Properties.Resources.buscar;
            this.btnBuscarOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarOC.Location = new System.Drawing.Point(427, 26);
            this.btnBuscarOC.Name = "btnBuscarOC";
            this.btnBuscarOC.Size = new System.Drawing.Size(108, 48);
            this.btnBuscarOC.TabIndex = 4;
            this.btnBuscarOC.Text = "BUSCAR";
            this.btnBuscarOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarOC.UseVisualStyleBackColor = true;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.HeaderText = "Seleccionar";
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // OC
            // 
            this.OC.HeaderText = "OC";
            this.OC.Name = "OC";
            // 
            // Sede
            // 
            this.Sede.HeaderText = "Sede";
            this.Sede.Name = "Sede";
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // buscarOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.grdInventario);
            this.Controls.Add(this.txtOC);
            this.Controls.Add(this.btnBuscarOC);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(690, 458);
            this.MinimumSize = new System.Drawing.Size(690, 458);
            this.Name = "buscarOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Órdenes de Compra Pendientes";
            ((System.ComponentModel.ISupportInitialize)(this.grdInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarOC;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.DataGridView grdInventario;
        private System.Windows.Forms.DataGridViewLinkColumn chkSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}