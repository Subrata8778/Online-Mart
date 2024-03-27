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
    public partial class FormUbahJumlahBarang : Form
    {
        public List<Cabang> listCabang = new List<Cabang>();
        public List<Barang> listBarang = new List<Barang>();
        public FormUbahJumlahBarang()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxJumlah.Text != "" && textBoxJumlah.Text != null)
                {
                    int cabangId = 0;
                    int barangId = 0;
                    foreach (Cabang c in listCabang)
                    {
                        if (c.Nama == textBoxCabang.Text)
                        {
                            cabangId = c.Id;
                            break;
                        }
                    }

                    foreach (Barang b in listBarang)
                    {
                        if (b.Nama == textBoxBarang.Text)
                        {
                            barangId = b.Id;
                            break;
                        }
                    }
                    Keranjang.UpdateJumlahBeli(int.Parse(textBoxJumlah.Text), barangId, cabangId, FormLoading.cdb);
                    MessageBox.Show("The item is updated");

                    FormKeranjang frm = (FormKeranjang)this.Owner;
                    frm.FormKeranjang_Load(sender, e);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Stock can't be empty");
                }

            }
            catch
            {
                MessageBox.Show("There is a mistake on adding the amount of item.");
            }
        }

        private void FormUbahJumlahBarang_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "", FormLoading.cdb);
            listCabang = Cabang.BacaData("", "", FormLoading.cdb);
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
