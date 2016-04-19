namespace Cristalhelado
{
    partial class frminsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminsumos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.dtpfechainsu = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbInsumos = new System.Windows.Forms.ComboBox();
            this.btnINSUMOACTUALIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 227);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(117, 23);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(172, 118);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 8;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(172, 164);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 9;
            // 
            // dtpfechainsu
            // 
            this.dtpfechainsu.CustomFormat = "yyyy-MM-dd";
            this.dtpfechainsu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechainsu.Location = new System.Drawing.Point(172, 73);
            this.dtpfechainsu.Name = "dtpfechainsu";
            this.dtpfechainsu.Size = new System.Drawing.Size(100, 20);
            this.dtpfechainsu.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbInsumos
            // 
            this.cmbInsumos.FormattingEnabled = true;
            this.cmbInsumos.Items.AddRange(new object[] {
            "Dorada",
            "Plateada",
            "Roja",
            "Gancho",
            "Cartón"});
            this.cmbInsumos.Location = new System.Drawing.Point(151, 30);
            this.cmbInsumos.Name = "cmbInsumos";
            this.cmbInsumos.Size = new System.Drawing.Size(121, 21);
            this.cmbInsumos.TabIndex = 12;
            // 
            // btnINSUMOACTUALIZAR
            // 
            this.btnINSUMOACTUALIZAR.Location = new System.Drawing.Point(155, 227);
            this.btnINSUMOACTUALIZAR.Name = "btnINSUMOACTUALIZAR";
            this.btnINSUMOACTUALIZAR.Size = new System.Drawing.Size(117, 23);
            this.btnINSUMOACTUALIZAR.TabIndex = 13;
            this.btnINSUMOACTUALIZAR.Text = "Eliminar";
            this.btnINSUMOACTUALIZAR.UseVisualStyleBackColor = true;
            this.btnINSUMOACTUALIZAR.Click += new System.EventHandler(this.btnINSUMOACTUALIZAR_Click);
            // 
            // frminsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(652, 297);
            this.Controls.Add(this.btnINSUMOACTUALIZAR);
            this.Controls.Add(this.cmbInsumos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpfechainsu);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frminsumos";
            this.Text = "INSUMOS";
            this.Load += new System.EventHandler(this.frminsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.DateTimePicker dtpfechainsu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbInsumos;
        private System.Windows.Forms.Button btnINSUMOACTUALIZAR;
    }
}