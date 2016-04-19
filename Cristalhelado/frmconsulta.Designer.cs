namespace Cristalhelado
{
    partial class frmconsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmconsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbconsulta = new System.Windows.Forms.ComboBox();
            this.lbusuario = new System.Windows.Forms.Label();
            this.cmbusuario = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la consulta:";
            // 
            // cmbconsulta
            // 
            this.cmbconsulta.FormattingEnabled = true;
            this.cmbconsulta.Items.AddRange(new object[] {
            "Todas las ventas",
            "Ventas con factura",
            "Ventas por empleado",
            "Insumos disponibles"});
            this.cmbconsulta.Location = new System.Drawing.Point(169, 25);
            this.cmbconsulta.Name = "cmbconsulta";
            this.cmbconsulta.Size = new System.Drawing.Size(121, 21);
            this.cmbconsulta.TabIndex = 1;
            this.cmbconsulta.SelectedIndexChanged += new System.EventHandler(this.cmbconsulta_SelectedIndexChanged);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(23, 74);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(46, 13);
            this.lbusuario.TabIndex = 2;
            this.lbusuario.Text = "Usuario:";
            this.lbusuario.Visible = false;
            // 
            // cmbusuario
            // 
            this.cmbusuario.FormattingEnabled = true;
            this.cmbusuario.Location = new System.Drawing.Point(169, 66);
            this.cmbusuario.Name = "cmbusuario";
            this.cmbusuario.Size = new System.Drawing.Size(121, 21);
            this.cmbusuario.TabIndex = 3;
            this.cmbusuario.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(553, 132);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(309, 43);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 5;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(553, 121);
            this.dataGridView2.TabIndex = 7;
            // 
            // frmconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 441);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbusuario);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.cmbconsulta);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "frmconsulta";
            this.Text = "CONSULTAS";
            this.Load += new System.EventHandler(this.frmconsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbconsulta;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.ComboBox cmbusuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}