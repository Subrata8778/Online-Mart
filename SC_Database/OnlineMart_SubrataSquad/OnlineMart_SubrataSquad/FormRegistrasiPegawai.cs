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
    public partial class FormRegistrasiPegawai : Form
    {
        public FormRegistrasiPegawai()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNama.Text != "" && textBoxNama.Text != null && textBoxEmail.Text != "" && textBoxEmail.Text != null && textBoxTelepon.Text != "" && textBoxTelepon.Text != null && textBoxPassword.Text != "" && textBoxPassword.Text != null)
                {
                    byte[] img = null;
                    if (pictureBoxProfile.Image != null)
                    {
                        //Convert Foto ke Byte
                        MemoryStream ms = new MemoryStream();
                        pictureBoxProfile.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        img = ms.GetBuffer();
                    }
                    Pegawai p = new Pegawai(textBoxNama.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxTelepon.Text, img);
                    Pegawai.TambahData(p, FormLoading.cdb);
                    MessageBox.Show("Registration success.", "Information");
                    FormPengaturanPegawai frm = new FormPengaturanPegawai();
                    frm.FormPengaturan_Pegawai_Load(sender, e);
                    this.Close();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
