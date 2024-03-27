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
    public partial class FormPengaturanCabang : Form
    {
        public List<Cabang> listCabang = new List<Cabang>();

        public FormPengaturanCabang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCabang form = new FormTambahCabang();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahCabang form = new FormUbahCabang();
            form.Owner = this;
            form.ShowDialog();
        }

        private void textBoxCBPengaturanCabang_Enter(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanCabang.Text == "Type Here...")
            {
                textBoxCBPengaturanCabang.Text = "";
                textBoxCBPengaturanCabang.ForeColor = Color.Black;
                textBoxCBPengaturanCabang.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxCBPengaturanCabang_Leave(object sender, EventArgs e)
        {
            if (textBoxCBPengaturanCabang.Text == "")
            {
                textBoxCBPengaturanCabang.Text = "Type Here...";
                textBoxCBPengaturanCabang.ForeColor = Color.Silver;
                textBoxCBPengaturanCabang.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        public void FormPengaturanCabang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listCabang = Cabang.BacaData("", "", FormLoading.cdb);

            TampilDataGrid();
        }

        public void TampilDataGrid()
        {
            dataGridViewPengaturanCabang.Rows.Clear();

            if (listCabang.Count > 0)
            {
                foreach (Cabang c in listCabang)
                {
                    dataGridViewPengaturanCabang.Rows.Add(c.Id, c.Nama, c.Alamat, c.Pegawai.Nama);
                }

                if (!dataGridViewPengaturanCabang.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Action";
                    bcol.Text = "Edit";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanCabang.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Action";
                    bcol2.Text = "Delete";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanCabang.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanCabang.DataSource = null;
            }
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPengaturanCabang.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPengaturanCabang.Columns.Add("id", "ID");
            dataGridViewPengaturanCabang.Columns.Add("nama", "Name");
            dataGridViewPengaturanCabang.Columns.Add("alamat", "Address");
            dataGridViewPengaturanCabang.Columns.Add("pegawais_id", "Employee");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridViewPengaturanCabang.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanCabang.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanCabang.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanCabang.Columns["pegawais_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewPengaturanCabang.AllowUserToAddRows = false;
            dataGridViewPengaturanCabang.ReadOnly = true;

            //Desain Data Grid
            dataGridViewPengaturanCabang.BorderStyle = BorderStyle.None;
            dataGridViewPengaturanCabang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengaturanCabang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengaturanCabang.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewPengaturanCabang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengaturanCabang.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewPengaturanCabang.EnableHeadersVisualStyles = false;
            dataGridViewPengaturanCabang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengaturanCabang.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewPengaturanCabang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewPengaturanCabang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPengaturanCabang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanCabang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanCabang.RowHeadersVisible = false;
        }

        private void dataGridViewPengaturanCabang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pIdCabang = dataGridViewPengaturanCabang.CurrentRow.Cells["id"].Value.ToString();
                string pNamaCabang = dataGridViewPengaturanCabang.CurrentRow.Cells["nama"].Value.ToString();
                string pAlamatCabang = dataGridViewPengaturanCabang.CurrentRow.Cells["alamat"].Value.ToString();
                string pPegawaiId = dataGridViewPengaturanCabang.CurrentRow.Cells["pegawais_id"].Value.ToString();

                if (e.ColumnIndex == dataGridViewPengaturanCabang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pIdCabang +
                        " - " + pNamaCabang + " ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Cabang.HapusData(pIdCabang, FormLoading.cdb);
                        if (hapus == true)
                        {
                            MessageBox.Show("Deletion success");

                            FormPengaturanCabang_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed");
                        }
                    }
                }
                else
                {
                    FormUbahCabang frm = new FormUbahCabang();
                    frm.Owner = this;
                    frm.textBoxIDCabang.Text = pIdCabang;
                    frm.textBoxNamaCabang.Text = pNamaCabang;
                    frm.textBoxAlamatCabang.Text = pAlamatCabang;
                    frm.comboBoxPegawai.Text = pPegawaiId;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branch is still connect to another items. Error Message : " + ex.Message);
            }

        }

        private void textBoxCBPengaturanCabang_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();

            string kriteria = "";
            switch (comboBoxCBPengaturanCabang.Text)
            {
                case "ID Cabang":
                    kriteria = "c.id";
                    break;
                case "Nama Cabang":
                    kriteria = "c.nama";
                    break;
                case "Alamat Cabang":
                    kriteria = "c.alamat";
                    break;
                case "Pegawai":
                    kriteria = "p.nama";
                    break;
            }
            if (textBoxCBPengaturanCabang.Text == "Type Here...")
            {
                listCabang = Cabang.BacaData(kriteria, "", FormLoading.cdb);
            }
            else
            {
                listCabang = Cabang.BacaData(kriteria, textBoxCBPengaturanCabang.Text, FormLoading.cdb);
            }
            TampilDataGrid();

        }
    }
}
