
namespace OnlineMart_SubrataSquad
{
    partial class FormTambahBarangKeKeranjang
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCabang = new System.Windows.Forms.Label();
            this.labelIdBarang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownJumlahBarang = new System.Windows.Forms.NumericUpDown();
            this.labelKategoriBarang = new System.Windows.Forms.Label();
            this.labelHargaBarang = new System.Windows.Forms.Label();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlahBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 28;
            this.label1.Text = "ADD ITEM TO CART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(339, 256);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 30;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item Category:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelCabang);
            this.panel1.Controls.Add(this.labelIdBarang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDownJumlahBarang);
            this.panel1.Controls.Add(this.labelKategoriBarang);
            this.panel1.Controls.Add(this.labelHargaBarang);
            this.panel1.Controls.Add(this.labelNamaBarang);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(9, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 170);
            this.panel1.TabIndex = 29;
            // 
            // labelCabang
            // 
            this.labelCabang.AutoSize = true;
            this.labelCabang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCabang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCabang.Location = new System.Drawing.Point(124, 115);
            this.labelCabang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCabang.Name = "labelCabang";
            this.labelCabang.Size = new System.Drawing.Size(109, 14);
            this.labelCabang.TabIndex = 20;
            this.labelCabang.Text = "label Nama Cabang";
            // 
            // labelIdBarang
            // 
            this.labelIdBarang.AutoSize = true;
            this.labelIdBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdBarang.Location = new System.Drawing.Point(124, 12);
            this.labelIdBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdBarang.Name = "labelIdBarang";
            this.labelIdBarang.Size = new System.Drawing.Size(87, 14);
            this.labelIdBarang.TabIndex = 19;
            this.labelIdBarang.Text = "label Id Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Item ID:";
            // 
            // numericUpDownJumlahBarang
            // 
            this.numericUpDownJumlahBarang.Location = new System.Drawing.Point(127, 138);
            this.numericUpDownJumlahBarang.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownJumlahBarang.Name = "numericUpDownJumlahBarang";
            this.numericUpDownJumlahBarang.Size = new System.Drawing.Size(117, 20);
            this.numericUpDownJumlahBarang.TabIndex = 17;
            // 
            // labelKategoriBarang
            // 
            this.labelKategoriBarang.AutoSize = true;
            this.labelKategoriBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategoriBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelKategoriBarang.Location = new System.Drawing.Point(124, 89);
            this.labelKategoriBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKategoriBarang.Name = "labelKategoriBarang";
            this.labelKategoriBarang.Size = new System.Drawing.Size(121, 14);
            this.labelKategoriBarang.TabIndex = 15;
            this.labelKategoriBarang.Text = "label Kategori Barang";
            // 
            // labelHargaBarang
            // 
            this.labelHargaBarang.AutoSize = true;
            this.labelHargaBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHargaBarang.Location = new System.Drawing.Point(124, 63);
            this.labelHargaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHargaBarang.Name = "labelHargaBarang";
            this.labelHargaBarang.Size = new System.Drawing.Size(107, 14);
            this.labelHargaBarang.TabIndex = 14;
            this.labelHargaBarang.Text = "label Harga Barang";
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNamaBarang.Location = new System.Drawing.Point(124, 37);
            this.labelNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(106, 14);
            this.labelNamaBarang.TabIndex = 13;
            this.labelNamaBarang.Text = "label Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Name:";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(244, 256);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(90, 41);
            this.buttonTambah.TabIndex = 31;
            this.buttonTambah.Text = "&SAVE";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormTambahBarangKeKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(435, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahBarangKeKeranjang";
            this.Text = "FormTambahBarangKeKeranjang";
            this.Load += new System.EventHandler(this.FormTambahBarangKeKeranjang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJumlahBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numericUpDownJumlahBarang;
        public System.Windows.Forms.Label labelKategoriBarang;
        public System.Windows.Forms.Label labelHargaBarang;
        public System.Windows.Forms.Label labelNamaBarang;
        public System.Windows.Forms.Label labelIdBarang;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelCabang;
    }
}