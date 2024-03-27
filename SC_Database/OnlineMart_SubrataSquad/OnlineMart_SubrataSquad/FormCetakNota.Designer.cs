
namespace OnlineMart_SubrataSquad
{
    partial class FormCetakNota
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCetak = new System.Windows.Forms.ComboBox();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.dataGridViewCetakNota = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCetakNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Print as :";
            // 
            // comboBoxCetak
            // 
            this.comboBoxCetak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCetak.FormattingEnabled = true;
            this.comboBoxCetak.Items.AddRange(new object[] {
            "PDF",
            "PRINT HARDCOPY"});
            this.comboBoxCetak.Location = new System.Drawing.Point(67, 357);
            this.comboBoxCetak.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCetak.Name = "comboBoxCetak";
            this.comboBoxCetak.Size = new System.Drawing.Size(416, 21);
            this.comboBoxCetak.TabIndex = 34;
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonCetak.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.White;
            this.buttonCetak.Location = new System.Drawing.Point(308, 381);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(86, 32);
            this.buttonCetak.TabIndex = 32;
            this.buttonCetak.Text = "&PRINT";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // dataGridViewCetakNota
            // 
            this.dataGridViewCetakNota.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCetakNota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCetakNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCetakNota.Location = new System.Drawing.Point(7, 66);
            this.dataGridViewCetakNota.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCetakNota.Name = "dataGridViewCetakNota";
            this.dataGridViewCetakNota.RowHeadersWidth = 51;
            this.dataGridViewCetakNota.RowTemplate.Height = 24;
            this.dataGridViewCetakNota.Size = new System.Drawing.Size(477, 288);
            this.dataGridViewCetakNota.TabIndex = 31;
            this.dataGridViewCetakNota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCetakNota_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 49);
            this.label1.TabIndex = 29;
            this.label1.Text = "PRINT BILL PAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(399, 381);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(86, 32);
            this.buttonKeluar.TabIndex = 30;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormCetakNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(492, 418);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCetak);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.dataGridViewCetakNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCetakNota";
            this.Load += new System.EventHandler(this.FormCetakNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCetakNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCetak;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.DataGridView dataGridViewCetakNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}