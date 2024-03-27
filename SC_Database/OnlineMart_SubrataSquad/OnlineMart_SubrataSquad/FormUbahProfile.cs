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
    public partial class FormUbahProfile : Form
    {
        public FormUbahProfile()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text != "" && textBoxNama.Text != null && textBoxEmail.Text != "" && textBoxEmail.Text != null && textBoxTelepon.Text != "" && textBoxTelepon.Text != null && textBoxPassword.Text != "" && textBoxPassword.Text != null && textBoxUlangPassword.Text != "" && textBoxUlangPassword.Text != null)
                {
                    byte[] img = null;
                    if (pictureBoxProfile.Image != null)
                    {
                        //Convert Foto ke Byte
                        MemoryStream ms = new MemoryStream();
                        pictureBoxProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        img = ms.GetBuffer();
                    }
                    if (textBoxPassword.Text == textBoxUlangPassword.Text)
                    {
                        FormProfile formProfile = (FormProfile)Owner;
                        Pelanggan pel = new Pelanggan(formProfile.pelanggan.Id, textBoxNama.Text, textBoxEmail.Text, textBoxUlangPassword.Text, textBoxTelepon.Text, formProfile.pelanggan.Saldo, formProfile.pelanggan.Poin, img);
                        Pelanggan.UbahData(pel, FormLoading.cdb);
                        MessageBox.Show("Profile data has been successfully changed.", "Information");
                        formProfile.FormProfile_Load(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Inccorect password");
                    }
                }
                else
                {
                    MessageBox.Show("Profile data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile data failed to change. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormProfile frm = (FormProfile)this.Owner;
            frm.FormProfile_Load(sender, e);
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxUlangPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxUlangPassword.PasswordChar = '*';
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

        private void FormUbahProfile_Load(object sender, EventArgs e)
        {
            FormProfile frm = (FormProfile)this.Owner;
            byte[] images1 = frm.pelanggan.Images;
            MemoryStream msStream = new MemoryStream(images1);
            pictureBoxProfile.Image = Image.FromStream(msStream);
        }
    }
}
