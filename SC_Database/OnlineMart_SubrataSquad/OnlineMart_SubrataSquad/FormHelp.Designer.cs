
namespace OnlineMart_SubrataSquad
{
    partial class FormHelp
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
            this.circularButtonAskRobo = new OnlineMart_SubrataSquad.CircularButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circularButtonAskRobo
            // 
            this.circularButtonAskRobo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(241)))));
            this.circularButtonAskRobo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButtonAskRobo.Location = new System.Drawing.Point(11, 477);
            this.circularButtonAskRobo.Margin = new System.Windows.Forms.Padding(2);
            this.circularButtonAskRobo.Name = "circularButtonAskRobo";
            this.circularButtonAskRobo.Size = new System.Drawing.Size(73, 48);
            this.circularButtonAskRobo.TabIndex = 0;
            this.circularButtonAskRobo.Text = "ASK OMA ROBO";
            this.circularButtonAskRobo.UseVisualStyleBackColor = false;
            this.circularButtonAskRobo.Click += new System.EventHandler(this.circularButtonAskRobo_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(730, 490);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 33);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.BackgroundImage = global::OnlineMart_SubrataSquad.Properties.Resources.help;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 534);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.circularButtonAskRobo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton circularButtonAskRobo;
        private System.Windows.Forms.Button buttonExit;
    }
}