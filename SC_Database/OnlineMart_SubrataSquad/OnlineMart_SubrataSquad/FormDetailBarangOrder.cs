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
    public partial class FormDetailBarangOrder : Form
    {
        public string id;
        List<BarangOrder> listBarangOrder = new List<BarangOrder>();

        public FormDetailBarangOrder()
        {
            InitializeComponent();
        }

        private void FormDetailBarangOrder_Load(object sender, EventArgs e)
        {
            FormHistory frm = new FormHistory();
            listBarangOrder = BarangOrder.BacaData("o.Id", id);
            FormatDataGrid();
        }

        public void FormatDataGrid()
        {
            dataGridViewHistory.DataSource = null;
            dataGridViewHistory.Columns.Clear();

            //Atur Tabel Gambar
            dataGridViewHistory.RowTemplate.Height = 75;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridViewHistory.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";

            //Atur Tabel
            dataGridViewHistory.Columns.Add("Id", "Id");
            dataGridViewHistory.Columns.Add("Jumlah", "Quantity");
            dataGridViewHistory.Columns.Add("Harga", "Price");

            //Atur Ukuran Cell
            dataGridViewHistory.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHistory.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHistory.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Batasi Aktivitas User
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.ReadOnly = true;

            //Desain Data Grid
            dataGridViewHistory.BorderStyle = BorderStyle.None;
            dataGridViewHistory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewHistory.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewHistory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewHistory.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewHistory.EnableHeadersVisualStyles = false;
            dataGridViewHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewHistory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHistory.RowHeadersVisible = false;

            TampilDataGrid();
        }
        public void TampilDataGrid()
        {
            dataGridViewHistory.Rows.Clear();

            if (listBarangOrder.Count > 0)
            {
                foreach (BarangOrder bo in listBarangOrder)
                {
                    dataGridViewHistory.Rows.Add(bo.Barang.Images, bo.Barang.Nama, bo.Jumlah, bo.Harga);
                }
            }
            else
            {
                dataGridViewHistory.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
