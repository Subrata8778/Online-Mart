using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;
using System.IO;

namespace OnlineMart_SubrataSquad
{
    public partial class FormProfile : Form
    {
        public List<Pelanggan> listPelanggan = new List<Pelanggan>();
        public int idPelanggan;
        public Pelanggan pelanggan;

        public FormProfile()
        {
            InitializeComponent();
        }

        public void FormProfile_Load(object sender, EventArgs e)
        {
            listPelanggan = Pelanggan.BacaData("", "",FormLoading.cdb);
            foreach (Pelanggan user in listPelanggan)
            {
                if (user.Id == idPelanggan)
                {
                    labelNama.Text = user.Nama;
                    labelEmail.Text = user.Email;
                    labelTelepon.Text = user.Telepon;
                    labelSaldo.Text = user.Saldo.ToString("C0",new CultureInfo("id"));
                    labelPoin.Text = user.Poin.ToString();
                    byte[] images1 = user.Images;
                    MemoryStream msStream = new MemoryStream(images1);
                    pictureBoxProfile.Image = Image.FromStream(msStream);
                    pelanggan = user;
                }
            }
        }

        private void buttonUbahProfile_Click_1(object sender, EventArgs e)
        {
            FormUbahProfile form = new FormUbahProfile();
            form.Owner = this;
            form.textBoxNama.Text = labelNama.Text;
            form.textBoxEmail.Text = labelEmail.Text;
            form.textBoxTelepon.Text = labelTelepon.Text;
            form.ShowDialog();
        }

        private void buttonKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
