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
    public partial class FormUbahPromo : Form
    {
        public FormUbahPromo()
        {
            InitializeComponent();
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaPromo.Text = "";
            textBoxTipePromo.Text = "";
            textBoxDiskon.Text = "";
            textBoxMaksimalDiskon.Text = "";
            textBoxMinimalPembelian.Text = "";
            textBoxKodePromo.Focus();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaPromo.Text != "" && textBoxNamaPromo.Text != null && textBoxTipePromo.Text != "" && textBoxTipePromo.Text != null && textBoxDiskon.Text != "" && textBoxDiskon.Text != null && textBoxMaksimalDiskon.Text != "" && textBoxMaksimalDiskon.Text != null && textBoxMinimalPembelian.Text != "" && textBoxMinimalPembelian.Text != null)
                {
                    Promo promo = new Promo(int.Parse(textBoxKodePromo.Text), textBoxTipePromo.Text, textBoxNamaPromo.Text, int.Parse(textBoxDiskon.Text), int.Parse(textBoxMaksimalDiskon.Text), float.Parse(textBoxMinimalPembelian.Text));
                    Promo.UbahData(promo, FormLoading.cdb);
                    MessageBox.Show("Promo data has been successfully changed.", "Information");
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
                MessageBox.Show("Promo data failed to change. Error Message : " + ex.Message,
                        "Failure");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
