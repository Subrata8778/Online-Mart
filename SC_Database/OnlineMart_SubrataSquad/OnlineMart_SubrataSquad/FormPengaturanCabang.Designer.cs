
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanCabang
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
            this.dataGridViewPengaturanCabang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCBPengaturanCabang = new System.Windows.Forms.ComboBox();
            this.textBoxCBPengaturanCabang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanCabang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanCabang
            // 
            this.dataGridViewPengaturanCabang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPengaturanCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanCabang.Location = new System.Drawing.Point(8, 153);
            this.dataGridViewPengaturanCabang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPengaturanCabang.Name = "dataGridViewPengaturanCabang";
            this.dataGridViewPengaturanCabang.RowHeadersWidth = 51;
            this.dataGridViewPengaturanCabang.RowTemplate.Height = 24;
            this.dataGridViewPengaturanCabang.Size = new System.Drawing.Size(420, 239);
            this.dataGridViewPengaturanCabang.TabIndex = 16;
            this.dataGridViewPengaturanCabang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanCabang_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxCBPengaturanCabang);
            this.panel1.Controls.Add(this.textBoxCBPengaturanCabang);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 80);
            this.panel1.TabIndex = 14;
            // 
            // comboBoxCBPengaturanCabang
            // 
            this.comboBoxCBPengaturanCabang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanCabang.FormattingEnabled = true;
            this.comboBoxCBPengaturanCabang.Items.AddRange(new object[] {
            "ID Cabang",
            "Nama Cabang",
            "Alamat Cabang",
            "Pegawai"});
            this.comboBoxCBPengaturanCabang.Location = new System.Drawing.Point(110, 15);
            this.comboBoxCBPengaturanCabang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCBPengaturanCabang.Name = "comboBoxCBPengaturanCabang";
            this.comboBoxCBPengaturanCabang.Size = new System.Drawing.Size(291, 21);
            this.comboBoxCBPengaturanCabang.TabIndex = 7;
            // 
            // textBoxCBPengaturanCabang
            // 
            this.textBoxCBPengaturanCabang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanCabang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanCabang.Location = new System.Drawing.Point(110, 40);
            this.textBoxCBPengaturanCabang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBPengaturanCabang.Name = "textBoxCBPengaturanCabang";
            this.textBoxCBPengaturanCabang.Size = new System.Drawing.Size(291, 24);
            this.textBoxCBPengaturanCabang.TabIndex = 6;
            this.textBoxCBPengaturanCabang.Text = "Type Here...";
            this.textBoxCBPengaturanCabang.TextChanged += new System.EventHandler(this.textBoxCBPengaturanCabang_TextChanged);
            this.textBoxCBPengaturanCabang.Enter += new System.EventHandler(this.textBoxCBPengaturanCabang_Enter);
            this.textBoxCBPengaturanCabang.Leave += new System.EventHandler(this.textBoxCBPengaturanCabang_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search By:";
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
            this.label1.Text = "BRANCHS SETTING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(338, 396);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 15;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(244, 395);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(90, 41);
            this.buttonTambah.TabIndex = 29;
            this.buttonTambah.Text = "&ADD";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormPengaturanCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(433, 444);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewPengaturanCabang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPengaturanCabang";
            this.Load += new System.EventHandler(this.FormPengaturanCabang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanCabang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanCabang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanCabang;
        private System.Windows.Forms.TextBox textBoxCBPengaturanCabang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
    }
}