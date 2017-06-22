namespace SCM
{
    partial class buscarVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarVehiculos));
            this.grdVehiculos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.Placa = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVehiculos
            // 
            this.grdVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehiculos.Location = new System.Drawing.Point(12, 207);
            this.grdVehiculos.Name = "grdVehiculos";
            this.grdVehiculos.Size = new System.Drawing.Size(947, 317);
            this.grdVehiculos.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(30, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(86, 22);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 50);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Location = new System.Drawing.Point(142, 22);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(50, 50);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(198, 22);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 50);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(254, 22);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(50, 50);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(310, 22);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(50, 50);
            this.btnUltimo.TabIndex = 6;
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(366, 22);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(50, 50);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(301, 121);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(27, 114);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca";
            // 
            // Placa
            // 
            this.Placa.AutoSize = true;
            this.Placa.Location = new System.Drawing.Point(27, 151);
            this.Placa.Name = "Placa";
            this.Placa.Size = new System.Drawing.Size(37, 13);
            this.Placa.TabIndex = 11;
            this.Placa.Text = "Marca";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(86, 151);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(162, 20);
            this.txtPlaca.TabIndex = 12;
            // 
            // verVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 536);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.Placa);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdVehiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "verVehiculos";
            this.Text = "Vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVehiculos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label Placa;
        private System.Windows.Forms.TextBox txtPlaca;
    }
}