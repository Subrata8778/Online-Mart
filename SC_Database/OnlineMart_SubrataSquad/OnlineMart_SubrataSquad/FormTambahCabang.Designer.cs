
namespace OnlineMart_SubrataSquad
{
    partial class FormTambahCabang
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
            this.textBoxIDCabang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPegawai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlamatCabang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNamaCabang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 22;
            this.label1.Text = "ADD BRANCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(338, 228);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 24;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // textBoxIDCabang
            // 
            this.textBoxIDCabang.Enabled = false;
            this.textBoxIDCabang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIDCabang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDCabang.Location = new System.Drawing.Point(154, 11);
            this.textBoxIDCabang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDCabang.Name = "textBoxIDCabang";
            this.textBoxIDCabang.Size = new System.Drawing.Size(246, 24);
            this.textBoxIDCabang.TabIndex = 6;
            this.textBoxIDCabang.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Branch ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxPegawai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxAlamatCabang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNamaCabang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxIDCabang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 154);
            this.panel1.TabIndex = 23;
            // 
            // comboBoxPegawai
            // 
            this.comboBoxPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPegawai.FormattingEnabled = true;
            this.comboBoxPegawai.Location = new System.Drawing.Point(154, 120);
            this.comboBoxPegawai.Name = "comboBoxPegawai";
            this.comboBoxPegawai.Size = new System.Drawing.Size(246, 21);
            this.comboBoxPegawai.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee:";
            // 
            // textBoxAlamatCabang
            // 
            this.textBoxAlamatCabang.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxAlamatCabang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxAlamatCabang.Location = new System.Drawing.Point(154, 67);
            this.textBoxAlamatCabang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAlamatCabang.Multiline = true;
            this.textBoxAlamatCabang.Name = "textBoxAlamatCabang";
            this.textBoxAlamatCabang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamatCabang.Size = new System.Drawing.Size(246, 47);
            this.textBoxAlamatCabang.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Branch Address:";
            // 
            // textBoxNamaCabang
            // 
            this.textBoxNamaCabang.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxNamaCabang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNamaCabang.Location = new System.Drawing.Point(154, 39);
            this.textBoxNamaCabang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaCabang.Name = "textBoxNamaCabang";
            this.textBoxNamaCabang.Size = new System.Drawing.Size(246, 24);
            this.textBoxNamaCabang.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Branch Name:";
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(211, 228);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(105, 41);
            this.buttonKosongi.TabIndex = 26;
            this.buttonKosongi.Text = "&CLEAR";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(116, 228);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(90, 41);
            this.buttonSimpan.TabIndex = 25;
            this.buttonSimpan.Text = "&SAVE";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // FormTambahCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(435, 275);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahCabang";
            this.Load += new System.EventHandler(this.FormTambahCabang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.TextBox textBoxIDCabang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlamatCabang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNamaCabang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.ComboBox comboBoxPegawai;
    }
}