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
    public partial class FormPengaturanPromo : Form
    {
        List<Promo> listPromo = new List<Promo>();

        public FormPengaturanPromo()
        {
            InitializeComponent();
        }

        public void FormPengaturanPromo_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            listPromo = Promo.BacaData("", "", FormLoading.cdb);

            TampilDataGrid();
        }

        public void FormatDataGrid()
        {
            //kosongi semua kolom di datagridview
            dataGridViewPengaturanPromo.Columns.Clear();

            //menambah kolom di datagridview
            dataGridViewPengaturanPromo.Columns.Add("id", "ID");
            dataGridViewPengaturanPromo.Columns.Add("nama", "Name");
            dataGridViewPengaturanPromo.Columns.Add("tipe", "Type");
            dataGridViewPengaturanPromo.Columns.Add("diskon", "Discount");
            dataGridViewPengaturanPromo.Columns.Add("diskonMax", "Max Discount");
            dataGridViewPengaturanPromo.Columns.Add("minimalBelanja", "Min Expense");

            //agar lebar kolom dapat menyesuaikan panjang/isi data
            dataGridViewPengaturanPromo.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPromo.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPromo.Columns["tipe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPromo.Columns["diskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPromo.Columns["diskonMax"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPengaturanPromo.Columns["minimalBelanja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewPengaturanPromo.AllowUserToAddRows = false;
            dataGridViewPengaturanPromo.ReadOnly = true;

            //Desain Data Grid
            dataGridViewPengaturanPromo.BorderStyle = BorderStyle.None;
            dataGridViewPengaturanPromo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewPengaturanPromo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPengaturanPromo.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewPengaturanPromo.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPengaturanPromo.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewPengaturanPromo.EnableHeadersVisualStyles = false;
            dataGridViewPengaturanPromo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPengaturanPromo.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewPengaturanPromo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewPengaturanPromo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPengaturanPromo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanPromo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPengaturanPromo.RowHeadersVisible = false;
        }

        public void TampilDataGrid()
        {
            dataGridViewPengaturanPromo.Rows.Clear();

            if (listPromo.Count > 0)
            {
                foreach (Promo p in listPromo)
                {
                    dataGridViewPengaturanPromo.Rows.Add(p.Id, p.Tipe, p.Nama, p.Diskon, p.Diskon_max, p.Min_belanja);
                }

                if (!dataGridViewPengaturanPromo.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Action";
                    bcol.Text = "Edit";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanPromo.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Action";
                    bcol2.Text = "Delete";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewPengaturanPromo.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewPengaturanPromo.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPromo formTambahPromo = new FormTambahPromo();
            formTambahPromo.Owner = this;
            formTambahPromo.ShowDialog();
        }


        private void dataGridViewPengaturanPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pIdPromo = dataGridViewPengaturanPromo.CurrentRow.Cells["id"].Value.ToString();
                string pNamaPromo = dataGridViewPengaturanPromo.CurrentRow.Cells["nama"].Value.ToString();
                string pTipePromo = dataGridViewPengaturanPromo.CurrentRow.Cells["tipe"].Value.ToString();
                string pDiskon = dataGridViewPengaturanPromo.CurrentRow.Cells["diskon"].Value.ToString();
                string pDiskonMax = dataGridViewPengaturanPromo.CurrentRow.Cells["diskonMax"].Value.ToString();
                string pMinimalBelanja = dataGridViewPengaturanPromo.CurrentRow.Cells["minimalBelanja"].Value.ToString();


                if (e.ColumnIndex == dataGridViewPengaturanPromo.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    DialogResult hasil = MessageBox.Show(this, "Are you sure? " + pIdPromo +
                        " - " + pNamaPromo + " ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Promo.HapusData(pIdPromo, FormLoading.cdb);
                        if (hapus == true)
                        {
                            MessageBox.Show("Deletion success");

                            FormPengaturanPromo_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed");
                        }
                    }
                }
                else
                {
                    FormUbahPromo formUbahPromo = new FormUbahPromo();
                    formUbahPromo.Owner = this;
                    formUbahPromo.textBoxKodePromo.Text = pIdPromo;
                    formUbahPromo.textBoxNamaPromo.Text = pNamaPromo;
                    formUbahPromo.textBoxTipePromo.Text = pTipePromo;
                    formUbahPromo.textBoxDiskon.Text = pDiskon;
                    formUbahPromo.textBoxMaksimalDiskon.Text = pDiskonMax;
                    formUbahPromo.textBoxMinimalPembelian.Text = pDiskonMax;
                    formUbahPromo.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Employee is still connect to another item");
            }
        }

        private void textBoxPengaturanPromo_Enter(object sender, EventArgs e)
        {
            if (textBoxPengaturanPromo.Text == "Type Here...")
            {
                textBoxPengaturanPromo.Text = "";
                textBoxPengaturanPromo.ForeColor = Color.Black;
                textBoxPengaturanPromo.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxPengaturanPromo_Leave(object sender, EventArgs e)
        {
            if (textBoxPengaturanPromo.Text == "")
            {
                textBoxPengaturanPromo.Text = "Type Here...";
                textBoxPengaturanPromo.ForeColor = Color.Silver;
                textBoxPengaturanPromo.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxPengaturanPromo_TextChanged(object sender, EventArgs e)
        {
            FormatDataGrid();
            string kriteria = "";
            switch (comboBoxPengaturanPromo.Text)
            {
                case "ID Promo":
                    kriteria = "id";
                    break;
                case "Tipe Promo":
                    kriteria = "tipe";
                    break;
                case "Nama Promo":
                    kriteria = "nama";
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
            if (comboBoxPengaturanPromo.Text == "Type Here...")
            {
                listPromo = Promo.BacaData(kriteria, "", FormLoading.cdb);
            }
            else
            {
                listPromo = Promo.BacaData(kriteria, textBoxPengaturanPromo.Text, FormLoading.cdb);
            }
            TampilDataGrid();
        }
    }
}
