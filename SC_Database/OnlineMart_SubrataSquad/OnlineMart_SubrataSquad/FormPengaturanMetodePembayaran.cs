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
    public partial class FormPengaturanMetodePembayaran : Form
    {
        public List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();
        public FormPengaturanMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahMetodePembayaran form = new FormTambahMetodePembayaran();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonUBAH_Click(object sender, EventArgs e)
        {
            FormUbahMetodePembayaran form = new FormUbahMetodePembayaran();
            form.Owner = this;
            form.ShowDialog();
        }

        private void textBoxCBPengaturanMP_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanMP.Text == "Type Here...")
            {
                textBoxCBPengaturanMP.Text = "";
                textBoxCBPengaturanMP.ForeColor = Color.Black;
                textBoxCBPengaturanMP.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBPengaturanMP_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanMP.Text == "")
            {
                textBoxCBPengaturanMP.Text = "Type Here...";
                textBoxCBPengaturanMP.ForeColor = Color.Silver;
                textBoxCBPengaturanMP.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPengaturanMP.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPengaturanMP.Columns.Add("id", "ID");
            dataGridViewPengaturanMP.Columns.Add("nama", "Name");


            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridViewPengaturanMP.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanMP.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewPengaturanMP.AllowUserToAddRows = false;
            dataGridViewPengaturanMP.ReadOnly = true;

            //Desain Data Grid
            dataGridViewPengaturanMP.BorderStyle = BorderStyle.None;
            dataGridViewPengaturanMP.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengaturanMP.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengaturanMP.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewPengaturanMP.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengaturanMP.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewPengaturanMP.EnableHeadersVisualStyles = false;
            dataGridViewPengaturanMP.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengaturanMP.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewPengaturanMP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewPengaturanMP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPengaturanMP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanMP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanMP.RowHeadersVisible = false;
        }

        public void TampilDataGrid()
        {
            if (listMetodePembayaran.Count > 0)
            {
                foreach (MetodePembayaran mP in listMetodePembayaran)
                {
                    dataGridViewPengaturanMP.Rows.Add(mP.Id, mP.Nama);
                }

                if (!dataGridViewPengaturanMP.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Action";
                    bcol.Text = "Edit";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanMP.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Action";
                    bcol2.Text = "Delete";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanMP.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanMP.DataSource = null;
            }
        }

        public void FormPengaturanMetodePembayaran_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listMetodePembayaran = MetodePembayaran.BacaData("", "", FormLoading.cdb);
            TampilDataGrid(); 
        }

        private void dataGridViewPengaturanMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pKodeKategori = dataGridViewPengaturanMP.CurrentRow.Cells["id"].Value.ToString();
            string pNamaKategori = dataGridViewPengaturanMP.CurrentRow.Cells["nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewPengaturanMP.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pKodeKategori +
                    " - " + pNamaKategori + " ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = MetodePembayaran.HapusData(int.Parse(pKodeKategori), FormLoading.cdb);
                    if (hapus == true)
                    {
                        MessageBox.Show("Delete success");

                        FormPengaturanMetodePembayaran_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }
                }
            }
            else
            {
                FormUbahMetodePembayaran frm = new FormUbahMetodePembayaran();
                frm.Owner = this;
                frm.textBoxKodeMP.Text = pKodeKategori;
                frm.textBoxNamaMP.Text = pNamaKategori;
                frm.Show();
            }
        }

        private void textBoxCBPengaturanMP_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            string kriteria = "";
            switch (comboBoxCBPengaturanMP.Text)
            {
                case "ID Metode Pembayaran":
                    kriteria = "Id";
                    break;
                case "Nama Metode Pembayaran":
                    kriteria = "Nama";
                    break;
            }
            if (textBoxCBPengaturanMP.Text == "Type Here...")
            {
                listMetodePembayaran = MetodePembayaran.BacaData(kriteria, "", FormLoading.cdb);
            }
            else
            {
                listMetodePembayaran = MetodePembayaran.BacaData(kriteria, textBoxCBPengaturanMP.Text, FormLoading.cdb);
            }

            TampilDataGrid();
        }
    }
}
