﻿namespace SCM
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.grupoFiltrar = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbmetodo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipProd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbUnidadTamano = new System.Windows.Forms.ComboBox();
            this.cmbUnidadPeso = new System.Windows.Forms.ComboBox();
            this.txtsmax = new System.Windows.Forms.TextBox();
            this.txtsmin = new System.Windows.Forms.TextBox();
            this.txttam = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.grupoFiltrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoFiltrar
            // 
            this.grupoFiltrar.Controls.Add(this.lblTitulo);
            this.grupoFiltrar.Controls.Add(this.txtEstado);
            this.grupoFiltrar.Controls.Add(this.button1);
            this.grupoFiltrar.Controls.Add(this.btnRefrescar);
            this.grupoFiltrar.Controls.Add(this.btnCancelar);
            this.grupoFiltrar.Controls.Add(this.btnGuardar);
            this.grupoFiltrar.Controls.Add(this.btnEliminar);
            this.grupoFiltrar.Controls.Add(this.btnEditar);
            this.grupoFiltrar.Controls.Add(this.btnNuevo);
            this.grupoFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupoFiltrar.Location = new System.Drawing.Point(0, 0);
            this.grupoFiltrar.Name = "grupoFiltrar";
            this.grupoFiltrar.Size = new System.Drawing.Size(836, 61);
            this.grupoFiltrar.TabIndex = 113;
            this.grupoFiltrar.TabStop = false;
            this.grupoFiltrar.Text = "MENU";
            this.grupoFiltrar.Enter += new System.EventHandler(this.grupoFiltrar_Enter);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(600, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 23);
            this.lblTitulo.TabIndex = 115;
            this.lblTitulo.Text = "Mantenimiento Productos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(384, 25);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(48, 20);
            this.txtEstado.TabIndex = 107;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Text = "ACTIVO";
            this.txtEstado.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(318, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Enabled = false;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(267, 13);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(216, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(165, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(114, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(63, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpeso);
            this.groupBox1.Controls.Add(this.txttam);
            this.groupBox1.Controls.Add(this.txtsmin);
            this.groupBox1.Controls.Add(this.txtsmax);
            this.groupBox1.Controls.Add(this.cmbUnidadPeso);
            this.groupBox1.Controls.Add(this.cmbUnidadTamano);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cmbLinea);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbmetodo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbTipProd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 350);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 142;
            // 
            // cmbLinea
            // 
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(555, 144);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(163, 21);
            this.cmbLinea.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 131;
            this.label9.Text = "Línea:";
            // 
            // cmbmetodo
            // 
            this.cmbmetodo.FormattingEnabled = true;
            this.cmbmetodo.Location = new System.Drawing.Point(206, 142);
            this.cmbmetodo.Name = "cmbmetodo";
            this.cmbmetodo.Size = new System.Drawing.Size(163, 21);
            this.cmbmetodo.TabIndex = 119;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 129;
            this.label8.Text = "Método Costeo:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(555, 107);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(163, 21);
            this.cmbMarca.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 127;
            this.label7.Text = "Marca:";
            // 
            // cmbTipProd
            // 
            this.cmbTipProd.FormattingEnabled = true;
            this.cmbTipProd.Location = new System.Drawing.Point(206, 104);
            this.cmbTipProd.Name = "cmbTipProd";
            this.cmbTipProd.Size = new System.Drawing.Size(163, 21);
            this.cmbTipProd.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 125;
            this.label5.Text = "Tipo Producto:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(206, 66);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(163, 21);
            this.cmbProveedor.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 123;
            this.label4.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 117;
            this.label6.Text = "ID:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(396, 30);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(322, 20);
            this.txtProducto.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 116;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 143;
            this.label2.Text = "Stock Máximo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 144;
            this.label3.Text = "Stock Mínimo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(79, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 146;
            this.label10.Text = "Tamaño:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 145;
            this.label11.Text = "Peso:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 19);
            this.label12.TabIndex = 148;
            this.label12.Text = "Unidad Tamaño:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(426, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 147;
            this.label13.Text = "Unidad Peso:";
            // 
            // cmbUnidadTamano
            // 
            this.cmbUnidadTamano.FormattingEnabled = true;
            this.cmbUnidadTamano.Location = new System.Drawing.Point(555, 242);
            this.cmbUnidadTamano.Name = "cmbUnidadTamano";
            this.cmbUnidadTamano.Size = new System.Drawing.Size(163, 21);
            this.cmbUnidadTamano.TabIndex = 124;
            // 
            // cmbUnidadPeso
            // 
            this.cmbUnidadPeso.FormattingEnabled = true;
            this.cmbUnidadPeso.Location = new System.Drawing.Point(555, 282);
            this.cmbUnidadPeso.Name = "cmbUnidadPeso";
            this.cmbUnidadPeso.Size = new System.Drawing.Size(163, 21);
            this.cmbUnidadPeso.TabIndex = 126;
            // 
            // txtsmax
            // 
            this.txtsmax.Location = new System.Drawing.Point(555, 201);
            this.txtsmax.Name = "txtsmax";
            this.txtsmax.Size = new System.Drawing.Size(163, 20);
            this.txtsmax.TabIndex = 122;
            // 
            // txtsmin
            // 
            this.txtsmin.Location = new System.Drawing.Point(206, 203);
            this.txtsmin.Name = "txtsmin";
            this.txtsmin.Size = new System.Drawing.Size(163, 20);
            this.txtsmin.TabIndex = 121;
            // 
            // txttam
            // 
            this.txttam.Location = new System.Drawing.Point(206, 245);
            this.txttam.Name = "txttam";
            this.txttam.Size = new System.Drawing.Size(163, 20);
            this.txttam.TabIndex = 123;
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(206, 282);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(163, 20);
            this.txtpeso.TabIndex = 125;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoFiltrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(852, 477);
            this.MinimumSize = new System.Drawing.Size(852, 477);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grupoFiltrar.ResumeLayout(false);
            this.grupoFiltrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoFiltrar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbLinea;
        public System.Windows.Forms.ComboBox cmbmetodo;
        public System.Windows.Forms.ComboBox cmbMarca;
        public System.Windows.Forms.ComboBox cmbTipProd;
        public System.Windows.Forms.ComboBox cmbProveedor;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtpeso;
        public System.Windows.Forms.TextBox txttam;
        public System.Windows.Forms.TextBox txtsmin;
        public System.Windows.Forms.TextBox txtsmax;
        public System.Windows.Forms.ComboBox cmbUnidadPeso;
        public System.Windows.Forms.ComboBox cmbUnidadTamano;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}