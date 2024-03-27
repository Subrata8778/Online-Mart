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
    public partial class FormPengaturanHadiah : Form
    {
        public List<Gift> listHadiah = new List<Gift>();
        public FormPengaturanHadiah()
        {
            InitializeComponent();
        }


        private void textBoxCBPengaturanHadiah_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanHadiah.Text == "Type Here...")
            {
                textBoxCBPengaturanHadiah.Text = "";
                textBoxCBPengaturanHadiah.ForeColor = Color.Black;
                textBoxCBPengaturanHadiah.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBPengaturanHadiah_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanHadiah.Text == "")
            {
                textBoxCBPengaturanHadiah.Text = "Type Here...";
                textBoxCBPengaturanHadiah.ForeColor = Color.Silver;
                textBoxCBPengaturanHadiah.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahHadiah form = new FormTambahHadiah();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPengaturanHadiah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeHadiah = dataGridViewPengaturanHadiah.CurrentRow.Cells["id"].Value.ToString();
            string pNamaHadiah = dataGridViewPengaturanHadiah.CurrentRow.Cells["nama"].Value.ToString();
            string pJumlahPoin = dataGridViewPengaturanHadiah.CurrentRow.Cells["jumlah_poin"].Value.ToString();

            if (e.ColumnIndex == dataGridViewPengaturanHadiah.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pKodeHadiah +
                    " - " + pNamaHadiah + " ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Gift.HapusData(pKodeHadiah, FormLoading.cdb);
                    if (hapus == true)
                    {
                        MessageBox.Show("Delete success");

                        FormPengaturanHadiah_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }
                }
            }
            else
            {
                FormUbahHadiah frm = new FormUbahHadiah();
                frm.Owner = this;
                frm.textBoxIDHadiah.Text = pKodeHadiah;
                frm.textBoxNamaHadiah.Text = pNamaHadiah;
                frm.textBoxJumlahPoin.Text = pJumlahPoin;
                frm.Show();
            }
        }

        public void TampilDataGrid()
        {
            dataGridViewPengaturanHadiah.Rows.Clear();

            if (listHadiah.Count > 0)
            {
                foreach (Gift g in listHadiah)
                {
                    dataGridViewPengaturanHadiah.Rows.Add(g.Id, g.Nama, g.JumlahPoin);
                }

                if (!dataGridViewPengaturanHadiah.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Action";
                    bcol.Text = "Edit";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanHadiah.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Action";
                    bcol2.Text = "Delete";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanHadiah.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanHadiah.DataSource = null;
            }
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPengaturanHadiah.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPengaturanHadiah.Columns.Add("id", "ID");
            dataGridViewPengaturanHadiah.Columns.Add("nama", "Name");
            dataGridViewPengaturanHadiah.Columns.Add("jumlah_poin", "Total Poin");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridViewPengaturanHadiah.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanHadiah.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanHadiah.Columns["jumlah_poin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewPengaturanHadiah.AllowUserToAddRows = false;
            dataGridViewPengaturanHadiah.ReadOnly = true;

            //Desain Data Grid
            dataGridViewPengaturanHadiah.BorderStyle = BorderStyle.None;
            dataGridViewPengaturanHadiah.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengaturanHadiah.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengaturanHadiah.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewPengaturanHadiah.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengaturanHadiah.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewPengaturanHadiah.EnableHeadersVisualStyles = false;
            dataGridViewPengaturanHadiah.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengaturanHadiah.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewPengaturanHadiah.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewPengaturanHadiah.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPengaturanHadiah.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanHadiah.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanHadiah.RowHeadersVisible = false;
        }

        private void textBoxCBPengaturanHadiah_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            string kriteria = "";
            switch (comboBoxCBPengaturanHadiah.Text)
            {
                case "ID Hadiah":
                    kriteria = "id";
                    break;
                case "Nama Hadiah":
                    kriteria = "nama";
                    break;
                case "Jumlah Poin":
                    kriteria = "jumlah_poin";
                    break;
            }
            if (textBoxCBPengaturanHadiah.Text == "Type Here...")
            {
                listHadiah = Gift.BacaData(kriteria, "", FormLoading.cdb);
            }
            else
            {
                listHadiah = Gift.BacaData(kriteria, textBoxCBPengaturanHadiah.Text, FormLoading.cdb);
            }

            TampilDataGrid();
        }

        public void FormPengaturanHadiah_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listHadiah = Gift.BacaData("", "", FormLoading.cdb);

            TampilDataGrid();
        }
    }
}
