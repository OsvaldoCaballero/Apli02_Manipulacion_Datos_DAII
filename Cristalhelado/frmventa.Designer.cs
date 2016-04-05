namespace Cristalhelado
{
    partial class frmventa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstproductos = new System.Windows.Forms.ListBox();
            this.btnproducto = new System.Windows.Forms.Button();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.cmbempleado = new System.Windows.Forms.ComboBox();
            this.dtpfechav = new System.Windows.Forms.DateTimePicker();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.cmbfactura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbventa = new System.Windows.Forms.Label();
            this.lbtam = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbventa);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstproductos);
            this.groupBox1.Controls.Add(this.btnproducto);
            this.groupBox1.Controls.Add(this.cmbproducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(44, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos de la venta";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(65, 76);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.Location = new System.Drawing.Point(253, 67);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(132, 82);
            this.lstproductos.TabIndex = 5;
            // 
            // btnproducto
            // 
            this.btnproducto.Location = new System.Drawing.Point(96, 117);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(139, 23);
            this.btnproducto.TabIndex = 4;
            this.btnproducto.Text = "Agregar Producto";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(65, 31);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbproducto.TabIndex = 3;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged);
            // 
            // cmbempleado
            // 
            this.cmbempleado.FormattingEnabled = true;
            this.cmbempleado.Location = new System.Drawing.Point(169, 74);
            this.cmbempleado.Name = "cmbempleado";
            this.cmbempleado.Size = new System.Drawing.Size(121, 21);
            this.cmbempleado.TabIndex = 5;
            // 
            // dtpfechav
            // 
            this.dtpfechav.CustomFormat = "yyyy-MM-dd";
            this.dtpfechav.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechav.Location = new System.Drawing.Point(169, 128);
            this.dtpfechav.Name = "dtpfechav";
            this.dtpfechav.Size = new System.Drawing.Size(121, 20);
            this.dtpfechav.TabIndex = 6;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(152, 398);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(128, 23);
            this.btnregistrar.TabIndex = 7;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // cmbfactura
            // 
            this.cmbfactura.FormattingEnabled = true;
            this.cmbfactura.Items.AddRange(new object[] {
            "si",
            "no"});
            this.cmbfactura.Location = new System.Drawing.Point(152, 355);
            this.cmbfactura.Name = "cmbfactura";
            this.cmbfactura.Size = new System.Drawing.Size(121, 21);
            this.cmbfactura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tamano:";
            // 
            // lbventa
            // 
            this.lbventa.AutoSize = true;
            this.lbventa.Location = new System.Drawing.Point(207, 39);
            this.lbventa.Name = "lbventa";
            this.lbventa.Size = new System.Drawing.Size(13, 13);
            this.lbventa.TabIndex = 11;
            this.lbventa.Text = "--";
            // 
            // lbtam
            // 
            this.lbtam.AutoSize = true;
            this.lbtam.Location = new System.Drawing.Point(340, 41);
            this.lbtam.Name = "lbtam";
            this.lbtam.Size = new System.Drawing.Size(13, 13);
            this.lbtam.TabIndex = 12;
            this.lbtam.Text = "--";
            // 
            // frmventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 445);
            this.Controls.Add(this.cmbfactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dtpfechav);
            this.Controls.Add(this.cmbempleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmventa";
            this.Text = "frmventa";
            this.Load += new System.EventHandler(this.frmventa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstproductos;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.ComboBox cmbempleado;
        private System.Windows.Forms.DateTimePicker dtpfechav;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.ComboBox cmbfactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbventa;
        private System.Windows.Forms.Label lbtam;
    }
}