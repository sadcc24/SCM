﻿namespace SCM
{
    partial class mantenimientoEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mantenimientoEmpleados));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvEmpleados = new System.Windows.Forms.DataGridView();
            this.gvEmpleadosA = new System.Windows.Forms.DataGridView();
            this.z = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadosA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvEmpleados);
            this.groupBox2.Controls.Add(this.gvEmpleadosA);
            this.groupBox2.Location = new System.Drawing.Point(6, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 331);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignación de Empresas";
            // 
            // gvEmpleados
            // 
            this.gvEmpleados.AllowUserToDeleteRows = false;
            this.gvEmpleados.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpleados.Location = new System.Drawing.Point(76, 19);
            this.gvEmpleados.Name = "gvEmpleados";
            this.gvEmpleados.ReadOnly = true;
            this.gvEmpleados.Size = new System.Drawing.Size(759, 294);
            this.gvEmpleados.TabIndex = 8;
            this.gvEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEmpleados_CellDoubleClick);
            // 
            // gvEmpleadosA
            // 
            this.gvEmpleadosA.AllowUserToDeleteRows = false;
            this.gvEmpleadosA.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.gvEmpleadosA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvEmpleadosA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpleadosA.Location = new System.Drawing.Point(28, 127);
            this.gvEmpleadosA.Name = "gvEmpleadosA";
            this.gvEmpleadosA.ReadOnly = true;
            this.gvEmpleadosA.Size = new System.Drawing.Size(465, 148);
            this.gvEmpleadosA.TabIndex = 1;
            this.gvEmpleadosA.Visible = false;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Dock = System.Windows.Forms.DockStyle.Right;
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.Location = new System.Drawing.Point(519, 0);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(401, 39);
            this.z.TabIndex = 117;
            this.z.Text = "Asignación de Empresas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAyuda);
            this.groupBox1.Controls.Add(this.btnUltimo);
            this.groupBox1.Controls.Add(this.txtBuscador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnPrimero);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(6, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 113);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignación de Empresas";
            // 
            // button1
            // 
            this.button1.Image = global::SCM.Properties.Resources.buscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(792, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 48);
            this.button1.TabIndex = 7;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(378, 32);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(50, 50);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(322, 32);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(50, 50);
            this.btnUltimo.TabIndex = 5;
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(623, 50);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(163, 20);
            this.txtBuscador.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(266, 32);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(50, 50);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::SCM.Properties.Resources.anterior;
            this.btnAnterior.Location = new System.Drawing.Point(210, 32);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(50, 50);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Location = new System.Drawing.Point(154, 32);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(50, 50);
            this.btnPrimero.TabIndex = 2;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(98, 32);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(50, 50);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(42, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // mantenimientoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.z);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(936, 553);
            this.MinimumSize = new System.Drawing.Size(936, 553);
            this.Name = "mantenimientoEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Empresas";
            this.Load += new System.EventHandler(this.mantenimientoEmpleados_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadosA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView gvEmpleados;
        private System.Windows.Forms.DataGridView gvEmpleadosA;
    }
}