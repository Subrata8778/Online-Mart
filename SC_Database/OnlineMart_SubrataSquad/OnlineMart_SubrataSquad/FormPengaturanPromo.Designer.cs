
namespace OnlineMart_SubrataSquad
{
    partial class FormPengaturanPromo
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
            this.dataGridViewPengaturanPromo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPengaturanPromo = new System.Windows.Forms.ComboBox();
            this.textBoxPengaturanPromo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanPromo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPengaturanPromo
            // 
            this.dataGridViewPengaturanPromo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPengaturanPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPengaturanPromo.Location = new System.Drawing.Point(11, 157);
            this.dataGridViewPengaturanPromo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPengaturanPromo.Name = "dataGridViewPengaturanPromo";
            this.dataGridViewPengaturanPromo.RowHeadersWidth = 51;
            this.dataGridViewPengaturanPromo.RowTemplate.Height = 24;
            this.dataGridViewPengaturanPromo.Size = new System.Drawing.Size(420, 239);
            this.dataGridViewPengaturanPromo.TabIndex = 43;
            this.dataGridViewPengaturanPromo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengaturanPromo_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxPengaturanPromo);
            this.panel1.Controls.Add(this.textBoxPengaturanPromo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(11, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 80);
            this.panel1.TabIndex = 41;
            // 
            // comboBoxPengaturanPromo
            // 
            this.comboBoxPengaturanPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPengaturanPromo.FormattingEnabled = true;
            this.comboBoxPengaturanPromo.Items.AddRange(new object[] {
            "ID Promo",
            "Tipe Promo",
            "Nama Promo",
            "Diskon Promo",
            "Diskon Max",
            "Minimal Belanja"});
            this.comboBoxPengaturanPromo.Location = new System.Drawing.Point(95, 15);
            this.comboBoxPengaturanPromo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPengaturanPromo.Name = "comboBoxPengaturanPromo";
            this.comboBoxPengaturanPromo.Size = new System.Drawing.Size(311, 21);
            this.comboBoxPengaturanPromo.TabIndex = 7;
            // 
            // textBoxPengaturanPromo
            // 
            this.textBoxPengaturanPromo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPengaturanPromo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPengaturanPromo.Location = new System.Drawing.Point(95, 37);
            this.textBoxPengaturanPromo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPengaturanPromo.Name = "textBoxPengaturanPromo";
            this.textBoxPengaturanPromo.Size = new System.Drawing.Size(311, 24);
            this.textBoxPengaturanPromo.TabIndex = 6;
            this.textBoxPengaturanPromo.Text = "Type Here...";
            this.textBoxPengaturanPromo.TextChanged += new System.EventHandler(this.textBoxPengaturanPromo_TextChanged);
            this.textBoxPengaturanPromo.Enter += new System.EventHandler(this.textBoxPengaturanPromo_Enter);
            this.textBoxPengaturanPromo.Leave += new System.EventHandler(this.textBoxPengaturanPromo_Leave);
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
            this.buttonTambah.Location = new System.Drawing.Point(249, 400);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(90, 41);
            this.buttonTambah.TabIndex = 44;
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
            this.label1.TabIndex = 40;
            this.label1.Text = "PROMOS SETTING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(343, 400);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 41);
            this.buttonKeluar.TabIndex = 42;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormPengaturanPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(438, 445);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewPengaturanPromo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPengaturanPromo";
            this.Load += new System.EventHandler(this.FormPengaturanPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengaturanPromo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPengaturanPromo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPengaturanPromo;
        private System.Windows.Forms.TextBox textBoxPengaturanPromo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}