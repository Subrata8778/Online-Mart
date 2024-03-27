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
    public partial class FormTambahMetodePembayaran : Form
    {
        public List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();
        public FormTambahMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaMP.Text != "" && textBoxNamaMP.Text != null)
                {
                    MetodePembayaran mp = new MetodePembayaran(textBoxNamaMP.Text);
                    MetodePembayaran.TambahData(mp, FormLoading.cdb);
                    MessageBox.Show("Data payment method success to be added.", "Information");

                    FormPengaturanMetodePembayaran form = (FormPengaturanMetodePembayaran)this.Owner;
                    form.FormPengaturanMetodePembayaran_Load(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Payment method data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There's error added data payment method. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaMP.Text = "";
            textBoxNamaMP.Focus();
        }
    }
}
