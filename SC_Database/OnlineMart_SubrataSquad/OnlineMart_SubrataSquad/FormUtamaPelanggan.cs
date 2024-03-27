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
    public partial class FormUtamaPelanggan : Form
    {
        public Pegawai pegawai;
        public Pelanggan pelanggan;
        public Driver driver;

        //Untuk Poster
        private int numberPoster = 1;
        int position = -50;
        int count = 0;
        Size sizePic1;
        Size sizePic2;
        Point locPic2;
        bool checkPoster = true;
        int help = 0;
        int help1 = 0;

        bool pic1, pic2, statusClick, firstLoad;
              
        public FormUtamaPelanggan()
        {
            InitializeComponent();
        }

        public void FormUtamaKonsumen_Load(object sender, EventArgs e)
        {
            try
            {
                statusClick = false;
                pelanggan = Pelanggan.AmbilPelangganById(pelanggan.Id, FormLoading.cdb);
                byte[] img = pelanggan.Images;
                MemoryStream msS = new MemoryStream(img);
                pictureBoxProfile.Image = Image.FromStream(msS);
                labelWel.Text = "Welcome, " + pelanggan.Nama;
                labelMoney.Text = pelanggan.Saldo.ToString("C0",new CultureInfo("id"));
                List<Order> listorder = Order.TampilOrder(pelanggan.Id.ToString());
                foreach (Order o in listorder)
                {
                    if (o.Status == "Pesanan Diproses")
                    {
                        help++;
                    }
                }
                List<Keranjang> listkeranjang = Keranjang.BacaData(pelanggan.Id);
                labelOYW.Text = help.ToString() + " Order(s)";
                labelProducts.Text = listkeranjang.Count().ToString() + " Product(s)";
                if (checkPoster == true)
                {
                    //untuk poster
                    pic2 = true;
                    firstLoad = true;
                    radioButton1.Enabled = false;

                    sizePic1 = pictureBoxPoster.Size;
                    sizePic2 = pictureBoxPoster2.Size;
                    locPic2 = pictureBoxPoster2.Location;
                    checkPoster = false;
                }

                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);

                //Untuk Best Seller
                lblBarang1.Text = listBarangsTerlaris[0].Nama;
                lblHargaBarang1.Text = int.Parse(listBarangsTerlaris[0].Harga).ToString("C0",new CultureInfo("id"));
                byte[] images1 = listBarangsTerlaris[0].Images;
                MemoryStream msStream = new MemoryStream(images1);
                pictureBox1.Image = Image.FromStream(msStream);

                lblBarang2.Text = listBarangsTerlaris[1].Nama;
                lblHargaBarang2.Text = int.Parse(listBarangsTerlaris[1].Harga).ToString("C0", new CultureInfo("id"));
                byte[] images2 = listBarangsTerlaris[1].Images;
                msStream = new MemoryStream(images2);
                pictureBox2.Image = Image.FromStream(msStream);

                lblBarang3.Text = listBarangsTerlaris[2].Nama;
                lblHargaBarang3.Text = int.Parse(listBarangsTerlaris[2].Harga).ToString("C0", new CultureInfo("id"));
                byte[] images3 = listBarangsTerlaris[2].Images;
                msStream = new MemoryStream(images3);
                pictureBox3.Image = Image.FromStream(msStream);

                lblBarang4.Text = listBarangsTerlaris[3].Nama;
                lblHargaBarang4.Text = int.Parse(listBarangsTerlaris[3].Harga).ToString("C0", new CultureInfo("id"));
                byte[] images4 = listBarangsTerlaris[3].Images;
                msStream = new MemoryStream(images4);
                pictureBox4.Image = Image.FromStream(msStream);

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
          
        }

        #region Strip Menu
        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.ShowDialog();
        }

        private void keranjangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang();
            formKeranjang.pelanggan = pelanggan;
            formKeranjang.Owner = this;
            formKeranjang.ShowDialog();
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIsiSaldo formIsiSaldo = new FormIsiSaldo();
            formIsiSaldo.pelanggan = pelanggan;
            formIsiSaldo.Owner = this;
            formIsiSaldo.ShowDialog();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile();
            formProfile.Owner = this;
            formProfile.idPelanggan = pelanggan.Id;
            formProfile.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                MessageBox.Show("Logout success.", "Information");
                this.Hide();
                FormLogin frm = new FormLogin();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void rekapPembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory();
            formHistory.Owner = this;
            formHistory.pelanggan = pelanggan;
            formHistory.ShowDialog();
        }

        private void pesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCekPesanan form = new FormCekPesanan();
            form.pelanggan = pelanggan;
            form.Owner = this;
            form.Show();
        }

        private void promoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormPromo form = new FormPromo();
            form.Owner = this;
            form.ShowDialog();
        }

        private void helpSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp frm = new FormHelp();
            frm.Owner = this;
            frm.Show();
        }
        #endregion

        #region Poster
        private void CheckNumberPoster()
        {
            if (numberPoster == 1)
            {
                radioButton1.Checked = true;

                if (pic1)
                {
                    pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_1");
                }
                else if (pic2)
                {
                    pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_1");
                }
            }
            else if (numberPoster == 2)
            {
                radioButton2.Checked = true;

                if (pic1)
                {
                    pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_2");
                }
                else if (pic2)
                {
                    pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_2");
                }
            }
            else if (numberPoster == 3)
            {
                radioButton3.Checked = true;

                if (pic1)
                {
                    pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_3");
                }
                else if (pic2)
                {
                    pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_3");
                }
            }
            else if (numberPoster == 4)
            {
                radioButton4.Checked = true;

                if (pic1)
                {
                    pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_4");
                }
                else if (pic2)
                {
                    pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_4");
                }
            }
            else if (numberPoster == 5)
            {
                radioButton5.Checked = true;

                if (pic1)
                {
                    pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_5");
                }
                else if (pic2)
                {
                    pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_5");
                }
            }
        }

        private void SettingBack(int pictureNum)
        {
            numberPoster = pictureNum;
            timerPoster.Stop();

            if (pictureBoxPoster.Location.X >= locPic2.X)
            {
                pic2 = true;
                pic1 = false;
                pictureBoxPoster.Location = new Point(0, 35);
                pictureBoxPoster.Size = new Size(0, 333);
                pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_" + pictureNum);
                timer3.Start();
            }
            else if (pictureBoxPoster2.Location.X >= locPic2.X)
            {
                pic2 = false;
                pic1 = true;
                pictureBoxPoster2.Location = new Point(0, 35);
                pictureBoxPoster2.Size = new Size(0, 333);
                pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_" + pictureNum);
                timer3.Start();
            }
        }

        private void SettingNext(int pictureNum)
        {
            numberPoster = pictureNum;
            timerPoster.Stop();

            if (pictureBoxPoster.Location.X >= locPic2.X)
            {
                pic2 = true;
                pic1 = false;
                pictureBoxPoster.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_" + pictureNum);
                timerPoster2.Start();
            }
            else if (pictureBoxPoster2.Location.X >= locPic2.X)
            {
                pic2 = false;
                pic1 = true;
                pictureBoxPoster2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("poster1_" + pictureNum);
                timerPoster2.Start();
            }
        }
        private void timerPoster_Tick(object sender, EventArgs e)
        {
            numberPoster += 1;
            StatusClickCheck(statusClick = false);
            if (numberPoster > 5)
            {
                numberPoster = 1;
            }

            if (pictureBoxPoster.Location.X >= locPic2.X)
            {
                pic2 = true;
                pic1 = false;
            }
            else if (pictureBoxPoster2.Location.X >= locPic2.X)
            {
                pic2 = false;
                pic1 = true;
            }
            timerPoster2.Start();
            CheckNumberPoster();
            Check();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pic2)
            {
                pictureBoxPoster2.Location = new Point(pictureBoxPoster2.Location.X - position, pictureBoxPoster2.Location.Y);
                pictureBoxPoster.Width += -position;

                if (pictureBoxPoster2.Location.X >= locPic2.X)
                {
                    timer3.Stop();
                    StatusClickCheck(statusClick = true);
                    pic1 = true;
                    pic2 = false;
                    timerPoster.Start();
                }
            }
            else if (pic1)
            {
                pictureBoxPoster.Location = new Point(pictureBoxPoster.Location.X - position, pictureBoxPoster.Location.Y);
                pictureBoxPoster2.Width += -position;

                if (pictureBoxPoster.Location.X >= locPic2.X)
                {
                    timer3.Stop();
                    StatusClickCheck(statusClick = true);
                    pic1 = false;
                    pic2 = true;
                    timerPoster.Start();
                }
            }
            Check();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            count = 1;
            if (firstLoad == false)
            {
                StatusClickCheck(statusClick = false);
            }
            else
            {
                StatusClickCheck(statusClick = true);
                firstLoad = false;
            }
            if (count < numberPoster)
            {
                timerPoster.Stop();
                numberPoster = 1;
                SettingBack(count);
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            count = 2;
            StatusClickCheck(statusClick = false);
            if (count > numberPoster)
            {
                SettingNext(count);
            }
            else if (count < numberPoster)
            {
                SettingBack(count);
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            count = 3;
            StatusClickCheck(statusClick = false);
            if (count > numberPoster)
            {
                SettingNext(count);
            }
            else if (count < numberPoster)
            {
                SettingBack(count);
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            count = 4;
            StatusClickCheck(statusClick = false);
            if (count > numberPoster)
            {
                SettingNext(count);
            }
            else if (count < numberPoster)
            {
                SettingBack(count);
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            count = 5;
            StatusClickCheck(statusClick = false);
            if (count > numberPoster)
            {
                SettingNext(count);
            }
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

            labelClock.Text = clock;
            labelDate.Text = dateString;
        }

        private void timerPoster2_Tick(object sender, EventArgs e)
        {
            if (pic2)
            {
                pictureBoxPoster.Location = new Point(pictureBoxPoster.Location.X + position, pictureBoxPoster.Location.Y);
                pictureBoxPoster2.Width -= -position;
                if (pictureBoxPoster2.Width <= 0)
                {
                    timerPoster2.Stop();
                    StatusClickCheck(statusClick = true);
                    if (pictureBoxPoster.Location.X <= 0)
                    {
                        pictureBoxPoster.Location = new Point(0, 35);
                    }
                    pictureBoxPoster2.Location = new Point(locPic2.X, 35);
                    pictureBoxPoster2.Size = sizePic1;
                    timerPoster.Start();
                }
            }
            else if (pic1)
            {
                pictureBoxPoster2.Location = new Point(pictureBoxPoster2.Location.X + position, pictureBoxPoster2.Location.Y);
                pictureBoxPoster.Width -= -position;
                if (pictureBoxPoster.Width <= 0)
                {
                    timerPoster2.Stop();
                    StatusClickCheck(statusClick = true);
                    if (pictureBoxPoster2.Location.X <= 0)
                    {
                        pictureBoxPoster2.Location = new Point(0, 35);
                    }
                    pictureBoxPoster.Location = new Point(locPic2.X, 35);
                    pictureBoxPoster.Size = sizePic2;
                    timerPoster.Start();
                }
            }
            Check();
        }

        private void StatusClickCheck(bool statusClicks)
        {
            if (statusClicks)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
            }
            else if (statusClicks == false)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
            }
        }


        private void Check()
        {
            if(radioButton1.Checked && statusClick)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
            }
            else if(radioButton2.Checked && statusClick)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = false;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
            }
            else if(radioButton3.Checked && statusClick)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = false;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
            }
            else if(radioButton4.Checked && statusClick)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = false;
                radioButton5.Enabled = true;
            }
            else if(radioButton5.Checked && statusClick)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = false;
            }
        }

        #endregion

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

        #region ShowBarangTerlaris
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[0];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panelBarang2_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[1];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panelBarang3_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[2];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panelBarang4_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[3];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void panelBarang1_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[0];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBoxKategori1_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Makanan";
            formBarang.ShowDialog();
        }

        private void pictureBoxKategori2_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Minuman";
            formBarang.ShowDialog();
        }

        private void pictureBoxKategori3_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Elektronik";
            formBarang.ShowDialog();
        }

        private void pictureBoxKategori4_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Alat Tulis";
            formBarang.ShowDialog();
        }

        private void labelKategori1_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Makanan";
            formBarang.ShowDialog();
        }

        private void labelKategori2_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Minuman";
            formBarang.ShowDialog();
        }

        private void labelKategori3_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Elektronik";
            formBarang.ShowDialog();
        }

        private void labelKategori4_Click(object sender, EventArgs e)
        {
            FormBarang formBarang = new FormBarang();
            formBarang.Owner = this;
            formBarang.pelanggan = pelanggan;
            formBarang.strKategori = "Alat Tulis";
            formBarang.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[1];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[2];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> idBarangTerlaris = BarangOrder.BacaIdBarangTerlaris(FormLoading.cdb);
                List<Barang> listBarangsTerlaris = Barang.BacaBarangTerlaris(idBarangTerlaris, FormLoading.cdb);
                FormDetailBestSeller formDetailBestSeller = new FormDetailBestSeller();
                formDetailBestSeller.Owner = this;
                formDetailBestSeller.barang = listBarangsTerlaris[3];
                formDetailBestSeller.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }
#endregion
    }
}
