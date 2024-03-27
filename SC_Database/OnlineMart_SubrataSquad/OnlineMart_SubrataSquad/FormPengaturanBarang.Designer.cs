
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanBarang
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
            this.dataGridViewPengaturanBarang = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCBPengaturanBarang = new System.Windows.Forms.TextBox();
            this.comboBoxCBPengaturanBarang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTambahBarangCabang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanBarang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanBarang
            // 
            this.dataGridViewPengaturanBarang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPengaturanBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanBarang.Location = new System.Drawing.Point(11, 156);
            this.dataGridViewPengaturanBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPengaturanBarang.Name = "dataGridViewPengaturanBarang";
            this.dataGridViewPengaturanBarang.RowHeadersWidth = 51;
            this.dataGridViewPengaturanBarang.RowTemplate.Height = 24;
            this.dataGridViewPengaturanBarang.Size = new System.Drawing.Size(420, 239);
            this.dataGridViewPengaturanBarang.TabIndex = 33;
            this.dataGridViewPengaturanBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanBarang_CellContentClick);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(212, 398);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 41);
            this.buttonTambah.TabIndex = 34;
            this.buttonTambah.Text = "&SET ITEM";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 30;
            this.label1.Text = "ITEMS SETTING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(341, 399);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 32;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.textBoxCBPengaturanBarang);
            this.panel2.Controls.Add(this.comboBoxCBPengaturanBarang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(11, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 80);
            this.panel2.TabIndex = 32;
            // 
            // textBoxCBPengaturanBarang
            // 
            this.textBoxCBPengaturanBarang.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanBarang.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanBarang.Location = new System.Drawing.Point(110, 37);
            this.textBoxCBPengaturanBarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBPengaturanBarang.Name = "textBoxCBPengaturanBarang";
            this.textBoxCBPengaturanBarang.Size = new System.Drawing.Size(287, 24);
            this.textBoxCBPengaturanBarang.TabIndex = 35;
            this.textBoxCBPengaturanBarang.Text = "Type Here...";
            this.textBoxCBPengaturanBarang.TextChanged += new System.EventHandler(this.textBoxCBPengaturanBarang_TextChanged);
            this.textBoxCBPengaturanBarang.Enter += new System.EventHandler(this.textBoxCBPengaturanBarang_Enter);
            this.textBoxCBPengaturanBarang.Leave += new System.EventHandler(this.textBoxCBPengaturanBarang_Leave);
            // 
            // comboBoxCBPengaturanBarang
            // 
            this.comboBoxCBPengaturanBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanBarang.FormattingEnabled = true;
            this.comboBoxCBPengaturanBarang.Items.AddRange(new object[] {
            "Nama Cabang",
            "Nama Barang"});
            this.comboBoxCBPengaturanBarang.Location = new System.Drawing.Point(110, 12);
            this.comboBoxCBPengaturanBarang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCBPengaturanBarang.Name = "comboBoxCBPengaturanBarang";
            this.comboBoxCBPengaturanBarang.Size = new System.Drawing.Size(287, 21);
            this.comboBoxCBPengaturanBarang.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search By:";
            // 
            // buttonTambahBarangCabang
            // 
            this.buttonTambahBarangCabang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambahBarangCabang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahBarangCabang.ForeColor = System.Drawing.Color.White;
            this.buttonTambahBarangCabang.Location = new System.Drawing.Point(11, 398);
            this.buttonTambahBarangCabang.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambahBarangCabang.Name = "buttonTambahBarangCabang";
            this.buttonTambahBarangCabang.Size = new System.Drawing.Size(196, 43);
            this.buttonTambahBarangCabang.TabIndex = 35;
            this.buttonTambahBarangCabang.Text = "&SET BRANCH ITEM";
            this.buttonTambahBarangCabang.UseVisualStyleBackColor = false;
            this.buttonTambahBarangCabang.Click += new System.EventHandler(this.buttonTambahBarangCabang_Click);
            // 
            // FormPengaturanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(438, 443);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTambahBarangCabang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewPengaturanBarang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPengaturanBarang";
            this.Load += new System.EventHandler(this.FormPengaturanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanBarang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanBarang;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanBarang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCBPengaturanBarang;
        private System.Windows.Forms.Button buttonTambahBarangCabang;
    }
}