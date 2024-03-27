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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaKategori.Text != "" && textBoxNamaKategori.Text != null)
                {
                    Kategori k = new Kategori(textBoxNamaKategori.Text);
                    Kategori.TambahData(k,FormLoading.cdb);
                    MessageBox.Show("Data kategori success to be added", "Info");

                    FormPengaturanKategori form = (FormPengaturanKategori)this.Owner;
                    form.FormPengaturanKategori_Load(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Category data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error added data category. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaKategori.Text = "";
            textBoxNamaKategori.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
