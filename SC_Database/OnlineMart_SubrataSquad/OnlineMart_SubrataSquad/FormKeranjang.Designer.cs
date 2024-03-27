
namespace OnlineMart_SubrataSquad
{
    partial class FormKeranjang
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.buttonCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "SHOPPING CART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(399, 392);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(86, 32);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(8, 68);
            this.dataGridViewKeranjang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(477, 319);
            this.dataGridViewKeranjang.TabIndex = 17;
            this.dataGridViewKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellContentClick);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonCheckout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonCheckout.Location = new System.Drawing.Point(295, 392);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(100, 32);
            this.buttonCheckout.TabIndex = 18;
            this.buttonCheckout.Text = "&CHECKOUT";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // FormKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(494, 431);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKeranjang";
            this.Load += new System.EventHandler(this.FormKeranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.DataGridView dataGridViewKeranjang;
        private System.Windows.Forms.Button buttonCheckout;
    }
}