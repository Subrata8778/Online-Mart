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
    public partial class FormUbahCabang : Form
    {
        public List<Pegawai> listPegawai = new List<Pegawai>();

        public FormUbahCabang()
        {
            InitializeComponent();
        }

        private void FormUbahCabang_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("", "", FormLoading.cdb);

            comboBoxPegawai.DataSource = listPegawai;
            comboBoxPegawai.DisplayMember = "Nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNamaCabang.Text != "" && textBoxNamaCabang.Text != null && textBoxAlamatCabang.Text != "" && textBoxAlamatCabang.Text != null)
                {
                    Pegawai pegawaiDipilih = (Pegawai)comboBoxPegawai.SelectedItem;

                    Cabang c = new Cabang(int.Parse(textBoxIDCabang.Text), textBoxNamaCabang.Text, textBoxAlamatCabang.Text,
                        pegawaiDipilih);

                    Cabang.UbahData(c, FormLoading.cdb);

                    MessageBox.Show("Branch data has been successfully changed.", "Information");

                    FormPengaturanCabang frm = (FormPengaturanCabang)this.Owner;
                    frm.FormPengaturanCabang_Load(sender, e);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Branch data can't be empty.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Branch data failed to change. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxAlamatCabang.Text = "";
            textBoxNamaCabang.Text = "";
            textBoxNamaCabang.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
