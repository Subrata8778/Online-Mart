
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanHadiah
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
            this.dataGridViewPengaturanHadiah = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCBPengaturanHadiah = new System.Windows.Forms.ComboBox();
            this.textBoxCBPengaturanHadiah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanHadiah)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanHadiah
            // 
            this.dataGridViewPengaturanHadiah.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPengaturanHadiah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanHadiah.Location = new System.Drawing.Point(8, 154);
            this.dataGridViewPengaturanHadiah.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPengaturanHadiah.Name = "dataGridViewPengaturanHadiah";
            this.dataGridViewPengaturanHadiah.RowHeadersWidth = 51;
            this.dataGridViewPengaturanHadiah.RowTemplate.Height = 24;
            this.dataGridViewPengaturanHadiah.Size = new System.Drawing.Size(420, 239);
            this.dataGridViewPengaturanHadiah.TabIndex = 38;
            this.dataGridViewPengaturanHadiah.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanHadiah_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxCBPengaturanHadiah);
            this.panel1.Controls.Add(this.textBoxCBPengaturanHadiah);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 80);
            this.panel1.TabIndex = 36;
            // 
            // comboBoxCBPengaturanHadiah
            // 
            this.comboBoxCBPengaturanHadiah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanHadiah.FormattingEnabled = true;
            this.comboBoxCBPengaturanHadiah.Items.AddRange(new object[] {
            "ID Hadiah",
            "Nama Hadiah",
            "Jumlah Poin"});
            this.comboBoxCBPengaturanHadiah.Location = new System.Drawing.Point(110, 15);
            this.comboBoxCBPengaturanHadiah.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCBPengaturanHadiah.Name = "comboBoxCBPengaturanHadiah";
            this.comboBoxCBPengaturanHadiah.Size = new System.Drawing.Size(283, 21);
            this.comboBoxCBPengaturanHadiah.TabIndex = 7;
            // 
            // textBoxCBPengaturanHadiah
            // 
            this.textBoxCBPengaturanHadiah.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanHadiah.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanHadiah.Location = new System.Drawing.Point(110, 40);
            this.textBoxCBPengaturanHadiah.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBPengaturanHadiah.Name = "textBoxCBPengaturanHadiah";
            this.textBoxCBPengaturanHadiah.Size = new System.Drawing.Size(283, 24);
            this.textBoxCBPengaturanHadiah.TabIndex = 6;
            this.textBoxCBPengaturanHadiah.Text = "Type Here...";
            this.textBoxCBPengaturanHadiah.TextChanged += new System.EventHandler(this.textBoxCBPengaturanHadiah_TextChanged);
            this.textBoxCBPengaturanHadiah.Enter += new System.EventHandler(this.textBoxCBPengaturanHadiah_Enter);
            this.textBoxCBPengaturanHadiah.Leave += new System.EventHandler(this.textBoxCBPengaturanHadiah_Leave);
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
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(243, 396);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(90, 41);
            this.buttonTambah.TabIndex = 39;
            this.buttonTambah.Text = "&ADD";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
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
            this.label1.TabIndex = 35;
            this.label1.Text = "GIFTS SETTING";
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
            this.buttonKeluar.TabIndex = 37;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click_1);
            // 
            // FormPengaturanHadiah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(433, 439);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewPengaturanHadiah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPengaturanHadiah";
            this.Load += new System.EventHandler(this.FormPengaturanHadiah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanHadiah)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanHadiah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanHadiah;
        private System.Windows.Forms.TextBox textBoxCBPengaturanHadiah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}