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
    public partial class FormTambahStok : Form
    {
        public List<Barang> listBarang = new List<Barang>();
        public List<Cabang> listCabang = new List<Cabang>();

        public FormTambahStok()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxStok.Text != "" && textBoxStok.Text != null)
                {
                    Cabang cabangDipilih = (Cabang)comboBoxCabang.SelectedItem;
                    Barang barangDipilih = (Barang)comboBoxBarang.SelectedItem;

                    CabangBarang cb = new CabangBarang(barangDipilih, cabangDipilih, int.Parse(textBoxStok.Text));

                    CabangBarang.TambahStok(cb, FormLoading.cdb);

                    MessageBox.Show("Stock data added successfully.", "Information");

                    FormPengaturanBarang frm = (FormPengaturanBarang)this.Owner;
                    frm.FormPengaturanBarang_Load(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Stock data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock data failed to add. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahStok_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "", FormLoading.cdb);
            listCabang = Cabang.BacaData("", "", FormLoading.cdb);

            comboBoxBarang.DataSource = listBarang;
            comboBoxBarang.SelectedItem = "Nama";
            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.SelectedItem = "Nama";

            comboBoxBarang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
