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
    public partial class FormUtamaDriver : Form
    {
        public Driver driver;
        public List<Order> listOrder = new List<Order>();
        int count=0,count2=0,count3=0;
        public FormUtamaDriver()
        {
            InitializeComponent();
        }
        private void tampilan()
        {
            listOrder = Order.TampilOrder(driver.Id.ToString());
            labelIncome.Text = "Income Total: " + Driver.TotalKomisi(listOrder).ToString("C0", new CultureInfo("id"));
            foreach (Order item in listOrder)
            {
                if (item.Driver.Id == driver.Id && item.StatusKirim == "Accepted")
                {
                    count++;
                }
                if (item.Driver.Id == driver.Id && item.StatusKirim == "Waiting")
                {
                    count2++;
                }
                if (item.Driver.Id == driver.Id && item.Status == "Diterima")
                {
                    count3++;
                }
            }
            labelorder.Text = "Accepted Order : " + count;
            labelOrderCome.Text = "Waiting order : " + count2;
            labelDone.Text = "Order done : " + count3;
        }
        private void FormUtamaDriver_Load(object sender, EventArgs e)
        {
            byte[] img = driver.Images;
            MemoryStream msStream = new MemoryStream(img);
            pictureBoxDriver.Image = Image.FromStream(msStream);
            labelJam.Text = DateTime.Now.ToShortTimeString();
            labelTanggal.Text = DateTime.Now.ToShortDateString();
            tampilan();
        }

        private void buttonDaftarPengiriman_Click(object sender, EventArgs e)
        {
            FormListPengiriman frm = new FormListPengiriman();
            frm.Owner = this;
            frm.driver = driver;
            frm.ShowDialog();
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

        private void buttonRekapPenadapatan_Click(object sender, EventArgs e)
        {
            FormRekapPendapatan frm = new FormRekapPendapatan();
            frm.Owner = this;
            frm.ShowDialog();
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
