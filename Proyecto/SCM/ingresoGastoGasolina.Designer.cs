namespace SCM
{
    partial class ingresoGastoGasolina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoGastoGasolina));
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoGasto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.txtIdGasto = new System.Windows.Forms.TextBox();
            this.txtIdTransporte = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGastoPivote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(138, 123);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(130, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(138, 68);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(130, 20);
            this.txtFactura.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(418, 71);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(418, 104);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(200, 65);
            this.txtNotas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Factura Asociada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Notas Adicionales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Factura";
            // 
            // cmbTipoGasto
            // 
            this.cmbTipoGasto.FormattingEnabled = true;
            this.cmbTipoGasto.Location = new System.Drawing.Point(138, 94);
            this.cmbTipoGasto.Name = "cmbTipoGasto";
            this.cmbTipoGasto.Size = new System.Drawing.Size(130, 21);
            this.cmbTipoGasto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kms Recorridos";
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(12, 423);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.Size = new System.Drawing.Size(728, 192);
            this.dgvGastos.TabIndex = 10;
            this.dgvGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellClick);
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(139, 149);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(130, 20);
            this.txtKms.TabIndex = 11;
            this.txtKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKms_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Gasto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyuda);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(139, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 102);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(352, 26);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(50, 50);
            this.btnAyuda.TabIndex = 15;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(128, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 50);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(184, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(240, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(296, 26);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 50);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(72, 26);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(16, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Enabled = false;
            this.txtIdSolicitud.Location = new System.Drawing.Point(12, 80);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.Size = new System.Drawing.Size(100, 20);
            this.txtIdSolicitud.TabIndex = 65;
            this.txtIdSolicitud.Visible = false;
            // 
            // txtIdGasto
            // 
            this.txtIdGasto.Enabled = false;
            this.txtIdGasto.Location = new System.Drawing.Point(12, 54);
            this.txtIdGasto.Name = "txtIdGasto";
            this.txtIdGasto.Size = new System.Drawing.Size(100, 20);
            this.txtIdGasto.TabIndex = 66;
            this.txtIdGasto.Visible = false;
            // 
            // txtIdTransporte
            // 
            this.txtIdTransporte.Enabled = false;
            this.txtIdTransporte.Location = new System.Drawing.Point(12, 28);
            this.txtIdTransporte.Name = "txtIdTransporte";
            this.txtIdTransporte.Size = new System.Drawing.Size(100, 20);
            this.txtIdTransporte.TabIndex = 67;
            this.txtIdTransporte.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGastoPivote);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDetalle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTipoGasto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtKms);
            this.groupBox2.Controls.Add(this.txtFactura);
            this.groupBox2.Controls.Add(this.txtNotas);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Location = new System.Drawing.Point(28, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 191);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Gastos";
            // 
            // txtGastoPivote
            // 
            this.txtGastoPivote.Location = new System.Drawing.Point(274, 123);
            this.txtGastoPivote.Name = "txtGastoPivote";
            this.txtGastoPivote.Size = new System.Drawing.Size(100, 20);
            this.txtGastoPivote.TabIndex = 15;
            this.txtGastoPivote.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Codigo Detalle";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Location = new System.Drawing.Point(138, 41);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(130, 20);
            this.txtDetalle.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalGastos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(89, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 100);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Generales";
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Enabled = false;
            this.txtTotalGastos.Location = new System.Drawing.Point(214, 41);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGastos.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total de Gastos";
            // 
            // ingresoGastoGasolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 637);
            this.Controls.Add(this.txtIdGasto);
            this.Controls.Add(this.txtIdTransporte);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.groupBox2);
            this.Name = "ingresoGastoGasolina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos del Transporte";
            this.Load += new System.EventHandler(this.ingresoGastoGasolina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.TextBox txtIdGasto;
        private System.Windows.Forms.TextBox txtIdTransporte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalGastos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGastoPivote;
    }
}