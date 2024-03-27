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
    public partial class FormListPengirimanDetail : Form
    {
        public FormListPengirimanDetail()
        {
            InitializeComponent();
        }

        private void buttonTerima_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                MessageBox.Show("Request accepted.", "Information");

                Order.UbahStatusKirim("Accepted", int.Parse(textBoxIDOrder.Text), FormLoading.cdb);

                FormListPengiriman frmLP = (FormListPengiriman)this.Owner;
                frmLP.FormListPengiriman_Load(sender, e);
                this.Close();
            }
        }

        private void buttonTolak_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                MessageBox.Show("Request declined.", "Information");

                Order.UbahStatusKirim("Declined", int.Parse(textBoxIDOrder.Text), FormLoading.cdb);

                FormListPengiriman frmLP = (FormListPengiriman)this.Owner;
                frmLP.FormListPengiriman_Load(sender, e);
                this.Close();
            }
        }

        private void textBoxKomisi_Enter(object sender, EventArgs e)
        {
            if (textBoxKomisi.Text == "Type Here...")
            {
                textBoxKomisi.Text = "";
                textBoxKomisi.ForeColor = Color.Black;
                textBoxKomisi.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxKomisi_Leave(object sender, EventArgs e)
        {
            if (textBoxKomisi.Text == "")
            {
                textBoxKomisi.Text = "Type Here...";
                textBoxKomisi.ForeColor = Color.Silver;
                textBoxKomisi.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxAlamatTujuan_Enter(object sender, EventArgs e)
        {
            if (textBoxAlamatTujuan.Text == "Type Here...")
            {
                textBoxAlamatTujuan.Text = "";
                textBoxAlamatTujuan.ForeColor = Color.Black;
                textBoxAlamatTujuan.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxAlamatTujuan_Leave(object sender, EventArgs e)
        {
            if (textBoxAlamatTujuan.Text == "Type Here...")
            {
                textBoxAlamatTujuan.Text = "Type Here...";
                textBoxAlamatTujuan.ForeColor = Color.Black;
                textBoxAlamatTujuan.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaKonsumen_Enter(object sender, EventArgs e)
        {
            if (textBoxNamaKonsumen.Text == "Type Here...")
            {
                textBoxNamaKonsumen.Text = "";
                textBoxNamaKonsumen.ForeColor = Color.Black;
                textBoxNamaKonsumen.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxNamaKonsumen_Leave(object sender, EventArgs e)
        {
            if (textBoxNamaKonsumen.Text == "")
            {
                textBoxNamaKonsumen.Text = "Type Here...";
                textBoxNamaKonsumen.ForeColor = Color.Silver;
                textBoxNamaKonsumen.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }

        private void textBoxIDOrder_Enter(object sender, EventArgs e)
        {
            if (textBoxIDOrder.Text == "Type Here...")
            {
                textBoxIDOrder.Text = "";
                textBoxIDOrder.ForeColor = Color.Black;
                textBoxIDOrder.Font = new Font("Tahoma", 10, FontStyle.Regular);
            }
        }

        private void textBoxIDOrder_Leave(object sender, EventArgs e)
        {
            if (textBoxIDOrder.Text == "")
            {
                textBoxIDOrder.Text = "Type Here...";
                textBoxIDOrder.ForeColor = Color.Silver;
                textBoxIDOrder.Font = new Font("Tahoma", 10, FontStyle.Italic);
            }
        }
    }
}
