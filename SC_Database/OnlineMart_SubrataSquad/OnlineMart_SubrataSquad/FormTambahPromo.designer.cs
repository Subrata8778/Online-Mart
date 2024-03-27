
namespace OnlineMart_SubrataSquad
{
    partial class FormTambahPromo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTipePromo = new System.Windows.Forms.ComboBox();
            this.textBoxMinimalPembelian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.textBoxMaksimalDiskon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNamaPromo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKosongi = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = "ADD PROMO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBoxTipePromo);
            this.panel1.Controls.Add(this.textBoxMinimalPembelian);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDiskon);
            this.panel1.Controls.Add(this.textBoxMaksimalDiskon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxNamaPromo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 168);
            this.panel1.TabIndex = 19;
            // 
            // comboBoxTipePromo
            // 
            this.comboBoxTipePromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipePromo.FormattingEnabled = true;
            this.comboBoxTipePromo.Items.AddRange(new object[] {
            "Ongkir",
            "Barang"});
            this.comboBoxTipePromo.Location = new System.Drawing.Point(160, 47);
            this.comboBoxTipePromo.Name = "comboBoxTipePromo";
            this.comboBoxTipePromo.Size = new System.Drawing.Size(224, 21);
            this.comboBoxTipePromo.TabIndex = 17;
            // 
            // textBoxMinimalPembelian
            // 
            this.textBoxMinimalPembelian.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxMinimalPembelian.ForeColor = System.Drawing.Color.Black;
            this.textBoxMinimalPembelian.Location = new System.Drawing.Point(160, 128);
            this.textBoxMinimalPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMinimalPembelian.Name = "textBoxMinimalPembelian";
            this.textBoxMinimalPembelian.Size = new System.Drawing.Size(224, 24);
            this.textBoxMinimalPembelian.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min Purchase:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxDiskon.ForeColor = System.Drawing.Color.Black;
            this.textBoxDiskon.Location = new System.Drawing.Point(160, 73);
            this.textBoxDiskon.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(102, 24);
            this.textBoxDiskon.TabIndex = 13;
            // 
            // textBoxMaksimalDiskon
            // 
            this.textBoxMaksimalDiskon.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxMaksimalDiskon.ForeColor = System.Drawing.Color.Black;
            this.textBoxMaksimalDiskon.Location = new System.Drawing.Point(160, 100);
            this.textBoxMaksimalDiskon.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaksimalDiskon.Name = "textBoxMaksimalDiskon";
            this.textBoxMaksimalDiskon.Size = new System.Drawing.Size(102, 24);
            this.textBoxMaksimalDiskon.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Max Discount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Discount :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Promo Type:";
            // 
            // textBoxNamaPromo
            // 
            this.textBoxNamaPromo.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxNamaPromo.ForeColor = System.Drawing.Color.Black;
            this.textBoxNamaPromo.Location = new System.Drawing.Point(160, 17);
            this.textBoxNamaPromo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaPromo.Name = "textBoxNamaPromo";
            this.textBoxNamaPromo.Size = new System.Drawing.Size(224, 24);
            this.textBoxNamaPromo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Promo Name:";
            // 
            // buttonKosongi
            // 
            this.buttonKosongi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonKosongi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKosongi.ForeColor = System.Drawing.Color.White;
            this.buttonKosongi.Location = new System.Drawing.Point(213, 253);
            this.buttonKosongi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKosongi.Name = "buttonKosongi";
            this.buttonKosongi.Size = new System.Drawing.Size(95, 41);
            this.buttonKosongi.TabIndex = 29;
            this.buttonKosongi.Text = "&CLEAR";
            this.buttonKosongi.UseVisualStyleBackColor = false;
            this.buttonKosongi.Click += new System.EventHandler(this.buttonKosongi_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(118, 253);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(90, 41);
            this.buttonSimpan.TabIndex = 28;
            this.buttonSimpan.Text = "&SAVE";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(340, 253);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 27;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormTambahPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(433, 298);
            this.ControlBox = false;
            this.Controls.Add(this.buttonKosongi);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahPromo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMinimalPembelian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.TextBox textBoxMaksimalDiskon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNamaPromo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKosongi;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.ComboBox comboBoxTipePromo;
    }
}