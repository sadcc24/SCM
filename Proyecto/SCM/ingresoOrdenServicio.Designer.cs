namespace SCM
{
    partial class ingresoOrdenServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoOrdenServicio));
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtKmsProx = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdKms = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKmsVehiculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdOrdenServicio = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(376, 184);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(61, 13);
            this.lblMotor.TabIndex = 37;
            this.lblMotor.Text = "Costo Total";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(30, 187);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(108, 13);
            this.lblPlaca.TabIndex = 36;
            this.lblPlaca.Text = "Kms Próximo Servicio";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(344, 118);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(93, 13);
            this.lblLinea.TabIndex = 35;
            this.lblLinea.Text = "Fecha de Servicio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(95, 118);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 32;
            this.lblMarca.Text = "Factura";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(459, 184);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(155, 20);
            this.txtTotal.TabIndex = 31;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtKmsProx
            // 
            this.txtKmsProx.Location = new System.Drawing.Point(153, 184);
            this.txtKmsProx.Name = "txtKmsProx";
            this.txtKmsProx.Size = new System.Drawing.Size(154, 20);
            this.txtKmsProx.TabIndex = 28;
            this.txtKmsProx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKmsProx_KeyPress);
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(153, 115);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(154, 20);
            this.txtFactura.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tipo de Servicio";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "1, Full",
            "2, Parcial"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(459, 146);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(154, 21);
            this.cmbTipoServicio.TabIndex = 41;
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
            this.groupBox1.Location = new System.Drawing.Point(157, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 102);
            this.groupBox1.TabIndex = 42;
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
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Kms Actuales";
            // 
            // txtIdKms
            // 
            this.txtIdKms.Location = new System.Drawing.Point(153, 146);
            this.txtIdKms.Name = "txtIdKms";
            this.txtIdKms.Size = new System.Drawing.Size(156, 20);
            this.txtIdKms.TabIndex = 45;
            this.txtIdKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdKms_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKmsVehiculo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIdOrdenServicio);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtIdVehiculo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIdKms);
            this.groupBox2.Controls.Add(this.cmbTipoServicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblMotor);
            this.groupBox2.Controls.Add(this.lblPlaca);
            this.groupBox2.Controls.Add(this.lblLinea);
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtKmsProx);
            this.groupBox2.Controls.Add(this.txtFactura);
            this.groupBox2.Location = new System.Drawing.Point(34, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 228);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Generales";
            // 
            // lblKmsVehiculo
            // 
            this.lblKmsVehiculo.AutoSize = true;
            this.lblKmsVehiculo.Location = new System.Drawing.Point(434, 35);
            this.lblKmsVehiculo.Name = "lblKmsVehiculo";
            this.lblKmsVehiculo.Size = new System.Drawing.Size(35, 13);
            this.lblKmsVehiculo.TabIndex = 52;
            this.lblKmsVehiculo.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Codigo de Orden de Servicio";
            // 
            // txtIdOrdenServicio
            // 
            this.txtIdOrdenServicio.Enabled = false;
            this.txtIdOrdenServicio.Location = new System.Drawing.Point(269, 32);
            this.txtIdOrdenServicio.Name = "txtIdOrdenServicio";
            this.txtIdOrdenServicio.Size = new System.Drawing.Size(100, 20);
            this.txtIdOrdenServicio.TabIndex = 50;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(457, 118);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Codigo de Vehículo";
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Enabled = false;
            this.txtIdVehiculo.Location = new System.Drawing.Point(123, 32);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(84, 20);
            this.txtIdVehiculo.TabIndex = 47;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToOrderColumns = true;
            this.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(11, 33);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(683, 189);
            this.dgvServicios.TabIndex = 48;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvServicios);
            this.groupBox3.Location = new System.Drawing.Point(34, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 242);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial de Servicios";
            // 
            // ingresoOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 629);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ingresoOrdenServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Servicio de Vehículo";
            this.Load += new System.EventHandler(this.ingresoOrdenServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtKmsProx;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdKms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdOrdenServicio;
        private System.Windows.Forms.Label lblKmsVehiculo;
    }
}