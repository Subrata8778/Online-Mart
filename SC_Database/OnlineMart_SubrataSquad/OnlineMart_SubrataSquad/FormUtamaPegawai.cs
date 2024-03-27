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
using System.Globalization;

namespace OnlineMart_SubrataSquad
{
    public partial class FormUtamaPegawai : Form
    {
        public Pegawai pegawai;
        List<Barang> listBarang = new List<Barang>();
        List<Cabang> listCabang = new List<Cabang>();
        List<Driver> listDriver = new List<Driver>();
        List<Pelanggan> listCustomer = new List<Pelanggan>();
        List<RiwayatIsiSaldo> listPendapatanOMA = new List<RiwayatIsiSaldo>();
        int count = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
        public FormUtamaPegawai()
        {
            InitializeComponent();
        }
        private void tampilanAwalPeg()
        {
            listBarang = Barang.BacaData("", "", FormLoading.cdb);
            listCabang = Cabang.BacaData("", "", FormLoading.cdb);
            listDriver = Driver.BacaData("", "", FormLoading.cdb);
            listPendapatanOMA = RiwayatIsiSaldo.BacaData("", "", FormLoading.cdb);
            listCustomer = Pelanggan.BacaData("", "", FormLoading.cdb);
            foreach (Barang i in listBarang)
            {
                if (i.Id == i.Id)
                {
                    count++;
                }
            }
            foreach (Cabang i in listCabang)
            {
                if (i.Id == i.Id)
                {
                    count2++;
                }
            }
            foreach (RiwayatIsiSaldo i in listPendapatanOMA)
            {
                if (i.Id == i.Id)
                {
                    count3 += i.IsiSaldo;
                }
            }
            foreach (Driver i in listDriver)
            {
                if (i.Id == i.Id)
                {
                    count4++;
                }
            }
            foreach (Pelanggan i in listCustomer)
            {
                if (i.Id == i.Id)
                {
                    count5++;
                }
            }
            labelJumBarang.Text = "Product(s) total : " + count;
            labelJumCabang.Text = "Branch(es) total : " + count2;
            labelJumCustomer.Text = "Customer(s) total : " + count5;
            labelJumDriver.Text = "Driver(s) total : " + count4;
            labelPendapatanOMA.Text = "Total Income OMA : " + count3.ToString("C0",new CultureInfo("id"));
        }
        private void FormUtamaPegawai_Load(object sender, EventArgs e)
        {
            byte[] img = pegawai.Images;
            MemoryStream msStream = new MemoryStream(img);
            pictureBoxPegawai.Image = Image.FromStream(msStream);
            tampilanAwalPeg();
            labelJam.Text = DateTime.Now.ToShortTimeString();
            labelTanggal.Text = DateTime.Now.ToShortDateString();
        }

        private void buttonCabang_Click(object sender, EventArgs e)
        {
            FormPengaturanCabang formPengaturanCabang = new FormPengaturanCabang();
            formPengaturanCabang.Owner = this;
            formPengaturanCabang.ShowDialog();
        }

        private void buttonKategori_Click(object sender, EventArgs e)
        {
            FormPengaturanKategori formPengaturanKategori = new FormPengaturanKategori();
            formPengaturanKategori.Owner = this;
            formPengaturanKategori.ShowDialog();
        }

        private void buttonBarang_Click(object sender, EventArgs e)
        {
            FormPengaturanBarang formPengaturanBarang = new FormPengaturanBarang();
            formPengaturanBarang.Owner = this;
            formPengaturanBarang.ShowDialog();
        }

        private void buttonPromo_Click(object sender, EventArgs e)
        {
            FormPengaturanPromo formPengaturanPromo = new FormPengaturanPromo();
            formPengaturanPromo.Owner = this;
            formPengaturanPromo.ShowDialog();
        }

        private void buttonMetodePembayaran_Click(object sender, EventArgs e)
        {
            FormPengaturanMetodePembayaran formPengaturanMetodePembayaran = new FormPengaturanMetodePembayaran();
            formPengaturanMetodePembayaran.Owner = this;
            formPengaturanMetodePembayaran.ShowDialog();
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            FormPengaturanPegawai formPengaturPegawai = new FormPengaturanPegawai();
            formPengaturPegawai.Owner = this;
            formPengaturPegawai.ShowDialog();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            CultureInfo englishLang = new CultureInfo("en-GB");
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            int date = DateTime.Now.Day;
            int year = DateTime.Now.Year;
            string day = DateTime.Now.ToString("dddd", englishLang);
            string month = DateTime.Now.ToString("MMMM", englishLang);


            string clock = "";
            string dateString = "";

            if (hh < 10)
                clock += "0" + hh;
            else
                clock += hh;

            clock += ":";

            if (mm < 10)
                clock += "0" + mm;
            else
                clock += mm;

            clock += ":";

            if (ss < 10)
                clock += "0" + ss;
            else
                clock += ss;

            dateString += day + ", ";

            if (date < 10)
                dateString += "0" + date;
            else
                dateString += date;

            dateString += " " + month + " " + year;

            labelJam.Text = clock;
            labelTanggal.Text = dateString;
        }

        private void buttonChatRobo_Click(object sender, EventArgs e)
        {
            FormListQuestionHelp frm = new FormListQuestionHelp();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonHadiah_Click(object sender, EventArgs e)
        {
            FormPengaturanHadiah formPengaturanHadiah = new FormPengaturanHadiah();
            formPengaturanHadiah.Owner = this;
            formPengaturanHadiah.ShowDialog();
        }

        private void buttonRekapPenjualanBarang_Click(object sender, EventArgs e)
        {
            FormRekapPenjualanBarang formRekapPenjualanBarang = new FormRekapPenjualanBarang();
            formRekapPenjualanBarang.Owner = this;
            formRekapPenjualanBarang.ShowDialog();
        }

        private void buttonPenjualanOMASaldo_Click(object sender, EventArgs e)
        {
            FormRekapPenjualanOMASaldo formRekapPenjualanOMASaldo = new FormRekapPenjualanOMASaldo();
            formRekapPenjualanOMASaldo.Owner = this;
            formRekapPenjualanOMASaldo.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Log Out", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                FormLogin frm = new FormLogin();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
