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
    public partial class FormRekapPenjualanBarang : Form
    {
        List<BarangOrder> listBarangOrder = new List<BarangOrder>();
        List<Order> listOrder = new List<Order>();
        List<Cabang> listCabang = new List<Cabang>();

        public FormRekapPenjualanBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRekapPenjualanBarang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listBarangOrder = BarangOrder.BacaData("", "");
            listOrder = Order.BacaData("", "");
            listCabang = Cabang.BacaData("", "", FormLoading.cdb);
            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.DisplayMember = "Nama";

            comboBoxBulan.SelectedIndex = 0;

            TampilDataGrid();
        }

        private void FormatDataGrid()
        {
            dataGridViewRekapPenjualanBarang.DataSource = null;
            dataGridViewRekapPenjualanBarang.Columns.Clear();

            //Atur Tabel
            dataGridViewRekapPenjualanBarang.Columns.Add("tanggal", "Date");
            dataGridViewRekapPenjualanBarang.Columns.Add("cabang", "Branch");
            dataGridViewRekapPenjualanBarang.Columns.Add("barang", "Product");
            dataGridViewRekapPenjualanBarang.Columns.Add("jumlah", "Quantity");
            dataGridViewRekapPenjualanBarang.Columns.Add("subTotal", "Sub Total");


            //Atur Ukuran Cell
            dataGridViewRekapPenjualanBarang.Columns["tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRekapPenjualanBarang.Columns["subTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewRekapPenjualanBarang.AllowUserToAddRows = false;
            dataGridViewRekapPenjualanBarang.ReadOnly = true;

            //Desain Data Grid
            dataGridViewRekapPenjualanBarang.BorderStyle = BorderStyle.None;
            dataGridViewRekapPenjualanBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewRekapPenjualanBarang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewRekapPenjualanBarang.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewRekapPenjualanBarang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewRekapPenjualanBarang.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewRekapPenjualanBarang.EnableHeadersVisualStyles = false;
            dataGridViewRekapPenjualanBarang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewRekapPenjualanBarang.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewRekapPenjualanBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewRekapPenjualanBarang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewRekapPenjualanBarang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewRekapPenjualanBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewRekapPenjualanBarang.RowHeadersVisible = false;
        }

        private void TampilDataGrid()
        {
            dataGridViewRekapPenjualanBarang.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order order in listOrder)
                {
                    foreach (BarangOrder barangOrder in listBarangOrder)
                    {
                        dataGridViewRekapPenjualanBarang.Rows.Add(order.TanggalWaktu, order.Cabang.Nama, barangOrder.Barang.Nama, barangOrder.Jumlah, barangOrder.Jumlah*int.Parse(barangOrder.Harga));
                    }
                }
            }
            else
            {
                dataGridViewRekapPenjualanBarang.DataSource = null;
            }
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
            listOrder = Order.BacaData(comboBoxCabang.Text, "", bulan, numericUpDownTahun.Value.ToString());
            TampilDataGrid();
        }

        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void numericUpDownTahun_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
