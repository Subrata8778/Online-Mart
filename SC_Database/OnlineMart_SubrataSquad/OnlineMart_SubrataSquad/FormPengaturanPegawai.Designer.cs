
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanPegawai
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
            this.dataGridViewPengaturanPegawai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCBPengaturanPegawai = new System.Windows.Forms.ComboBox();
            this.textBoxCBPengaturanKPegawai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanPegawai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanPegawai
            // 
            this.dataGridViewPengaturanPegawai.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPengaturanPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanPegawai.Location = new System.Drawing.Point(11, 157);
            this.dataGridViewPengaturanPegawai.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPengaturanPegawai.Name = "dataGridViewPengaturanPegawai";
            this.dataGridViewPengaturanPegawai.RowHeadersWidth = 51;
            this.dataGridViewPengaturanPegawai.RowTemplate.Height = 24;
            this.dataGridViewPengaturanPegawai.Size = new System.Drawing.Size(420, 239);
            this.dataGridViewPengaturanPegawai.TabIndex = 38;
            this.dataGridViewPengaturanPegawai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanPegawai_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxCBPengaturanPegawai);
            this.panel1.Controls.Add(this.textBoxCBPengaturanKPegawai);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 80);
            this.panel1.TabIndex = 36;
            // 
            // comboBoxCBPengaturanPegawai
            // 
            this.comboBoxCBPengaturanPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBPengaturanPegawai.FormattingEnabled = true;
            this.comboBoxCBPengaturanPegawai.Items.AddRange(new object[] {
            "ID Pegawai",
            "Nama Pegawai",
            "Email Pegawai",
            "Telepon Pegawai"});
            this.comboBoxCBPengaturanPegawai.Location = new System.Drawing.Point(95, 15);
            this.comboBoxCBPengaturanPegawai.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCBPengaturanPegawai.Name = "comboBoxCBPengaturanPegawai";
            this.comboBoxCBPengaturanPegawai.Size = new System.Drawing.Size(309, 21);
            this.comboBoxCBPengaturanPegawai.TabIndex = 7;
            // 
            // textBoxCBPengaturanKPegawai
            // 
            this.textBoxCBPengaturanKPegawai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBPengaturanKPegawai.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBPengaturanKPegawai.Location = new System.Drawing.Point(95, 37);
            this.textBoxCBPengaturanKPegawai.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCBPengaturanKPegawai.Name = "textBoxCBPengaturanKPegawai";
            this.textBoxCBPengaturanKPegawai.Size = new System.Drawing.Size(309, 24);
            this.textBoxCBPengaturanKPegawai.TabIndex = 6;
            this.textBoxCBPengaturanKPegawai.Text = "Type Here...";
            this.textBoxCBPengaturanKPegawai.TextChanged += new System.EventHandler(this.textBoxCBPengaturanKPegawai_TextChanged);
            this.textBoxCBPengaturanKPegawai.Enter += new System.EventHandler(this.textBoxCBPengaturanKPegawai_Enter);
            this.textBoxCBPengaturanKPegawai.Leave += new System.EventHandler(this.textBoxCBPengaturanKPegawai_Leave);
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
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(247, 400);
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
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 35;
            this.label1.Text = "EMPLOYEES SETTING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(341, 400);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 37;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormPengaturanPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewPengaturanPegawai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPengaturanPegawai";
            this.Load += new System.EventHandler(this.FormPengaturan_Pegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanPegawai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanPegawai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBPengaturanPegawai;
        private System.Windows.Forms.TextBox textBoxCBPengaturanKPegawai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}