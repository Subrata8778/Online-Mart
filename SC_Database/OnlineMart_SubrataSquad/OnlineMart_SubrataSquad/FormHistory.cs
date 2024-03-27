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
    public partial class FormHistory : Form
    {
        public Pelanggan pelanggan;
        List<Order> listOrder = new List<Order>();

        public FormHistory()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            listOrder = Order.BacaData("pe.Id", pelanggan.Id.ToString());

            FormatDataGrid();
        }

        public void FormatDataGrid()
        {
            dataGridViewHistory.DataSource = null;
            dataGridViewHistory.Columns.Clear();

            //Atur Tabel
            dataGridViewHistory.Columns.Add("Id", "Id");
            dataGridViewHistory.Columns.Add("Total_Bayar", "Total Payment");

            //Atur Ukuran Cell
            dataGridViewHistory.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewHistory.Columns["Total_Bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Action";
            bcol.Text = "Detail";
            bcol.Name = "btnDetail";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewHistory.Columns.Add(bcol);

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

            if (listOrder.Count > 0)
            {
                foreach (Order order in listOrder)
                {
                    dataGridViewHistory.Rows.Add(order.Id, order.TotalBayar);
                }
            }
            else
            {
                dataGridViewHistory.DataSource = null;
            }
        }

        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idOrder = dataGridViewHistory.CurrentRow.Cells["Id"].Value.ToString();

            FormDetailBarangOrder frm = new FormDetailBarangOrder();
            frm.id = idOrder;
            frm.Show();
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            FormCekPesanan frm = new FormCekPesanan();
            frm.Owner = this;
            frm.pelanggan = pelanggan;
            frm.Show();
        }
    }
}
