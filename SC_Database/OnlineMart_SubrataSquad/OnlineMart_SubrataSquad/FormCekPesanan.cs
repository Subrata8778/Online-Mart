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
using System.Windows.Forms.VisualStyles;

namespace OnlineMart_SubrataSquad
{
    public partial class FormCekPesanan : Form
    {
        public Pelanggan pelanggan;
        List<Order> listOrder = new List<Order>();
        public FormCekPesanan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCekPesanan_Load(object sender, EventArgs e)
        {
            listOrder = Order.BacaData("pe.Nama", pelanggan.Nama);
            FormatDataGrid();
        }

        public void FormatDataGrid()
        {
            dataGridViewCekPesanan.DataSource = null;
            dataGridViewCekPesanan.Columns.Clear();

            //Atur Tabel
            dataGridViewCekPesanan.Columns.Add("Id", "Id");
            dataGridViewCekPesanan.Columns.Add("Status", "Status");
            dataGridViewCekPesanan.Columns.Add("Driver", "Driver");

            //Atur Ukuran Cell
            dataGridViewCekPesanan.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCekPesanan.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCekPesanan.Columns["Driver"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Action";
            bcol.Text = "Chat";
            bcol.Name = "btnChat";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewCekPesanan.Columns.Add(bcol);

            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
            bcol2.HeaderText = "Action";
            bcol2.Text = "Accept Products";
            bcol2.Name = "btnTerimaBarang";
            bcol2.UseColumnTextForButtonValue = true;
            dataGridViewCekPesanan.Columns.Add(bcol2);


            //Batasi Aktivitas User
            dataGridViewCekPesanan.AllowUserToAddRows = false;
            dataGridViewCekPesanan.ReadOnly = true;

            //Desain Data Grid
            dataGridViewCekPesanan.BorderStyle = BorderStyle.None;
            dataGridViewCekPesanan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCekPesanan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCekPesanan.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewCekPesanan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCekPesanan.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewCekPesanan.EnableHeadersVisualStyles = false;
            dataGridViewCekPesanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCekPesanan.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewCekPesanan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewCekPesanan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewCekPesanan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCekPesanan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCekPesanan.RowHeadersVisible = false;

            TampilDataGrid();
        }
        public void TampilDataGrid()
        {
            dataGridViewCekPesanan.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order order in listOrder)
                {
                    dataGridViewCekPesanan.Rows.Add(order.Id, order.Status, order.Driver.Nama);
                }
            }
            else
            {
                dataGridViewCekPesanan.DataSource = null;
            }
        }

        private void buttonCetakNota_Click(object sender, EventArgs e)
        {
            FormCetakNota form = new FormCetakNota();
            form.Owner = this;
            form.ShowDialog();
        }

        private void dataGridViewCekPesanan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bool statusUbah;
            string idOrder = dataGridViewCekPesanan.CurrentRow.Cells["Id"].Value.ToString();
            string statusKirim = dataGridViewCekPesanan.CurrentRow.Cells["Status"].Value.ToString();
            string drivers = dataGridViewCekPesanan.CurrentRow.Cells["Driver"].Value.ToString();

            if (e.ColumnIndex == dataGridViewCekPesanan.Columns["btnTerimaBarang"].Index && e.RowIndex >= 0)
            {
                if (statusKirim != "Diterima")
                {
                    DialogResult hasil = MessageBox.Show(this, "Are you sure? ", "ACCEPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        if (statusKirim != "Diterima")
                        {
                            statusUbah = Order.UbahStatus("Diterima", int.Parse(idOrder),FormLoading.cdb);
                            if (statusUbah)
                            {
                                FormCekPesanan_Load(sender, e);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Your Order(s) has been arrived. Thankyou!");
                }
            }
            else if (e.ColumnIndex == dataGridViewCekPesanan.Columns["btnChat"].Index && e.RowIndex >= 0)
            {
                FormChat frm = new FormChat();
                if (statusKirim != "Diterima")
                {
                    foreach (Order o in listOrder)
                    {
                        if (o.Driver.Nama == drivers)
                        {
                            frm.driver = o.Driver;
                        }
                    }

                    frm.Owner = this;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your Order(s) has been arrived. Thankyou!");
                }
            }
        }
    }
}
