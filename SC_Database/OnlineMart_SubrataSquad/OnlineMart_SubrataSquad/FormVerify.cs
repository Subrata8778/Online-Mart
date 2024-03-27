using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_SubrataSquad
{
    public partial class FormVerify : Form
    {
        string code;
        int counter = 0;
        public string username;
        public FormVerify()
        {
            InitializeComponent();
        }

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        private void buttonSendCode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            code = random.Next(999999).ToString();
            if (textBoxUsername.Text != null && textBoxUsername.Text != "")
            {
                if (FormLogin.sec == 0)
                {
                    if (Pelanggan.CheckId(textBoxUsername.Text, FormLoading.cdb) || Driver.CheckId(textBoxUsername.Text, FormLoading.cdb))
                    {
                        counter++;
                        MessageBox.Show("Hello, " + textBoxUsername.Text + "\r\nPlease be carefull and don't give it to the other," + "\r\n" + "Here's your code = " + code, "Email");
                    }
                    else
                    {
                        MessageBox.Show("Account is not registered.", "Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Too many attempt, Try again after "+ FormLogin.sec + " seconds.","WARNING");
                }
            }
            else
            {
                MessageBox.Show("Please input your username.", "Attention");
            }
            if (counter == 5)
            {
                FormLogin.sec = 60;
                counter = 0;
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (code == textBoxCode.Text)
            {
                MessageBox.Show("Verify succeed.", "Information");
                username = textBoxUsername.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Verification code false, Please check it again.", "Error");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            if (FormLogin.sec > 0)
            {
                FormLogin.sec--;
            }
        }
    }
}
