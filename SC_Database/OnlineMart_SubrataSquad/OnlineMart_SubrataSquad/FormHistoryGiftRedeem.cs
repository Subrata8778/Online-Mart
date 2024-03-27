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
    public partial class FormHistoryGiftRedeem : Form
    {
        List<GiftRedeem> listGiftRedeem = new List<GiftRedeem>();
        public FormHistoryGiftRedeem()
        {
            InitializeComponent();
        }

        private void FormHistoryGiftRedeem_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listGiftRedeem = GiftRedeem.BacaData("", "");

            TampilDataGrid();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridHistoryGR.Columns.Clear();

            //menambah kolom di datagridview
            dataGridHistoryGR.Columns.Add("id", "ID");
            dataGridHistoryGR.Columns.Add("waktu", "Date");
            dataGridHistoryGR.Columns.Add("poin_redeem", "Poin Redeem");
            dataGridHistoryGR.Columns.Add("gifts_id", "Name of Gift");
            dataGridHistoryGR.Columns.Add("orders_id", "Order ID");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridHistoryGR.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistoryGR.Columns["waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistoryGR.Columns["poin_redeem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistoryGR.Columns["gifts_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridHistoryGR.Columns["orders_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridHistoryGR.AllowUserToAddRows = false;
            dataGridHistoryGR.ReadOnly = true;

            //Desain Data Grid
            dataGridHistoryGR.BorderStyle = BorderStyle.None;
            dataGridHistoryGR.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridHistoryGR.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridHistoryGR.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridHistoryGR.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridHistoryGR.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridHistoryGR.EnableHeadersVisualStyles = false;
            dataGridHistoryGR.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridHistoryGR.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridHistoryGR.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridHistoryGR.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridHistoryGR.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridHistoryGR.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridHistoryGR.RowHeadersVisible = false;
        }

        public void TampilDataGrid()
        {
            dataGridHistoryGR.Rows.Clear();

            if (listGiftRedeem.Count > 0)
            {
                foreach (GiftRedeem gr in listGiftRedeem)
                {
                    dataGridHistoryGR.Rows.Add(gr.Id, gr.Waktu.ToString("yyyy-MM-dd"), gr.PoinRedeem, gr.Gift.Nama, gr.Order.Id);
                }
            }
            else
            {
                dataGridHistoryGR.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxHistoryGR_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            string kriteria = "";
            switch (comboBoxHistoryGR.Text)
            {
                case "ID Promo":
                    kriteria = "id";
                    break;
                case "Nama Promo":
                    kriteria = "nama";
                    break;
                case "Tipe Promo":
                    kriteria = "tipe";
                    break;
                case "Diskon Promo":
                    kriteria = "diskon";
                    break;
                case "Diskon Max":
                    kriteria = "diskon_max";
                    break;
                case "Minimal Belanja":
                    kriteria = "minimal_belanja";
                    break;
            }

            if (comboBoxHistoryGR.Text == "Type Here...")
            {
                listGiftRedeem = GiftRedeem.BacaData(kriteria, "");
            }
            else
            {
                listGiftRedeem = GiftRedeem.BacaData(kriteria, textBoxHistoryGR.Text);
            }

            TampilDataGrid();
        }
    }
}
