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
    public partial class FormUbahStok : Form
    {
        public List<Barang> listBarang = new List<Barang>();
        public List<Cabang> listCabang = new List<Cabang>();

        public FormUbahStok()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxStok.Text != "" && textBoxStok.Text != null)
                {
                    Barang barangs = new Barang();
                    Cabang cabangs = new Cabang();

                    foreach (Barang barang in listBarang)
                    {
                        if (barang.Nama == textBoxBarang.Text)
                        {
                            barangs = barang;
                        }
                    }

                    foreach (Cabang cabang in listCabang)
                    {
                        if (cabang.Nama == textBoxCabang.Text)
                        {
                            cabangs = cabang;
                        }
                    }

                    CabangBarang cb = new CabangBarang(barangs, cabangs, int.Parse(textBoxStok.Text));

                    CabangBarang.UbahStok(cb, FormLoading.cdb);

                    MessageBox.Show("Stock data has been successfully changed.", "Information");

                    FormPengaturanBarang frm = (FormPengaturanBarang)this.Owner;
                    frm.FormPengaturanBarang_Load(sender, e);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Stock can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock data failed to change. Error Message : " + ex.Message,
                        "Failure");
            }
        }

        private void FormUbahStok_Load(object sender, EventArgs e)
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
