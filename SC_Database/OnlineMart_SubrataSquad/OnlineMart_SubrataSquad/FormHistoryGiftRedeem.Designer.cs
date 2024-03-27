
namespace OnlineMart_SubrataSquad
{
    partial class FormHistoryGiftRedeem
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
            this.comboBoxHistoryGR = new System.Windows.Forms.ComboBox();
            this.textBoxHistoryGR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridHistoryGR = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryGR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxHistoryGR);
            this.panel1.Controls.Add(this.textBoxHistoryGR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 88);
            this.panel1.TabIndex = 15;
            // 
            // comboBoxHistoryGR
            // 
            this.comboBoxHistoryGR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHistoryGR.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHistoryGR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxHistoryGR.FormattingEnabled = true;
            this.comboBoxHistoryGR.Items.AddRange(new object[] {
            "ID",
            "Waktu",
            "Poin Redeem",
            "Nama Gift",
            "Order ID"});
            this.comboBoxHistoryGR.Location = new System.Drawing.Point(129, 17);
            this.comboBoxHistoryGR.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHistoryGR.Name = "comboBoxHistoryGR";
            this.comboBoxHistoryGR.Size = new System.Drawing.Size(270, 25);
            this.comboBoxHistoryGR.TabIndex = 7;
            // 
            // textBoxHistoryGR
            // 
            this.textBoxHistoryGR.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistoryGR.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxHistoryGR.Location = new System.Drawing.Point(129, 46);
            this.textBoxHistoryGR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHistoryGR.Name = "textBoxHistoryGR";
            this.textBoxHistoryGR.Size = new System.Drawing.Size(270, 24);
            this.textBoxHistoryGR.TabIndex = 6;
            this.textBoxHistoryGR.Text = "Type Here...";
            this.textBoxHistoryGR.TextChanged += new System.EventHandler(this.textBoxHistoryGR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search By:";
            // 
            // dataGridHistoryGR
            // 
            this.dataGridHistoryGR.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHistoryGR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistoryGR.Location = new System.Drawing.Point(9, 165);
            this.dataGridHistoryGR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridHistoryGR.Name = "dataGridHistoryGR";
            this.dataGridHistoryGR.RowHeadersWidth = 51;
            this.dataGridHistoryGR.RowTemplate.Height = 24;
            this.dataGridHistoryGR.Size = new System.Drawing.Size(477, 224);
            this.dataGridHistoryGR.TabIndex = 17;
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
            this.label1.TabIndex = 14;
            this.label1.Text = "HISTORY OF GIFT REDEEM";
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
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormHistoryGiftRedeem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(496, 435);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridHistoryGR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHistoryGiftRedeem";
            this.Load += new System.EventHandler(this.FormHistoryGiftRedeem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryGR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxHistoryGR;
        private System.Windows.Forms.TextBox textBoxHistoryGR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridHistoryGR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}