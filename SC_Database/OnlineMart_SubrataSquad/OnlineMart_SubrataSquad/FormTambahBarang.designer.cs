
namespace OnlineMart_SubrataSquad
{
    partial class FormTambahBarang
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
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.comboBoxKategoriBarang = new System.Windows.Forms.ComboBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.textBoxHargaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(11, 277);
            this.dataGridViewBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 51;
            this.dataGridViewBarang.RowTemplate.Height = 24;
            this.dataGridViewBarang.Size = new System.Drawing.Size(463, 235);
            this.dataGridViewBarang.TabIndex = 31;
            this.dataGridViewBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBarang_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 49);
            this.label1.TabIndex = 28;
            this.label1.Text = "ADD ITEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(385, 516);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 30;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // comboBoxKategoriBarang
            // 
            this.comboBoxKategoriBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.comboBoxKategoriBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategoriBarang.FormattingEnabled = true;
            this.comboBoxKategoriBarang.Items.AddRange(new object[] {
            "Kode Kategori"});
            this.comboBoxKategoriBarang.Location = new System.Drawing.Point(144, 130);
            this.comboBoxKategoriBarang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategoriBarang.Name = "comboBoxKategoriBarang";
            this.comboBoxKategoriBarang.Size = new System.Drawing.Size(311, 21);
            this.comboBoxKategoriBarang.TabIndex = 7;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxNamaBarang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNamaBarang.Location = new System.Drawing.Point(144, 32);
            this.textBoxNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(311, 24);
            this.textBoxNamaBarang.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item Cathegory :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.buttonKosongi);
            this.panel1.Controls.Add(this.buttonTambah);
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBoxBarang);
            this.panel1.Controls.Add(this.textBoxHargaBarang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxKategoriBarang);
            this.panel1.Controls.Add(this.textBoxNamaBarang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 208);
            this.panel1.TabIndex = 29;
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(361, 161);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(94, 40);
            this.buttonKosongi.TabIndex = 28;
            this.buttonKosongi.Text = "&CLEAR";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(266, 161);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(90, 41);
            this.buttonTambah.TabIndex = 24;
            this.buttonTambah.Text = "&SAVE";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonBrowse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Location = new System.Drawing.Point(5, 169);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(118, 32);
            this.buttonBrowse.TabIndex = 25;
            this.buttonBrowse.Text = "&BROWSE";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Price :";
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pictureBoxBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBarang.Image = global::OnlineMart_SubrataSquad.Properties.Resources.poster1_3;
            this.pictureBoxBarang.Location = new System.Drawing.Point(7, 9);
            this.pictureBoxBarang.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(117, 157);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarang.TabIndex = 28;
            this.pictureBoxBarang.TabStop = false;
            // 
            // textBoxHargaBarang
            // 
            this.textBoxHargaBarang.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxHargaBarang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxHargaBarang.Location = new System.Drawing.Point(144, 83);
            this.textBoxHargaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHargaBarang.Name = "textBoxHargaBarang";
            this.textBoxHargaBarang.Size = new System.Drawing.Size(311, 24);
            this.textBoxHargaBarang.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Name :";
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 567);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormTambahBarang";
            this.Load += new System.EventHandler(this.FormTambahBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.ComboBox comboBoxKategoriBarang;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private System.Windows.Forms.TextBox textBoxHargaBarang;
        private System.Windows.Forms.Label label2;
    }
}