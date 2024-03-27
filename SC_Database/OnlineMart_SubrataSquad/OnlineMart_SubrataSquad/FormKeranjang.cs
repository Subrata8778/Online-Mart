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
    public partial class FormKeranjang : Form
    {
        public Pelanggan pelanggan;
        public List<Barang> listBarang = new List<Barang>();
        public List<Cabang> listCabang = new List<Cabang>();
        public List<Keranjang> listKeranjang = new List<Keranjang>();

        public FormKeranjang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (listKeranjang.Count <= 0)
                {
                    throw new Exception("The basket cannot be empty");
                }
                FormCheckout form = new FormCheckout();
                form.Owner = this;
                form.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Checkout fail. Error Message : " + ex.Message, "Failure");
            }

        }

        public void FormKeranjang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listKeranjang = Keranjang.BacaData(pelanggan.Id);

            listBarang = Barang.BacaData("", "", FormLoading.cdb);
            listCabang = Cabang.BacaData("", "", FormLoading.cdb);

            TampilDataGrid();
        }

        public void FormatDataGrid()
        {
            dataGridViewKeranjang.DataSource = null;
            dataGridViewKeranjang.Columns.Clear();

            //Atur Tabel Gambar
            dataGridViewKeranjang.RowTemplate.Height = 75;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridViewKeranjang.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";

            //Atur Tabel
            dataGridViewKeranjang.Columns.Add("Barang", "Product");
            dataGridViewKeranjang.Columns.Add("Cabang", "Branch");
            dataGridViewKeranjang.Columns.Add("Jumlah", "Quantity");

            //Atur Ukuran Cell
            dataGridViewKeranjang.Columns["Barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Hapus";
            bcol.Name = "btnHapus";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewKeranjang.Columns.Add(bcol);

            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
            bcol2.HeaderText = "Aksi";
            bcol2.Text = "Ubah";
            bcol2.Name = "btnUbah";
            bcol2.UseColumnTextForButtonValue = true;
            dataGridViewKeranjang.Columns.Add(bcol2);

            //Batasi Aktivitas User
            dataGridViewKeranjang.AllowUserToAddRows = false;
            dataGridViewKeranjang.ReadOnly = true;

            //Desain Data Grid
            dataGridViewKeranjang.BorderStyle = BorderStyle.None;
            dataGridViewKeranjang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewKeranjang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewKeranjang.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewKeranjang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewKeranjang.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewKeranjang.EnableHeadersVisualStyles = false;
            dataGridViewKeranjang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewKeranjang.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewKeranjang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewKeranjang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewKeranjang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKeranjang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKeranjang.RowHeadersVisible = false;
        }
        public void TampilDataGrid()
        {
            dataGridViewKeranjang.Rows.Clear();

            if (listKeranjang.Count > 0)
            {
                foreach (Keranjang k in listKeranjang)
                {
                    dataGridViewKeranjang.Rows.Add(k.Barang.Images, k.Barang.Nama, k.Cabang.Nama, k.Jumlah);
                }
            }
            else
            {
                dataGridViewKeranjang.DataSource = null;
            }
        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string namaBarang = dataGridViewKeranjang.CurrentRow.Cells["Barang"].Value.ToString();
            string namaCabang = dataGridViewKeranjang.CurrentRow.Cells["Cabang"].Value.ToString();
            string jumlah = dataGridViewKeranjang.CurrentRow.Cells["Jumlah"].Value.ToString();
            Keranjang ker = new Keranjang();

            if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? ", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {

                    foreach (Barang b in listBarang)
                    {
                        foreach (Cabang c in listCabang)
                        {
                            if (b.Nama == namaBarang && c.Nama == namaCabang)
                            {
                                ker = new Keranjang(pelanggan, b, c, int.Parse(jumlah));
                            }
                        }
                    }
                    Boolean hapus = Keranjang.HapusKeranjang(ker, FormLoading.cdb);
                    if (hapus == true)
                    {
                        MessageBox.Show("Deletion success");

                        FormKeranjang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed");
                    }
                }
            }
            else if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnUbah"].Index && e.RowIndex >= 0)
            {
                FormUbahJumlahBarang formUbahJumlahBarang = new FormUbahJumlahBarang();
                formUbahJumlahBarang.Owner = this;
                formUbahJumlahBarang.textBoxBarang.Text = namaBarang;
                formUbahJumlahBarang.textBoxCabang.Text = namaCabang;
                formUbahJumlahBarang.textBoxJumlah.Text = jumlah;
                formUbahJumlahBarang.ShowDialog();
            }
        }
    }
}
