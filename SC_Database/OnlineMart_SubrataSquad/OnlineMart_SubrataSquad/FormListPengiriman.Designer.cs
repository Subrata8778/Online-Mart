
namespace OnlineMart_SubrataSquad
{
    partial class FormListPengiriman
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
            this.comboBoxCBListPengiriman = new System.Windows.Forms.ComboBox();
            this.textBoxCBListPengiriman = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewListPengiriman = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPengiriman)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxCBListPengiriman);
            this.panel1.Controls.Add(this.textBoxCBListPengiriman);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(9, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 88);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxCBListPengiriman
            // 
            this.comboBoxCBListPengiriman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCBListPengiriman.FormattingEnabled = true;
            this.comboBoxCBListPengiriman.Items.AddRange(new object[] {
            "ID Order"});
            this.comboBoxCBListPengiriman.Location = new System.Drawing.Point(100, 19);
            this.comboBoxCBListPengiriman.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxCBListPengiriman.Name = "comboBoxCBListPengiriman";
            this.comboBoxCBListPengiriman.Size = new System.Drawing.Size(299, 21);
            this.comboBoxCBListPengiriman.TabIndex = 1;
            // 
            // textBoxCBListPengiriman
            // 
            this.textBoxCBListPengiriman.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCBListPengiriman.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCBListPengiriman.Location = new System.Drawing.Point(100, 43);
            this.textBoxCBListPengiriman.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxCBListPengiriman.Name = "textBoxCBListPengiriman";
            this.textBoxCBListPengiriman.Size = new System.Drawing.Size(299, 24);
            this.textBoxCBListPengiriman.TabIndex = 2;
            this.textBoxCBListPengiriman.Text = "Type Here...";
            this.textBoxCBListPengiriman.TextChanged += new System.EventHandler(this.textBoxCBListPengiriman_TextChanged);
            this.textBoxCBListPengiriman.Enter += new System.EventHandler(this.textBoxCBListPengiriman_Enter);
            this.textBoxCBListPengiriman.Leave += new System.EventHandler(this.textBoxCBListPengiriman_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search By:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHIPPING LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(339, 392);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(90, 40);
            this.buttonKeluar.TabIndex = 3;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewListPengiriman
            // 
            this.dataGridViewListPengiriman.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListPengiriman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPengiriman.Location = new System.Drawing.Point(9, 149);
            this.dataGridViewListPengiriman.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridViewListPengiriman.Name = "dataGridViewListPengiriman";
            this.dataGridViewListPengiriman.RowHeadersWidth = 51;
            this.dataGridViewListPengiriman.RowTemplate.Height = 24;
            this.dataGridViewListPengiriman.Size = new System.Drawing.Size(420, 232);
            this.dataGridViewListPengiriman.TabIndex = 2;
            this.dataGridViewListPengiriman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListPengiriman_CellContentClick);
            // 
            // FormListPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(436, 435);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewListPengiriman);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormListPengiriman";
            this.Load += new System.EventHandler(this.FormListPengiriman_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPengiriman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxCBListPengiriman;
        private System.Windows.Forms.TextBox textBoxCBListPengiriman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        public System.Windows.Forms.DataGridView dataGridViewListPengiriman;
    }
}