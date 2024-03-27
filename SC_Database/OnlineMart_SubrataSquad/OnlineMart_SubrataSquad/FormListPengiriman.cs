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
    public partial class FormListPengiriman : Form
    {
        public Driver driver;
        public List<Order> listOrder = new List<Order>();
        FormUtamaDriver frm;
        Driver kurir;
        public FormListPengiriman()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            FormListPengirimanDetail form = new FormListPengirimanDetail();
            form.Owner = this;
            form.ShowDialog();
        }

        private void textBoxCBListPengiriman_Enter(object sender, EventArgs e)
        {
            if (textBoxCBListPengiriman.Text == "Type Here...")
            {
                textBoxCBListPengiriman.Text = "";
                textBoxCBListPengiriman.ForeColor = Color.Black;
                textBoxCBListPengiriman.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBListPengiriman_Leave(object sender, EventArgs e)
        {
            if (textBoxCBListPengiriman.Text == "")
            {
                textBoxCBListPengiriman.Text = "Type Here...";
                textBoxCBListPengiriman.ForeColor = Color.Silver;
                textBoxCBListPengiriman.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        public void FormatDataGrid()
        {
            dataGridViewListPengiriman .DataSource = null;
            dataGridViewListPengiriman.Columns.Clear();

            //Atur Tabel
            dataGridViewListPengiriman.Columns.Add("id", "Order ID");
            dataGridViewListPengiriman.Columns.Add("tanggal_waktu", "Date");
            dataGridViewListPengiriman.Columns.Add("pelanggans_id", "Customer's Name");
            dataGridViewListPengiriman.Columns.Add("alamat_tujuan", "Destionation");
            dataGridViewListPengiriman.Columns.Add("ongkos_kirim", "Shipping Fee");
            dataGridViewListPengiriman.Columns.Add("status_kirim", "Shipping Status");


            //Atur Ukuran Cell
            dataGridViewListPengiriman.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["pelanggans_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewListPengiriman.Columns["status_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Agar rata kanan
            dataGridViewListPengiriman.Columns["ongkos_kirim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Agar komisi ditampilkan dengan format pemisah ribuan
            dataGridViewListPengiriman.Columns["ongkos_kirim"].DefaultCellStyle.Format = "#,###";

            //Buat Button Aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Aksi";
            bcol.Text = "Detail";
            bcol.Name = "btnDetailGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewListPengiriman.Columns.Add(bcol);

            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
            bcol2.HeaderText = "Aksi";
            bcol2.Text = "Chat";
            bcol2.Name = "btnChat";
            bcol2.UseColumnTextForButtonValue = true;
            dataGridViewListPengiriman.Columns.Add(bcol2);

            //Batasi Aktivitas User
            dataGridViewListPengiriman.AllowUserToAddRows = false;
            dataGridViewListPengiriman.ReadOnly = true;

            //Desain Data Grid
            dataGridViewListPengiriman.BorderStyle = BorderStyle.None;
            dataGridViewListPengiriman.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewListPengiriman.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewListPengiriman.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewListPengiriman.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewListPengiriman.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewListPengiriman.EnableHeadersVisualStyles = false;
            dataGridViewListPengiriman.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewListPengiriman.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewListPengiriman.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewListPengiriman.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewListPengiriman.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewListPengiriman.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewListPengiriman.RowHeadersVisible = false;
        }
        public void TampilDataGrid()
        {
            dataGridViewListPengiriman.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewListPengiriman.Rows.Add(o.Id, o.TanggalWaktu.ToString("yyyy-MM-dd"), 
                        o.Pelanggan.Nama, o.AlamatTujuan, o.OngkosKirim, o.StatusKirim);
                }
            }
            else
            {
                dataGridViewListPengiriman.DataSource = null;
            }
        }

        public void FormListPengiriman_Load(object sender, EventArgs e)
        {
            frm = (FormUtamaDriver)this.Owner;
            kurir = frm.driver;

            FormatDataGrid();
            listOrder = Order.TampilOrder(kurir.Id.ToString());
            TampilDataGrid();
        }

        private void textBoxCBListPengiriman_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            if (comboBoxCBListPengiriman.Text == "ID Order")
            {
                listOrder = Order.BacaData("o.drivers_Id = " + kurir.Id.ToString() + " AND o.Id", textBoxCBListPengiriman.Text);
            }
            TampilDataGrid();
        }

        private void dataGridViewListPengiriman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idOrder = dataGridViewListPengiriman.CurrentRow.Cells["id"].Value.ToString();
            string tanggal = dataGridViewListPengiriman.CurrentRow.Cells["tanggal_waktu"].Value.ToString();
            string namaKonsumen = dataGridViewListPengiriman.CurrentRow.Cells["pelanggans_id"].Value.ToString();
            string alamatKonsumen = dataGridViewListPengiriman.CurrentRow.Cells["alamat_tujuan"].Value.ToString();
            float ongkoskirim = float.Parse(dataGridViewListPengiriman.CurrentRow.Cells["ongkos_kirim"].Value.ToString());
            string statusKirim = dataGridViewListPengiriman.CurrentRow.Cells["status_kirim"].Value.ToString();
            if (e.ColumnIndex == dataGridViewListPengiriman.Columns["btnDetailGrid"].Index && e.RowIndex >= 0)
            {
                if(statusKirim == "Accepted" || statusKirim == "Declined")
                {
                    MessageBox.Show("You've been chosen this section");
                }
                else if(statusKirim == "Waiting")
                {
                    FormListPengirimanDetail frm = new FormListPengirimanDetail();
                    frm.Owner = this;
                    frm.textBoxIDOrder.Text = idOrder;
                    frm.textBoxNamaKonsumen.Text = namaKonsumen;
                    frm.textBoxAlamatTujuan.Text = alamatKonsumen;
                    frm.textBoxKomisi.Text = Order.KomisiDriver(ongkoskirim).ToString();
                    frm.ShowDialog();
                }
                
            }
            else if (e.ColumnIndex == dataGridViewListPengiriman.Columns["btnChat"].Index && e.RowIndex >= 0)
            {
                if(statusKirim == "Accepted")
                {
                    string pelanggan = dataGridViewListPengiriman.CurrentRow.Cells["pelanggans_id"].Value.ToString();
                    FormChat frm = new FormChat();
                    foreach (Order o in listOrder)
                    {
                        if (o.Pelanggan.Nama == pelanggan)
                        {
                            frm.pelanggan = o.Pelanggan;
                        }
                    }
                    frm.Owner = this;
                    frm.ShowDialog();
                }
                else if(statusKirim == "Waiting")
                {
                    MessageBox.Show("Please accept the order first.");
                }
                else
                {
                    MessageBox.Show("You rejected this order.");
                }
            }
        }
    }
}
