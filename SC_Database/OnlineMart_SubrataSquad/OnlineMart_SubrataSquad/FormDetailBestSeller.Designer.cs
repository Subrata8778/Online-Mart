
namespace OnlineMart_SubrataSquad
{
    partial class FormDetailBestSeller
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
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBranch = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(150, 23);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(130, 25);
            this.labelNamaBarang.TabIndex = 1;
            this.labelNamaBarang.Text = "Item Name";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategori.ForeColor = System.Drawing.Color.Green;
            this.labelKategori.Location = new System.Drawing.Point(152, 57);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(102, 16);
            this.labelKategori.TabIndex = 1;
            this.labelKategori.Text = "Item Category";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(150, 84);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(81, 19);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Item Price";
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.Location = new System.Drawing.Point(0, 23);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(144, 163);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarang.TabIndex = 0;
            this.pictureBoxBarang.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available in:";
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBranch.Location = new System.Drawing.Point(152, 148);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(46, 16);
            this.labelBranch.TabIndex = 2;
            this.labelBranch.Text = "label1";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(333, 7);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(18, 20);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxBarang);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.labelNamaBarang);
            this.panel1.Controls.Add(this.labelBranch);
            this.panel1.Controls.Add(this.labelKategori);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 197);
            this.panel1.TabIndex = 31;
            // 
            // FormDetailBestSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(376, 222);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailBestSeller";
            this.Text = "Detailed Item";
            this.Load += new System.EventHandler(this.FormDetailBestSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBranch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
    }
}