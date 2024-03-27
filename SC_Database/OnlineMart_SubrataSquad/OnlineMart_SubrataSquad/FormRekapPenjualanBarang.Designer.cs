
namespace OnlineMart_SubrataSquad
{
    partial class FormRekapPenjualanBarang
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
            this.dataGridViewRekapPenjualanBarang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownTahun = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCabang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPenjualanBarang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRekapPenjualanBarang
            // 
            this.dataGridViewRekapPenjualanBarang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRekapPenjualanBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRekapPenjualanBarang.Location = new System.Drawing.Point(8, 188);
            this.dataGridViewRekapPenjualanBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRekapPenjualanBarang.Name = "dataGridViewRekapPenjualanBarang";
            this.dataGridViewRekapPenjualanBarang.RowHeadersWidth = 51;
            this.dataGridViewRekapPenjualanBarang.RowTemplate.Height = 24;
            this.dataGridViewRekapPenjualanBarang.Size = new System.Drawing.Size(420, 204);
            this.dataGridViewRekapPenjualanBarang.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.numericUpDownTahun);
            this.panel1.Controls.Add(this.comboBoxBulan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxCabang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 115);
            this.panel1.TabIndex = 14;
            // 
            // numericUpDownTahun
            // 
            this.numericUpDownTahun.Location = new System.Drawing.Point(99, 49);
            this.numericUpDownTahun.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownTahun.Minimum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.numericUpDownTahun.Name = "numericUpDownTahun";
            this.numericUpDownTahun.Size = new System.Drawing.Size(277, 20);
            this.numericUpDownTahun.TabIndex = 8;
            this.numericUpDownTahun.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDownTahun.ValueChanged += new System.EventHandler(this.numericUpDownTahun_ValueChanged);
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
            "Semua Bulan",
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBoxBulan.Location = new System.Drawing.Point(99, 74);
            this.comboBoxBulan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(277, 21);
            this.comboBoxBulan.TabIndex = 7;
            this.comboBoxBulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year:";
            // 
            // comboBoxCabang
            // 
            this.comboBoxCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCabang.FormattingEnabled = true;
            this.comboBoxCabang.Items.AddRange(new object[] {
            "Semua Cabang"});
            this.comboBoxCabang.Location = new System.Drawing.Point(99, 24);
            this.comboBoxCabang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCabang.Name = "comboBoxCabang";
            this.comboBoxCabang.Size = new System.Drawing.Size(277, 21);
            this.comboBoxCabang.TabIndex = 7;
            this.comboBoxCabang.SelectedIndexChanged += new System.EventHandler(this.comboBoxCabang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Branch:";
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
            this.label1.TabIndex = 13;
            this.label1.Text = "SELLING HISTORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(338, 397);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 15;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormRekapPenjualanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(436, 444);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewRekapPenjualanBarang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRekapPenjualanBarang";
            this.Load += new System.EventHandler(this.FormRekapPenjualanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRekapPenjualanBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRekapPenjualanBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownTahun;
        private System.Windows.Forms.ComboBox comboBoxCabang;
        private System.Windows.Forms.Label label6;
    }
}