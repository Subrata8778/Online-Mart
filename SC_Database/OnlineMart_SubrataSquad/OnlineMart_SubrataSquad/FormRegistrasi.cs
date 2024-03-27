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
using System.IO;

namespace OnlineMart_SubrataSquad
{
    public partial class FormRegistrasi : Form
    {
        public FormRegistrasi()
        {
            InitializeComponent();
        }

        #region ekstetika
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Full Name")
            {
                textBoxName.Text = "";
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "anything@something.com")
            {
                textBoxEmail.Text = "";
            }

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "12345678")
            {
                textBoxPassword.Text = "";
            }
        }

        private void textBoxTelepon_Enter(object sender, EventArgs e)
        {
            if (textBoxTelepon.Text == "Your Number")
            {
                textBoxTelepon.Text = "";
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Full Name";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "anything@something.com";
            }

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "12345678";
            }
        }

        private void textBoxTelepon_Leave(object sender, EventArgs e)
        {
            if (textBoxTelepon.Text == "")
            {
                textBoxTelepon.Text = "Your Number";
            }

        }
        #endregion

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != "" && textBoxName.Text != null && textBoxEmail.Text != "" && textBoxEmail.Text != null && textBoxTelepon.Text != "" && textBoxTelepon.Text != null && textBoxPassword.Text != "" && textBoxPassword.Text != null)
                {
                    byte[] img = null;
                    if (pictureBoxProfile.Image != null)
                    {
                        //Convert Foto ke Byte
                        MemoryStream ms = new MemoryStream();
                        pictureBoxProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        img = ms.GetBuffer();
                    }
                    if (radioButtonPelanggan.Checked)
                    {
                        Pelanggan pel = new Pelanggan(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxTelepon.Text, 0, 0, img);
                        Pelanggan.TambahData(pel, FormLoading.cdb);
                        MessageBox.Show("Registration success. \r\n Welcome " + textBoxName.Text + "\r\nHave a nice day!", "Information");
                        this.Close();
                    }
                    else
                    {
                        Driver driv = new Driver(textBoxName.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxTelepon.Text, img);
                        Driver.TambahData(driv, FormLoading.cdb);
                        MessageBox.Show("Registration success. \r\n Welcome " + textBoxName.Text + "\r\nHave a nice day!", "Information");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registraion failed. Error Message : " + ex.Message, "Failure");
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void FormRegistrasiPelanggan_Load(object sender, EventArgs e)
        {
            radioButtonPelanggan.Checked = true;
            buttonDaftar.Enabled = false;
        }


        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxAgreement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgreement.Checked)
            {
                buttonDaftar.Enabled = true;
            }
            else
            {
                buttonDaftar.Enabled = false;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxProfile.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your picture isn't input correctly. Error Message: " + ex.Message);
            }
        }
    }
}
