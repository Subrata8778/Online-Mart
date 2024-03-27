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
    public partial class FormPengaturanKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormPengaturanKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori form = new FormTambahKategori();
            form.Owner = this;
            form.ShowDialog();
        }


        private void textBoxCBPengaturanKategori_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanKategori.Text == "")
            {
                textBoxCBPengaturanKategori.Text = "Type Here...";
                textBoxCBPengaturanKategori.ForeColor = Color.Silver;
                textBoxCBPengaturanKategori.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxCBPengaturanKategori_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanKategori.Text == "Type Here...")
            {
                textBoxCBPengaturanKategori.Text = "";
                textBoxCBPengaturanKategori.ForeColor = Color.Black;
                textBoxCBPengaturanKategori.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        public void FormPengaturanKategori_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listKategori = Kategori.BacaData("", "", FormLoading.cdb);
            TampilDataGrid();
        }
        public void FormatDataGrid()
        {
            dataGridViewPengaturanKategori.DataSource = null;
            dataGridViewPengaturanKategori.Columns.Clear();

            //Atur Tabel
            dataGridViewPengaturanKategori.Columns.Add("id", "ID");
            dataGridViewPengaturanKategori.Columns.Add("nama", "Name");

            //Atur Ukuran Cell
            dataGridViewPengaturanKategori.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanKategori.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Buat button aksi
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.HeaderText = "Action";
            bcol.Text = "Edit";
            bcol.Name = "btnUbahGrid";
            bcol.UseColumnTextForButtonValue = true;
            dataGridViewPengaturanKategori.Columns.Add(bcol);

            DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
            bcol2.HeaderText = "Action";
            bcol2.Text = "Delete";
            bcol2.Name = "btnHapusGrid";
            bcol2.UseColumnTextForButtonValue = true;
            dataGridViewPengaturanKategori.Columns.Add(bcol2);

            dataGridViewPengaturanKategori.BorderStyle = BorderStyle.None;
            dataGridViewPengaturanKategori.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengaturanKategori.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengaturanKategori.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewPengaturanKategori.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengaturanKategori.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewPengaturanKategori.EnableHeadersVisualStyles = false;
            dataGridViewPengaturanKategori.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengaturanKategori.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewPengaturanKategori.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewPengaturanKategori.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPengaturanKategori.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanKategori.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanKategori.RowHeadersVisible = false;
            //Batasi Aktivitas User
            dataGridViewPengaturanKategori.AllowUserToAddRows = false;
            dataGridViewPengaturanKategori.ReadOnly = true;

        }

        public void TampilDataGrid()
        {
            dataGridViewPengaturanKategori.Rows.Clear();

            if (listKategori.Count > 0)
            {
                foreach (Kategori k in listKategori)
                {
                    dataGridViewPengaturanKategori.Rows.Add(k.Id,k.Nama);
                }

            }
            else
            {
                dataGridViewPengaturanKategori.DataSource = null;
            }
        }

        private void dataGridViewPengaturanKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridViewPengaturanKategori.CurrentRow.Cells["id"].Value.ToString();
            string pNamaKategori = dataGridViewPengaturanKategori.CurrentRow.Cells["nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewPengaturanKategori.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pKodeKategori +
                             " - " + pNamaKategori + " ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Kategori.HapusData(pKodeKategori, FormLoading.cdb);
                        if (hapus == true)
                        {
                            MessageBox.Show("Delete success");

                            FormPengaturanKategori_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Delete failed");
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Category id is still used");
                }
            }
            else
            {
                FormUbahKategori frm = new FormUbahKategori();
                frm.Owner = this;
                frm.textBoxIdKategori.Text = pKodeKategori;
                frm.textBoxNamaKategori.Text = pNamaKategori;
                frm.Show();
            }
        }

        private void textBoxCBPengaturanKategori_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            string kriteria = "";
            switch (comboBoxCBPengaturanKategori.Text)
            {
                case "Kode Kategori":
                    kriteria = "Id";
                    break;
                case "Nama Kategori":
                    kriteria = "Nama";
                    break;
            }
            if (textBoxCBPengaturanKategori.Text == "Type Here...")
            {
                listKategori = Kategori.BacaData(kriteria, "", FormLoading.cdb);
            }
            else
            {
                listKategori = Kategori.BacaData(kriteria, textBoxCBPengaturanKategori.Text, FormLoading.cdb);
            }
            TampilDataGrid();
        }
    }
}
