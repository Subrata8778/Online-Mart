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
    public partial class FormRekapPendapatan : Form
    {
        public List<Order> listOrder = new List<Order>();
        Driver kurir;
        public FormRekapPendapatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRekapPendapatan_Load(object sender, EventArgs e)
        {
            FormUtamaDriver frm = (FormUtamaDriver)this.Owner;
            kurir = frm.driver;

            FormatDataGrid();
            listOrder = Order.TampilOrder(kurir.Id.ToString());
            labelTotalKomisi.Text = "Income Total " + kurir.Nama + ": " + Driver.TotalKomisi(listOrder).ToString("C0", new CultureInfo("id"));
            TampilDataGrid();
        }

        public void TampilDataGrid()
        {
            dataGridViewRekapPendapatan.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewRekapPendapatan.Rows.Add(o.Id, o.TanggalWaktu.ToString("yyyy-MM-dd"),
                        o.Pelanggan.Nama, o.AlamatTujuan, (o.OngkosKirim * 0.8));
                }
            }
            else
            {
                dataGridViewRekapPendapatan.DataSource = null;
            }
        }

        public void FormatDataGrid()
        {
            dataGridViewRekapPendapatan.DataSource = null;
            dataGridViewRekapPendapatan.Columns.Clear();

            //Atur Tabel
            dataGridViewRekapPendapatan.Columns.Add("id", "ID");
            dataGridViewRekapPendapatan.Columns.Add("tanggal_waktu", "Date");
            dataGridViewRekapPendapatan.Columns.Add("pelanggans_id", "Customer's Name");
            dataGridViewRekapPendapatan.Columns.Add("alamat_tujuan", "Address");
            dataGridViewRekapPendapatan.Columns.Add("komisi", "Commision");


            //Atur Ukuran Cell
            dataGridViewRekapPendapatan.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["pelanggans_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPendapatan.Columns["komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Agar rata kanan
            dataGridViewRekapPendapatan.Columns["komisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Agar komisi ditampilkan dengan format pemisah ribuan (1000 delimiter)
            dataGridViewRekapPendapatan.Columns["komisi"].DefaultCellStyle.Format = "#,###";

            //Batasi Aktivitas User
            dataGridViewRekapPendapatan.AllowUserToAddRows = false;
            dataGridViewRekapPendapatan.ReadOnly = true;

            //Desain Data Grid
            dataGridViewRekapPendapatan.BorderStyle = BorderStyle.None;
            dataGridViewRekapPendapatan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewRekapPendapatan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRekapPendapatan.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewRekapPendapatan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewRekapPendapatan.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewRekapPendapatan.EnableHeadersVisualStyles = false;
            dataGridViewRekapPendapatan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRekapPendapatan.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewRekapPendapatan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewRekapPendapatan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewRekapPendapatan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewRekapPendapatan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewRekapPendapatan.RowHeadersVisible = false;
        }

        private void Filter()
        {
            int bulan = 0;
            switch (comboBoxBulan.Text)
            {
                case "Semua Bulan":
                    bulan = 0;
                    break;
                case "Januari":
                    bulan = 1;
                    break;
                case "Februari":
                    bulan = 2;
                    break;
                case "Maret":
                    bulan = 3;
                    break;
                case "April":
                    bulan = 4;
                    break;
                case "Mei":
                    bulan = 5;
                    break;
                case "Juni":
                    bulan = 6;
                    break;
                case "Juli":
                    bulan = 7;
                    break;
                case "Agustus":
                    bulan = 8;
                    break;
                case "September":
                    bulan = 9;
                    break;
                case "Oktober":
                    bulan = 10;
                    break;
                case "November":
                    bulan = 11;
                    break;
                case "Desember":
                    bulan = 12;
                    break;
            }
            listOrder = Order.BacaData("", kurir.Id.ToString(), bulan, numericUpDownTahun.Value.ToString());
            TampilDataGrid();
        }

        private void numericUpDownTahun_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
