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
    public partial class FormTambahBarangKeKeranjang : Form
    {
        public List<CabangBarang> listCabangBarang = new List<CabangBarang>();
        public Pelanggan pelanggan;
        public FormTambahBarangKeKeranjang()
        {
            InitializeComponent();
        }

        private void FormTambahBarangKeKeranjang_Load(object sender, EventArgs e)
        {
            listCabangBarang = CabangBarang.BacaData("", "");
            FormBarang frm = (FormBarang)this.Owner;
            foreach (CabangBarang cb in listCabangBarang)
            {
                if (cb.Barang.Id == int.Parse(labelIdBarang.Text) && cb.Cabang.Nama == frm.comboBoxCabang.SelectedValue.ToString())
                {
                    labelCabang.Text = cb.Cabang.Nama;
                    numericUpDownJumlahBarang.Maximum = cb.Stok;
                }
            }
            numericUpDownJumlahBarang.Minimum = 0;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Cabang c = new Cabang();
            Barang b = new Barang();
            int jumlah = int.Parse(numericUpDownJumlahBarang.Value.ToString());
            try
            {
                if (jumlah <=0)
                {
                    throw new Exception("Minimum value item is 1.");
                }
                foreach (CabangBarang cb in listCabangBarang)
                {
                    if (cb.Cabang.Nama == labelCabang.Text && cb.Barang.Id == int.Parse(labelIdBarang.Text))
                    {
                        c = new Cabang(cb.Cabang.Id, cb.Cabang.Nama, cb.Cabang.Alamat, cb.Cabang.Pegawai);
                        b = new Barang(cb.Barang.Id, cb.Barang.Nama, cb.Barang.Harga, cb.Barang.Kategori, (byte[])cb.Barang.Images);
                    }
                }
                Keranjang k = new Keranjang(pelanggan, b, c, jumlah);
                Keranjang.TambahData(k, FormLoading.cdb);

                MessageBox.Show("The Items is added to The basket");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
