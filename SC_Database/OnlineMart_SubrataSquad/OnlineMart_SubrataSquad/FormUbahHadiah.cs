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
    public partial class FormUbahHadiah : Form
    {
        public List<Gift> listHadiah = new List<Gift>();
        public FormUbahHadiah()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaHadiah.Text != "" && textBoxNamaHadiah.Text != null && textBoxJumlahPoin.Text != "" && textBoxJumlahPoin.Text != null)
                {
                    Gift g = new Gift(int.Parse(textBoxIDHadiah.Text), textBoxNamaHadiah.Text, textBoxJumlahPoin.Text);
                    Gift.UbahData(g, FormLoading.cdb);
                    MessageBox.Show("Gift data has been successfully changed.", "Information");

                    FormPengaturanHadiah form = (FormPengaturanHadiah)this.Owner;
                    form.FormPengaturanHadiah_Load(sender, e);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gift data can't be empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gift data failed to change. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxNamaHadiah.Text = "";
            textBoxJumlahPoin.Text = "";
            textBoxNamaHadiah.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
