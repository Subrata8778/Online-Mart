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
    public partial class FormLupaPassword : Form
    {
        public FormLupaPassword()
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

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxUlangPw.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxUlangPw.PasswordChar = '*';
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUsername.Text != null || textBoxUsername.Text != "")
                {
                    if (Pelanggan.CheckId(textBoxUsername.Text, FormLoading.cdb))
                    {
                        Pelanggan pel = Pelanggan.AmbilPelangganByUsername(textBoxUsername.Text, FormLoading.cdb);
                        if (pel != null && textBoxPassword.Text.Length >= 8)
                        {
                            DialogResult dr = MessageBox.Show("Are you sure?", "Attention", MessageBoxButtons.YesNo);

                            if (dr == DialogResult.Yes)
                            {
                                if (textBoxPassword.Text == textBoxUlangPw.Text)
                                {
                                    pel.Password = textBoxPassword.Text;
                                    Pelanggan.UbahData(pel, FormLoading.cdb);
                                    MessageBox.Show("Password has been changed");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Password isn't match. Please, Check it.");
                                    textBoxPassword.Clear();
                                    textBoxUlangPw.Clear();
                                    textBoxPassword.Focus();
                                }
                            }
                        }
                    }
                    else if (Driver.CheckId(textBoxUsername.Text, FormLoading.cdb))
                    {
                        Driver driver = Driver.AmbilDriverByUsername(textBoxUsername.Text, FormLoading.cdb);
                        if (driver != null && textBoxPassword.Text.Length >= 8)
                        {
                            DialogResult dr = MessageBox.Show("Are you sure?","Attention",MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                driver.Password = textBoxPassword.Text;
                                Driver.UbahData(driver, FormLoading.cdb);
                                MessageBox.Show("Password has been changed");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username isn't registered or the password is less than 8 character");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please check, are you already input something on textbox.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Changing password failed. Error Message: " + ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLupaPassword_Load(object sender, EventArgs e)
        {
            textBoxUsername.Enabled = false;
            FormVerify frm = new FormVerify();
            frm.Owner = this;
            if (frm.ShowDialog() == DialogResult.OK)
                textBoxUsername.Text = frm.username;
            else
                this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
