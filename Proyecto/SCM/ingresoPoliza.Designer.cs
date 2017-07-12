namespace SCM
{
    partial class ingresoPoliza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ingresoPoliza));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarDetalle = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.cboCuentaContable = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(508, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 23);
            this.lblTitulo.TabIndex = 116;
            this.lblTitulo.Text = "Ingreso de Pólizas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCuentaContable);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtClasificacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtfecha);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.btnGuardarDetalle);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 214);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Pólizas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnGuardarDetalle
            // 
            this.btnGuardarDetalle.Image = global::SCM.Properties.Resources.guardar;
            this.btnGuardarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarDetalle.Location = new System.Drawing.Point(563, 81);
            this.btnGuardarDetalle.Name = "btnGuardarDetalle";
            this.btnGuardarDetalle.Size = new System.Drawing.Size(42, 48);
            this.btnGuardarDetalle.TabIndex = 16;
            this.btnGuardarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarDetalle.UseVisualStyleBackColor = true;
            this.btnGuardarDetalle.Click += new System.EventHandler(this.btnGuardarDetalle_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 47);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcion.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.Location = new System.Drawing.Point(123, 73);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(218, 20);
            this.dtfecha.TabIndex = 19;
            this.dtfecha.Value = new System.DateTime(2017, 7, 8, 23, 15, 29, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cuenta:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Clasificación:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(123, 111);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(172, 20);
            this.txtClasificacion.TabIndex = 25;
            this.txtClasificacion.TextChanged += new System.EventHandler(this.txtClasificacion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "(DEBE/HABER)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Valor:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(123, 148);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(172, 20);
            this.txttotal.TabIndex = 28;
            this.txttotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboCuentaContable
            // 
            this.cboCuentaContable.FormattingEnabled = true;
            this.cboCuentaContable.Location = new System.Drawing.Point(123, 182);
            this.cboCuentaContable.Name = "cboCuentaContable";
            this.cboCuentaContable.Size = new System.Drawing.Size(172, 21);
            this.cboCuentaContable.TabIndex = 29;
            this.cboCuentaContable.SelectedIndexChanged += new System.EventHandler(this.cboCuentaContable_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 34);
            this.button1.TabIndex = 118;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ingresoPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.MaximumSize = new System.Drawing.Size(688, 300);
            this.MinimumSize = new System.Drawing.Size(688, 300);
            this.Name = "ingresoPoliza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Poliza";
            this.Load += new System.EventHandler(this.ingresoPoliza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarDetalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.ComboBox cboCuentaContable;
        public System.Windows.Forms.Button button1;
    }
}