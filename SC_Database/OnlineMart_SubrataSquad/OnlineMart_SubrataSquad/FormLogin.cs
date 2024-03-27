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
    public partial class FormLogin : Form
    {
        public static int sec;
        Pegawai pegawai;
        Driver driver;
        Pelanggan pelanggan;
        public FormLogin()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text, FormLoading.cdb))
                {
                    FormUtamaPegawai frm = new FormUtamaPegawai();
                    frm.Owner = this;

                    pegawai = Pegawai.AmbilData(textBoxUsername.Text, textBoxPassword.Text, FormLoading.cdb);
                    frm.pegawai = pegawai;
                    frm.labelNamaPegawai.Text = pegawai.Nama;
                    MessageBox.Show("Login Success. Welcome and enjoy the application.", "Information");

                    this.DialogResult = DialogResult.OK;

                    this.Hide();
                    frm.ShowDialog();
                    this.Close();

                }
                else if (Pelanggan.CekLogin(textBoxUsername.Text, textBoxPassword.Text, FormLoading.cdb))
                {
                    FormUtamaPelanggan frm = new FormUtamaPelanggan();
                    frm.Owner = this;

                    pelanggan = Pelanggan.AmbilData(textBoxUsername.Text, textBoxPassword.Text, FormLoading.cdb);
                    frm.pelanggan = pelanggan;
                    MessageBox.Show("Login Success. Welcome and enjoy the application.", "Information");

                    this.DialogResult = DialogResult.OK;

                    this.Hide();
                    frm.cariBarangToolStripMenuItem.Visible = true;
                    frm.keranjangToolStripMenuItem.Visible = true;
                    frm.saldoToolStripMenuItem.Visible = true;
                    frm.pesananToolStripMenuItem.Visible = true;
                    frm.rekapPembelianToolStripMenuItem.Visible = true;
                    frm.accountToolStripMenuItem.Visible = true;
                    frm.promoToolStripMenuItem.Visible = true;
                    frm.ShowDialog();
                    this.Close();
                }
                else if (Driver.CekLogin(textBoxUsername.Text, textBoxPassword.Text, FormLoading.cdb))
                {
                    FormUtamaDriver frm = new FormUtamaDriver();
                    frm.Owner = this;

                    driver = Driver.AmbilData(textBoxUsername.Text, textBoxPassword.Text, FormLoading.cdb);
                    frm.driver = driver;
                    frm.labelNamaDriver.Text = driver.Nama;
                    MessageBox.Show("Login Success. Welcome and enjoy the application.", "Information");

                    this.DialogResult = DialogResult.OK;

                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Username or Password is wrong. Please try again!");
                    textBoxPassword.Clear();
                    textBoxPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed. Error Message : " + ex.Message, "Failed");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            FormRegistrasi frm = new FormRegistrasi();
            frm.Owner = this;
            frm.ShowDialog();
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

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            FormLupaPassword frm = new FormLupaPassword();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
