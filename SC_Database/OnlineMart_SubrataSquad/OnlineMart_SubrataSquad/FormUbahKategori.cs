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
    public partial class FormUbahKategori : Form
    {
        public FormUbahKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaKategori.Text = "";
            textBoxNamaKategori.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaKategori.Text != "" && textBoxNamaKategori.Text != null)
                {
                    Kategori k = new Kategori(int.Parse(textBoxIdKategori.Text), textBoxNamaKategori.Text);
                    Kategori.UbahData(k, FormLoading.cdb);
                    MessageBox.Show("Category data has been successfully changed.", "Information");

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
                MessageBox.Show("Category data failed to change. Error Message : " + ex.Message,
                    "Failure");
            }
        }
    }
}
