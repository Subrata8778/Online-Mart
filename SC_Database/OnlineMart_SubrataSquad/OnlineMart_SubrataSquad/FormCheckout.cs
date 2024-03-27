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
using System.Globalization;

namespace OnlineMart_SubrataSquad
{
    public partial class FormCheckout : Form
    {
        List<Keranjang> listKeranjang = new List<Keranjang>();
        List<Promo> listPromo = new List<Promo>();
        List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();
        List<Gift> listGift = new List<Gift>();
        List<Driver> listDriver = new List<Driver>();
        List<Order> listOrder = new List<Order>();
        Cabang cabang;
        MetodePembayaran metodePembayaran;
        int ongkir = 15000;
        float totalHarga = 0;
        int diskon = 0;

        public FormCheckout()
        {
            InitializeComponent();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            FormKeranjang formKeranjang = (FormKeranjang)Owner;
            listKeranjang = formKeranjang.listKeranjang;
            listPromo = Promo.BacaData("", "", FormLoading.cdb);
            listMetodePembayaran = MetodePembayaran.BacaData("", "", FormLoading.cdb);
            listGift = Gift.BacaData("", "", FormLoading.cdb);
            listDriver = Driver.BacaData("", "", FormLoading.cdb);

            TampilDataGrid();
            totalHarga = Order.HitungTotalHarga(totalHarga, ongkir, diskon);
            labelOngkir.Text = ongkir.ToString("C0", new CultureInfo("id"));
            labelDiskon.Text = diskon.ToString("C0", new CultureInfo("id"));
            labelTotalHarga.Text = totalHarga.ToString("C0", new CultureInfo("id"));
        }

        public void FormatDataGrid()
        {
            dataGridViewDeals.DataSource = null;
            dataGridViewDeals.Columns.Clear();

            //Atur Tabel
            dataGridViewDeals.Columns.Add("barang", "Product");
            dataGridViewDeals.Columns.Add("cabang", "Branch");
            dataGridViewDeals.Columns.Add("jumlah", "Quantity");
            dataGridViewDeals.Columns.Add("harga", "Price");
            dataGridViewDeals.Columns.Add("subTotal", "Sub Total");


            //Atur Ukuran Cell
            dataGridViewDeals.Columns["barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["subTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDeals.BorderStyle = BorderStyle.None;
            dataGridViewDeals.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewDeals.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewDeals.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewDeals.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewDeals.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewDeals.EnableHeadersVisualStyles = false;
            dataGridViewDeals.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewDeals.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewDeals.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewDeals.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewDeals.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDeals.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDeals.RowHeadersVisible = false;
            //Batasi Aktivitas User
            dataGridViewDeals.AllowUserToAddRows = false;
            dataGridViewDeals.ReadOnly = true;
        }

        public void TampilDataGrid()
        {
            dataGridViewDeals.Rows.Clear();

            if (listKeranjang.Count > 0)
            {
                foreach (Keranjang k in listKeranjang)
                {
                    dataGridViewDeals.Rows.Add(k.Barang.Nama, k.Cabang.Nama, k.Jumlah, k.Barang.Harga, k.Jumlah*int.Parse(k.Barang.Harga));
                    totalHarga += k.Jumlah * int.Parse(k.Barang.Harga);
                }

            }
            else
            {
                dataGridViewDeals.DataSource = null;
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try
            {
                FormKeranjang formKeranjang = (FormKeranjang)Owner;
                Pelanggan pelanggan = formKeranjang.pelanggan;
                Barang b = new Barang();
                Order ord = new Order();

                if (textBoxAlamat.Text == null || textBoxAlamat.Text == "")
                {
                    MessageBox.Show("Please input the address.");
                    return;
                }
                if (comboBoxCaraPembayaran.Text == "Other..." && comboBoxPembayaran.SelectedItem == null)
                {
                    MessageBox.Show("Please input your payment method.");
                    return;
                }
                if (comboBoxCaraPembayaran.Text == "OMA Saldo")
                {
                    if (pelanggan.Saldo > totalHarga)
                    {
                        Pelanggan.kurangiSaldo(totalHarga, pelanggan.Id, FormLoading.cdb);
                    }
                    else
                    {
                        MessageBox.Show("Your balance is not enough");
                        return;
                    }
                }
                foreach (Keranjang keranjang in listKeranjang)
                {
                    if (keranjang.Pelanggan.Id == pelanggan.Id)
                    {
                        Keranjang.KurangiStok(keranjang, FormLoading.cdb);
                        cabang = keranjang.Cabang;
                        b = new Barang(keranjang.Barang.Id, keranjang.Barang.Nama, keranjang.Barang.Harga, keranjang.Barang.Kategori, (byte[])keranjang.Barang.Images);
                    }
                }
                if (comboBoxGift.SelectedValue != null && checkBoxGift.Checked == true)
                {
                    Gift g = (Gift)comboBoxGift.SelectedItem;
                    if (pelanggan.Poin < int.Parse(g.JumlahPoin))
                    {
                        throw new Exception("Your poin isn't enough. Try to redeem another time");
                    }
                }
                Promo promo = (Promo)comboBoxPromo.SelectedItem;
                if(comboBoxCaraPembayaran.Text == "Other...")
                {
                    metodePembayaran = (MetodePembayaran)comboBoxPembayaran.SelectedItem;
                }
                Driver driver = (Driver)comboBoxKurir.SelectedItem;
                Order order = new Order(textBoxAlamat.Text, ongkir, totalHarga, comboBoxCaraPembayaran.Text, cabang, driver, pelanggan, promo, "Pesanan diproses", metodePembayaran, "Waiting");
                Order.TambahData(order, FormLoading.cdb);
                listOrder = Order.BacaData("", "");

                foreach (Order o in listOrder)
                {
                    ord = new Order(o.Id, o.TanggalWaktu, textBoxAlamat.Text, ongkir, totalHarga, comboBoxCaraPembayaran.Text, cabang, driver, pelanggan, promo, "Pesanan diproses", metodePembayaran, "Waiting");
                    break;
                }

                foreach (Keranjang keranjang in listKeranjang)
                {
                    if (keranjang.Pelanggan.Id == pelanggan.Id)
                    {
                        BarangOrder bo = new BarangOrder(keranjang.Barang, ord, keranjang.Jumlah, keranjang.Barang.Harga);
                        BarangOrder.TambahData(bo, FormLoading.cdb);
                        Keranjang.HapusKeranjang(keranjang, FormLoading.cdb);
                        Pelanggan.TambahPoin(totalHarga, pelanggan, FormLoading.cdb);
                    }
                }

                if (comboBoxGift.SelectedValue != null && checkBoxGift.Checked == true)
                {
                    Gift g = (Gift)comboBoxGift.SelectedItem;
                    GiftRedeem gr = new GiftRedeem(int.Parse(g.JumlahPoin), g, ord);
                    if (pelanggan.Poin >= int.Parse(g.JumlahPoin))
                    {
                        GiftRedeem.TambahData(gr,FormLoading.cdb);
                        GiftRedeem.KurangiPoin(int.Parse(g.JumlahPoin), pelanggan, FormLoading.cdb);
                    }   
                }
                MessageBox.Show("All Items Succesfully Paid.");
                formKeranjang.FormKeranjang_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Checkout Failed, Error Message : " + ex.Message,"Failure");
            }
        }

        private void comboBoxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalHarga = 0;
            TampilDataGrid();
            Promo promo = (Promo)comboBoxPromo.SelectedItem;
            diskon = Promo.HitungDiskon(promo, totalHarga, listKeranjang);
            totalHarga = Order.HitungTotalHarga(totalHarga, ongkir, diskon);
            labelOngkir.Text = ongkir.ToString("C0", new CultureInfo("id"));
            labelDiskon.Text = diskon.ToString("C0", new CultureInfo("id"));
            labelTotalHarga.Text = totalHarga.ToString("C0", new CultureInfo("id"));
        }

        private void comboBoxPromo_Enter(object sender, EventArgs e)
        {
            comboBoxPromo.DataSource = listPromo;
            comboBoxPromo.DisplayMember = "Nama";
        }

        private void comboBoxPembayaran_Enter(object sender, EventArgs e)
        {
            comboBoxPembayaran.Items.Clear();
            foreach (MetodePembayaran mpe in listMetodePembayaran)
            {
                if (mpe.Nama != "OMA Saldo" && mpe.Nama != "Cash On Delivery (COD)")
                {
                    comboBoxPembayaran.Items.Add(mpe);
                    comboBoxPembayaran.DisplayMember = "Nama";
                }
            }
        }

        private void comboBoxKurir_Enter(object sender, EventArgs e)
        {
            comboBoxKurir.DataSource = listDriver;
            comboBoxKurir.DisplayMember = "Nama";
        }

        private void CheckBayar()
        {
            if (comboBoxKurir.SelectedValue != null && comboBoxCaraPembayaran.Text != null)
            {
                buttonBayar.Enabled = true;

            }
            else
            {
                buttonBayar.Enabled = false;
            }
        }

        private void comboBoxKurir_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBayar();
        }

        private void comboBoxGift_Enter(object sender, EventArgs e)
        {
            comboBoxGift.DataSource = listGift;
            comboBoxGift.DisplayMember = "Nama";
        }

        private void checkBoxGift_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxGift.Checked == true)
            {
                comboBoxGift.Enabled = true;
            }
            else
            {
                comboBoxGift.Enabled = false;
            }
        }

        private void comboBoxCaraPembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCaraPembayaran.Text == "Other...")
            {
                //buttonBayar.Enabled = false;
                comboBoxPembayaran.Enabled = true;
            }
            else
            {
                comboBoxPembayaran.Enabled = false;
                comboBoxPembayaran.Text = null;
                foreach (MetodePembayaran mp in listMetodePembayaran)
                {
                    if (comboBoxCaraPembayaran.Text == "OMA Saldo")
                    {
                        if (mp.Nama == "OMA Saldo")
                        {
                            metodePembayaran = mp;
                        }
                    }
                    else if (comboBoxCaraPembayaran.Text == "Cash On Delivery (COD)")
                    {
                        if (mp.Nama == "Cash On Delivery (COD)")
                        {
                            metodePembayaran = mp;  
                        }
                    }
                }                
            }
            CheckBayar();
        }
    }
}
