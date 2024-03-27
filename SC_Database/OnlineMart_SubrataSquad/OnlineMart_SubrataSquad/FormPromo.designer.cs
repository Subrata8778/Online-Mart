
namespace OnlineMart_SubrataSquad
{
    partial class FormPromo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxDeals = new System.Windows.Forms.ComboBox();
            this.textBoxDeals = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewDeals = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxDeals);
            this.panel1.Controls.Add(this.textBoxDeals);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 88);
            this.panel1.TabIndex = 10;
            // 
            // comboBoxDeals
            // 
            this.comboBoxDeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeals.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDeals.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDeals.FormattingEnabled = true;
            this.comboBoxDeals.Items.AddRange(new object[] {
            "Kode Deals",
            "Tipe Deals",
            "Nama Deals",
            "Diskon",
            "Diskon Max",
            "Minimal Belanja"});
            this.comboBoxDeals.Location = new System.Drawing.Point(89, 17);
            this.comboBoxDeals.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDeals.Name = "comboBoxDeals";
            this.comboBoxDeals.Size = new System.Drawing.Size(374, 25);
            this.comboBoxDeals.TabIndex = 7;
            // 
            // textBoxDeals
            // 
            this.textBoxDeals.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeals.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDeals.Location = new System.Drawing.Point(89, 46);
            this.textBoxDeals.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeals.Name = "textBoxDeals";
            this.textBoxDeals.Size = new System.Drawing.Size(374, 24);
            this.textBoxDeals.TabIndex = 6;
            this.textBoxDeals.Text = "Type Here...";
            this.textBoxDeals.TextChanged += new System.EventHandler(this.textBoxDeals_TextChanged);
            this.textBoxDeals.Enter += new System.EventHandler(this.textBoxDeals_Enter);
            this.textBoxDeals.Leave += new System.EventHandler(this.textBoxDeals_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "HALAMAN PROMO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(411, 394);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(75, 32);
            this.buttonKeluar.TabIndex = 12;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewDeals
            // 
            this.dataGridViewDeals.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeals.Location = new System.Drawing.Point(9, 165);
            this.dataGridViewDeals.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeals.Name = "dataGridViewDeals";
            this.dataGridViewDeals.RowHeadersWidth = 51;
            this.dataGridViewDeals.RowTemplate.Height = 24;
            this.dataGridViewDeals.Size = new System.Drawing.Size(477, 224);
            this.dataGridViewDeals.TabIndex = 13;
            // 
            // FormPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(496, 435);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewDeals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPromo";
            this.Load += new System.EventHandler(this.FormPromo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDeals;
        private System.Windows.Forms.TextBox textBoxDeals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewDeals;
    }
}