﻿namespace SCM
{
    partial class Lineas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lineas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvLineasA = new System.Windows.Forms.DataGridView();
            this.grupoFiltrar = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLineasA)).BeginInit();
            this.grupoFiltrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCondicion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gvLineasA);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 230);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lineas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(51, 15);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(83, 20);
            this.txtCod.TabIndex = 110;
            this.txtCod.Tag = "estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 19);
            this.label6.TabIndex = 109;
            this.label6.Text = "ID:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(380, 138);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(163, 20);
            this.txtEstado.TabIndex = 5;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado:";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(380, 95);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(163, 20);
            this.txtCondicion.TabIndex = 3;
            this.txtCondicion.Text = "1";
            this.txtCondicion.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Condición:";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción:";
            // 
            // gvLineasA
            // 
            this.gvLineasA.AllowUserToDeleteRows = false;
            this.gvLineasA.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gvLineasA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvLineasA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLineasA.Location = new System.Drawing.Point(0, 93);
            this.gvLineasA.Name = "gvLineasA";
            this.gvLineasA.ReadOnly = true;
            this.gvLineasA.Size = new System.Drawing.Size(428, 65);
            this.gvLineasA.TabIndex = 114;
            this.gvLineasA.Visible = false;
            // 
            // grupoFiltrar
            // 
            this.grupoFiltrar.Controls.Add(this.lblTitulo);
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
            this.grupoFiltrar.TabIndex = 115;
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
            this.lblTitulo.Size = new System.Drawing.Size(189, 23);
            this.lblTitulo.TabIndex = 115;
            this.lblTitulo.Text = "Mantenimiento Lineas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(318, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Enabled = false;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(267, 13);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(216, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(165, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(114, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(63, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(380, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // Lineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoFiltrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(852, 477);
            this.MinimumSize = new System.Drawing.Size(852, 359);
            this.Name = "Lineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Lineas";
            this.Load += new System.EventHandler(this.Lineas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLineasA)).EndInit();
            this.grupoFiltrar.ResumeLayout(false);
            this.grupoFiltrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grupoFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefrescar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCondicion;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView gvLineasA;
        public System.Windows.Forms.TextBox txtDescripcion;
    }
}