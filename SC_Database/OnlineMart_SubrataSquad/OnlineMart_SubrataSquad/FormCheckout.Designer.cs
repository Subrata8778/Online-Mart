
namespace OnlineMart_SubrataSquad
{
    partial class FormCheckout
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
            this.buttonBayar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBatal = new System.Windows.Forms.Button();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelOngkir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPembayaran = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPromo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDeals = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCaraPembayaran = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxKurir = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxGift = new System.Windows.Forms.ComboBox();
            this.checkBoxGift = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBayar
            // 
            this.buttonBayar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonBayar.Enabled = false;
            this.buttonBayar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBayar.ForeColor = System.Drawing.Color.White;
            this.buttonBayar.Location = new System.Drawing.Point(307, 614);
            this.buttonBayar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(91, 32);
            this.buttonBayar.TabIndex = 23;
            this.buttonBayar.Text = "&PAY";
            this.buttonBayar.UseVisualStyleBackColor = false;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 49);
            this.label1.TabIndex = 19;
            this.label1.Text = "CHECKOUT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBatal
            // 
            this.buttonBatal.BackColor = System.Drawing.Color.Red;
            this.buttonBatal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBatal.ForeColor = System.Drawing.Color.White;
            this.buttonBatal.Location = new System.Drawing.Point(402, 614);
            this.buttonBatal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonBatal.Name = "buttonBatal";
            this.buttonBatal.Size = new System.Drawing.Size(86, 32);
            this.buttonBatal.TabIndex = 21;
            this.buttonBatal.Text = "&CANCEL";
            this.buttonBatal.UseVisualStyleBackColor = false;
            this.buttonBatal.Click += new System.EventHandler(this.buttonBatal_Click);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(143, 441);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAlamat.Size = new System.Drawing.Size(344, 46);
            this.textBoxAlamat.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 441);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Address:";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHarga.Location = new System.Drawing.Point(144, 559);
            this.labelTotalHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(344, 22);
            this.labelTotalHarga.TabIndex = 36;
            this.labelTotalHarga.Text = "xxxxxxxxxxxxxxxxxxx";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 558);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total Payment:";
            // 
            // labelDiskon
            // 
            this.labelDiskon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiskon.Location = new System.Drawing.Point(144, 537);
            this.labelDiskon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(344, 22);
            this.labelDiskon.TabIndex = 34;
            this.labelDiskon.Text = "xxxxxxxxxxxxxxxxxxx";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 536);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Discount:";
            // 
            // labelOngkir
            // 
            this.labelOngkir.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOngkir.Location = new System.Drawing.Point(144, 515);
            this.labelOngkir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOngkir.Name = "labelOngkir";
            this.labelOngkir.Size = new System.Drawing.Size(344, 22);
            this.labelOngkir.TabIndex = 32;
            this.labelOngkir.Text = "xxxxxxxxxxxxxxxxxxx";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 31;
            this.label5.Text = "Shipping Cost:";
            // 
            // comboBoxPembayaran
            // 
            this.comboBoxPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPembayaran.Enabled = false;
            this.comboBoxPembayaran.FormattingEnabled = true;
            this.comboBoxPembayaran.Location = new System.Drawing.Point(143, 415);
            this.comboBoxPembayaran.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxPembayaran.Name = "comboBoxPembayaran";
            this.comboBoxPembayaran.Size = new System.Drawing.Size(344, 21);
            this.comboBoxPembayaran.TabIndex = 28;
            this.comboBoxPembayaran.Enter += new System.EventHandler(this.comboBoxPembayaran_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Payment Method:";
            // 
            // comboBoxPromo
            // 
            this.comboBoxPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPromo.FormattingEnabled = true;
            this.comboBoxPromo.Location = new System.Drawing.Point(144, 365);
            this.comboBoxPromo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxPromo.Name = "comboBoxPromo";
            this.comboBoxPromo.Size = new System.Drawing.Size(344, 21);
            this.comboBoxPromo.TabIndex = 26;
            this.comboBoxPromo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPromo_SelectedIndexChanged);
            this.comboBoxPromo.Enter += new System.EventHandler(this.comboBoxPromo_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Promo Code:";
            // 
            // dataGridViewDeals
            // 
            this.dataGridViewDeals.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeals.Location = new System.Drawing.Point(8, 69);
            this.dataGridViewDeals.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridViewDeals.Name = "dataGridViewDeals";
            this.dataGridViewDeals.RowHeadersWidth = 51;
            this.dataGridViewDeals.RowTemplate.Height = 24;
            this.dataGridViewDeals.Size = new System.Drawing.Size(481, 293);
            this.dataGridViewDeals.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label8.Location = new System.Drawing.Point(7, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Payment Type:";
            // 
            // comboBoxCaraPembayaran
            // 
            this.comboBoxCaraPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCaraPembayaran.FormattingEnabled = true;
            this.comboBoxCaraPembayaran.Items.AddRange(new object[] {
            "OMA Saldo",
            "Cash On Delivery (COD)",
            "Other..."});
            this.comboBoxCaraPembayaran.Location = new System.Drawing.Point(143, 391);
            this.comboBoxCaraPembayaran.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxCaraPembayaran.Name = "comboBoxCaraPembayaran";
            this.comboBoxCaraPembayaran.Size = new System.Drawing.Size(344, 21);
            this.comboBoxCaraPembayaran.TabIndex = 39;
            this.comboBoxCaraPembayaran.SelectedIndexChanged += new System.EventHandler(this.comboBoxCaraPembayaran_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label9.Location = new System.Drawing.Point(7, 493);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Courier:";
            // 
            // comboBoxKurir
            // 
            this.comboBoxKurir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKurir.FormattingEnabled = true;
            this.comboBoxKurir.Location = new System.Drawing.Point(144, 493);
            this.comboBoxKurir.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxKurir.Name = "comboBoxKurir";
            this.comboBoxKurir.Size = new System.Drawing.Size(344, 21);
            this.comboBoxKurir.TabIndex = 41;
            this.comboBoxKurir.SelectedIndexChanged += new System.EventHandler(this.comboBoxKurir_SelectedIndexChanged);
            this.comboBoxKurir.Enter += new System.EventHandler(this.comboBoxKurir_Enter);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label10.Location = new System.Drawing.Point(7, 582);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Gift Redeem :";
            // 
            // comboBoxGift
            // 
            this.comboBoxGift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGift.Enabled = false;
            this.comboBoxGift.FormattingEnabled = true;
            this.comboBoxGift.Location = new System.Drawing.Point(143, 582);
            this.comboBoxGift.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxGift.Name = "comboBoxGift";
            this.comboBoxGift.Size = new System.Drawing.Size(322, 21);
            this.comboBoxGift.TabIndex = 43;
            this.comboBoxGift.Enter += new System.EventHandler(this.comboBoxGift_Enter);
            // 
            // checkBoxGift
            // 
            this.checkBoxGift.AutoSize = true;
            this.checkBoxGift.Location = new System.Drawing.Point(475, 586);
            this.checkBoxGift.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxGift.Name = "checkBoxGift";
            this.checkBoxGift.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGift.TabIndex = 44;
            this.checkBoxGift.UseVisualStyleBackColor = true;
            this.checkBoxGift.CheckedChanged += new System.EventHandler(this.checkBoxGift_CheckedChanged);
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(496, 653);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxGift);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxGift);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxKurir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCaraPembayaran);
            this.Controls.Add(this.dataGridViewDeals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.comboBoxPromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBatal);
            this.Controls.Add(this.comboBoxPembayaran);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOngkir);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDiskon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBatal;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelOngkir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPembayaran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPromo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDeals;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCaraPembayaran;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxKurir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxGift;
        private System.Windows.Forms.CheckBox checkBoxGift;
    }
}