
namespace OnlineMart_SubrataSquad
{
    partial class FormCekPesanan
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
            this.buttonCetakNota = new System.Windows.Forms.Button();
            this.dataGridViewCekPesanan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCetakNota
            // 
            this.buttonCetakNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonCetakNota.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetakNota.ForeColor = System.Drawing.Color.White;
            this.buttonCetakNota.Location = new System.Drawing.Point(265, 360);
            this.buttonCetakNota.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCetakNota.Name = "buttonCetakNota";
            this.buttonCetakNota.Size = new System.Drawing.Size(123, 32);
            this.buttonCetakNota.TabIndex = 40;
            this.buttonCetakNota.Text = "&PRINT BILL";
            this.buttonCetakNota.UseVisualStyleBackColor = false;
            this.buttonCetakNota.Click += new System.EventHandler(this.buttonCetakNota_Click);
            // 
            // dataGridViewCekPesanan
            // 
            this.dataGridViewCekPesanan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCekPesanan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCekPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCekPesanan.Location = new System.Drawing.Point(7, 68);
            this.dataGridViewCekPesanan.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCekPesanan.Name = "dataGridViewCekPesanan";
            this.dataGridViewCekPesanan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCekPesanan.RowTemplate.Height = 24;
            this.dataGridViewCekPesanan.Size = new System.Drawing.Size(477, 288);
            this.dataGridViewCekPesanan.TabIndex = 39;
            this.dataGridViewCekPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCekPesanan_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 49);
            this.label1.TabIndex = 37;
            this.label1.Text = "CHECK ORDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(399, 360);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(86, 32);
            this.buttonKeluar.TabIndex = 38;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormCekPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(493, 400);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCetakNota);
            this.Controls.Add(this.dataGridViewCekPesanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCekPesanan";
            this.Load += new System.EventHandler(this.FormCekPesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekPesanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCetakNota;
        private System.Windows.Forms.DataGridView dataGridViewCekPesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}