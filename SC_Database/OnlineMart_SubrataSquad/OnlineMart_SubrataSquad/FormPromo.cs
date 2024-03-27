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
    public partial class FormPromo : Form
    {
        public FormPromo()
        {
            InitializeComponent();
        }
        List<Promo> listpromo = new List<Promo>();

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDeals_Enter(object sender, EventArgs e)
        {
            if (textBoxDeals.Text == "Type Here...")
            {
                textBoxDeals.Text = "";
                textBoxDeals.ForeColor = Color.Black;
                textBoxDeals.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxDeals_Leave(object sender, EventArgs e)
        {
            if (textBoxDeals.Text == "")
            {
                textBoxDeals.Text = "Type Here...";
                textBoxDeals.ForeColor = Color.Silver;
                textBoxDeals.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void FormPromo_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listpromo = Promo.BacaData("", "", FormLoading.cdb);
            TampilDataGrid();
        }
        public void TampilDataGrid()
        {
            dataGridViewDeals.Rows.Clear();

            if (listpromo.Count > 0)
            {
                foreach (Promo p in listpromo)
                {
                    dataGridViewDeals.Rows.Add(p.Id, p.Tipe, p.Nama, p.Diskon,p.Diskon_max,p.Min_belanja);
                }
            }
            else
            {
                dataGridViewDeals.DataSource = null;
            }
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewDeals.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewDeals.Columns.Add("id", "ID");
            dataGridViewDeals.Columns.Add("tipe", "Type");
            dataGridViewDeals.Columns.Add("nama", "Name");
            dataGridViewDeals.Columns.Add("diskon", "Discount");
            dataGridViewDeals.Columns.Add("diskon_max", "Max Discount");
            dataGridViewDeals.Columns.Add("min_belanja", "Min Expense");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridViewDeals.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["tipe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["diskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["diskon_max"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDeals.Columns["min_belanja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewDeals.AllowUserToAddRows = false;
            dataGridViewDeals.ReadOnly = true;

            //Desain Data Grid
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
        }

        private void textBoxDeals_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            string kriteria = "";
            switch (comboBoxDeals.Text)
            {
                case "Kode Deals":
                    kriteria = "id";
                    break;
                case "Tipe Deals":
                    kriteria = "tipe";
                    break;
                case "Nama Deals":
                    kriteria = "nama";
                    break;
                case "Diskon":
                    kriteria = "diskon";
                    break;
                case "Diskon Max":
                    kriteria = "diskon_max";
                    break;
                case "Minimal Belanja":
                    kriteria = "minimal_belanja";
                    break;
            }
            if (comboBoxDeals.Text == "Type Here...")
            {
                listpromo = Promo.BacaData(kriteria, "", FormLoading.cdb);
            }
            else
            {
                listpromo = Promo.BacaData(kriteria, textBoxDeals.Text, FormLoading.cdb);
            }
            TampilDataGrid();
        }
    }
}
