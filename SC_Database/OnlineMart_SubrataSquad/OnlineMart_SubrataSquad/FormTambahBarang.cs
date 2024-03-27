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
using System.IO;

namespace OnlineMart_SubrataSquad
{
    public partial class FormTambahBarang : Form
    {
        public List<Barang> listBarang = new List<Barang>();
        public List<Kategori> listKategori = new List<Kategori>();

        public FormTambahBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaBarang.Text != "" && textBoxNamaBarang.Text != null && textBoxHargaBarang.Text != "" && textBoxHargaBarang.Text != null)
                {
                    byte[] img = null;
                    if (pictureBoxBarang.Image != null)
                    {
                        //Convert Foto ke Byte
                        MemoryStream ms = new MemoryStream();
                        pictureBoxBarang.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        img = ms.GetBuffer();
                    }

                    Kategori kategoriDipilih = (Kategori)comboBoxKategoriBarang.SelectedItem;

                    Barang b = new Barang(textBoxNamaBarang.Text, textBoxHargaBarang.Text, kategoriDipilih, img);

                    Barang.TambahData(b, FormLoading.cdb);

                    MessageBox.Show("Item data added successfully.", "Information");

                    FormPengaturanBarang frm = (FormPengaturanBarang)this.Owner;
                    FormTambahBarang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Item data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item data failed to add. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        public void FormTambahBarang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();

            //Kategori
            listKategori = Kategori.BacaData("", "", FormLoading.cdb);

            comboBoxKategoriBarang.DataSource = listKategori;
            comboBoxKategoriBarang.DisplayMember = "Nama";

            comboBoxKategoriBarang.DropDownStyle = ComboBoxStyle.DropDownList;

            //Barang
            listBarang = Barang.BacaData("", "", FormLoading.cdb);

            TampilDataGrid();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxBarang.Image = Image.FromFile(opf.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your picture isn't input correctly. Error Message: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxHargaBarang.Text = "";
            textBoxNamaBarang.Text = "";
            pictureBoxBarang.Image = null;
            textBoxNamaBarang.Focus();
        }

        public void FormatDataGrid()
        {
            dataGridViewBarang.DataSource = null;
            dataGridViewBarang.Columns.Clear();
            dataGridViewBarang.RowTemplate.Height = 100;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            dataGridViewBarang.Columns.Add(imageColumn);
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";

            dataGridViewBarang.Columns.Add("Id", "Id");
            dataGridViewBarang.Columns.Add("Nama", "Name");
            dataGridViewBarang.Columns.Add("Harga", "Price");
            dataGridViewBarang.Columns.Add("Kategori", "Category");

            dataGridViewBarang.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.ReadOnly = true;

            dataGridViewBarang.BorderStyle = BorderStyle.None;
            dataGridViewBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewBarang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBarang.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dataGridViewBarang.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewBarang.BackgroundColor = Color.FromArgb(157, 198, 255);
            dataGridViewBarang.EnableHeadersVisualStyles = false;
            dataGridViewBarang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(73, 147, 250);
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewBarang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBarang.RowHeadersVisible = false;
        }
        public void TampilDataGrid()
        {
            dataGridViewBarang.Rows.Clear();
            MemoryStream msStream = new MemoryStream();

            if (listBarang.Count > 0)
            {
                foreach (Barang b in listBarang)
                {
                    dataGridViewBarang.Rows.Add(b.Images, b.Id, b.Nama, b.Harga, b.Kategori.Nama);
                }

                if (!dataGridViewBarang.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Action";
                    bcol.Text = "Edit";
                    bcol.Name = "btnUbahGrid";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Action";
                    bcol2.Text = "DELETE";
                    bcol2.Name = "btnHapusGrid";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridViewBarang.CurrentRow.Cells["Image"].Value;

            MemoryStream msStream = new MemoryStream(img);

            string idBarang = dataGridViewBarang.CurrentRow.Cells["id"].Value.ToString();
            string namaBarang = dataGridViewBarang.CurrentRow.Cells["nama"].Value.ToString();
            string hargaBarang = dataGridViewBarang.CurrentRow.Cells["harga"].Value.ToString();

            if (e.ColumnIndex == dataGridViewBarang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Are you sure? " + idBarang +
                    " - " + namaBarang + " ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Barang.HapusData(idBarang, FormLoading.cdb);
                    if (hapus == true)
                    {
                        MessageBox.Show("Delete success");
                        FormTambahBarang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed");
                    }
                }
            }
            else
            {
                FormUbahBarang frm = new FormUbahBarang();
                frm.Owner = this;
                frm.pictureBoxBarang.Image = Image.FromStream(msStream);
                frm.textBoxIDBarang.Text = idBarang;
                frm.textBoxNamaBarang.Text = namaBarang;
                frm.textBoxHargaBarang.Text = hargaBarang;
                frm.Show();
            }
        }
    }
}
