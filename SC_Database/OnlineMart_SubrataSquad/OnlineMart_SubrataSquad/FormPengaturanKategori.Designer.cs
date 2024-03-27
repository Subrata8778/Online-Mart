
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanKategori
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
            this.dataGridViewPengaturanKategori = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCBPengaturanKategori = new System.Windows.Forms.ComboBox();
            this.textBoxCBPengaturanKategori = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanKategori)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanKategori
            // 
            this.dataGridViewPengaturanKategori.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPengaturanKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanKategori.Location = new System.Drawing.Point(8, 154);
            this.dataGridViewPengaturanKategori.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPengaturanKategori.Name = "dataGridViewPengaturanKategori";
            this.dataGridViewPengaturanKategori.RowHeadersWidth = 51;
            this.dataGridViewPengaturanKategori.RowTemplate.Height = 24;
            this.dataGridViewPengaturanKategori.Size = new System.Drawing.Size(420, 239);
            this.dataGridViewPengaturanKategori.TabIndex = 20;
            this.dataGridViewPengaturanKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanKategori_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxCBPengaturanKategori);
            this.panel1.Controls.Add(this.textBoxCBPengaturanKategori);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(8, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 80);
            this.panel1.TabIndex = 18;
            // 
            // comboBoxCBPengaturanKategori
            // 
            this.comboBoxCBPengaturanKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanKategori.FormattingEnabled = true;
            this.comboBoxCBPengaturanKategori.Items.AddRange(new object[] {
            "Kode Kategori",
            "Nama Kategori"});
            this.comboBoxCBPengaturanKategori.Location = new System.Drawing.Point(95, 15);
            this.comboBoxCBPengaturanKategori.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCBPengaturanKategori.Name = "comboBoxCBPengaturanKategori";
            this.comboBoxCBPengaturanKategori.Size = new System.Drawing.Size(307, 21);
            this.comboBoxCBPengaturanKategori.TabIndex = 7;
            // 
            // textBoxCBPengaturanKategori
            // 
            this.textBoxCBPengaturanKategori.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanKategori.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanKategori.Location = new System.Drawing.Point(95, 37);
            this.textBoxCBPengaturanKategori.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBPengaturanKategori.Name = "textBoxCBPengaturanKategori";
            this.textBoxCBPengaturanKategori.Size = new System.Drawing.Size(307, 24);
            this.textBoxCBPengaturanKategori.TabIndex = 6;
            this.textBoxCBPengaturanKategori.Text = "Type Here...";
            this.textBoxCBPengaturanKategori.TextChanged += new System.EventHandler(this.textBoxCBPengaturanKategori_TextChanged);
            this.textBoxCBPengaturanKategori.Enter += new System.EventHandler(this.textBoxCBPengaturanKategori_Enter);
            this.textBoxCBPengaturanKategori.Leave += new System.EventHandler(this.textBoxCBPengaturanKategori_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
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
            this.label1.TabIndex = 17;
            this.label1.Text = "CATEGORIES SETTING";
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
            this.buttonKeluar.TabIndex = 19;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(244, 397);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(90, 41);
            this.buttonTambah.TabIndex = 27;
            this.buttonTambah.Text = "&ADD";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormPengaturanKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(432, 437);
            this.ControlBox = false;
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewPengaturanKategori);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPengaturanKategori";
            this.Load += new System.EventHandler(this.FormPengaturanKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanKategori)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanKategori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanKategori;
        private System.Windows.Forms.TextBox textBoxCBPengaturanKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
    }
}