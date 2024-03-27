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
    public partial class FormTambahPromo : Form
    {
        public FormTambahPromo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaPromo.Text = "";
            comboBoxTipePromo.Text = "";
            textBoxDiskon.Text = "";
            textBoxMaksimalDiskon.Text = "";
            textBoxMinimalPembelian.Text = "";
            textBoxNamaPromo.Focus();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaPromo.Text != "" && textBoxNamaPromo.Text != null && textBoxDiskon.Text != "" && textBoxDiskon.Text != null && textBoxMaksimalDiskon.Text != "" && textBoxMaksimalDiskon.Text != null && textBoxMinimalPembelian.Text != "" && textBoxMinimalPembelian.Text != null)
                {
                    Promo promo = new Promo(comboBoxTipePromo.Text, textBoxNamaPromo.Text, int.Parse(textBoxDiskon.Text), int.Parse(textBoxMaksimalDiskon.Text), float.Parse(textBoxMinimalPembelian.Text));
                    Promo.TambahData(promo, FormLoading.cdb);
                    MessageBox.Show("Data added.", "Information");
                    FormPengaturanPromo formPengaturanPromo = (FormPengaturanPromo)Owner;
                    formPengaturanPromo.FormPengaturanPromo_Load(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Promo data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add data failed. Error Message : " + ex.Message, "Failure");
            }
        }
    }
}
