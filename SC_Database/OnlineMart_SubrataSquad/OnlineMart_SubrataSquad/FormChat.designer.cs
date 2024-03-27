
namespace OnlineMart_SubrataSquad
{
    partial class FormChat
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
            this.buttonKirimChat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.labelSeen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelkedudukan = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKirimChat
            // 
            this.buttonKirimChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(147)))), ((int)(((byte)(250)))));
            this.buttonKirimChat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKirimChat.ForeColor = System.Drawing.Color.White;
            this.buttonKirimChat.Location = new System.Drawing.Point(404, 5);
            this.buttonKirimChat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKirimChat.Name = "buttonKirimChat";
            this.buttonKirimChat.Size = new System.Drawing.Size(70, 27);
            this.buttonKirimChat.TabIndex = 36;
            this.buttonKirimChat.Text = "Send";
            this.buttonKirimChat.UseVisualStyleBackColor = false;
            this.buttonKirimChat.Click += new System.EventHandler(this.buttonKirimChat_Click);
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
            this.label1.TabIndex = 33;
            this.label1.Text = "CHAT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Red;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(399, 331);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(86, 32);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "&EXIT";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // listBoxChat
            // 
            this.listBoxChat.BackColor = System.Drawing.Color.White;
            this.listBoxChat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 17;
            this.listBoxChat.Location = new System.Drawing.Point(7, 143);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(478, 140);
            this.listBoxChat.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.textBoxChat);
            this.panel1.Controls.Add(this.buttonKirimChat);
            this.panel1.Location = new System.Drawing.Point(8, 291);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 35);
            this.panel1.TabIndex = 38;
            // 
            // textBoxChat
            // 
            this.textBoxChat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChat.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxChat.Location = new System.Drawing.Point(5, 8);
            this.textBoxChat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(396, 21);
            this.textBoxChat.TabIndex = 0;
            this.textBoxChat.Text = "Type Here...";
            this.textBoxChat.Enter += new System.EventHandler(this.textBoxChat_Enter);
            this.textBoxChat.Leave += new System.EventHandler(this.textBoxChat_Leave);
            // 
            // labelSeen
            // 
            this.labelSeen.AutoSize = true;
            this.labelSeen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeen.Location = new System.Drawing.Point(12, 338);
            this.labelSeen.Name = "labelSeen";
            this.labelSeen.Size = new System.Drawing.Size(149, 14);
            this.labelSeen.TabIndex = 39;
            this.labelSeen.Text = "You haven\'t texted yet";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelkedudukan);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.pictureBoxProfile);
            this.panel2.Location = new System.Drawing.Point(8, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 81);
            this.panel2.TabIndex = 40;
            // 
            // labelkedudukan
            // 
            this.labelkedudukan.AutoSize = true;
            this.labelkedudukan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkedudukan.Location = new System.Drawing.Point(135, 38);
            this.labelkedudukan.Name = "labelkedudukan";
            this.labelkedudukan.Size = new System.Drawing.Size(40, 16);
            this.labelkedudukan.TabIndex = 2;
            this.labelkedudukan.Text = "name";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(133, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 25);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "name";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = global::OnlineMart_SubrataSquad.Properties.Resources.defaultUser;
            this.pictureBoxProfile.Location = new System.Drawing.Point(16, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 75);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(490, 368);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelSeen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChat";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKirimChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Label labelSeen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelkedudukan;
        private System.Windows.Forms.Label labelName;
    }
}