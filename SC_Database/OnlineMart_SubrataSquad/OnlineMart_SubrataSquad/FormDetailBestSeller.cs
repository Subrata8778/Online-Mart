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
using System.IO;

namespace OnlineMart_SubrataSquad
{
    public partial class FormDetailBestSeller : Form
    {
        public Barang barang;

        public FormDetailBestSeller()
        {
            InitializeComponent();
        }

        private void FormDetailBestSeller_Load(object sender, EventArgs e)
        {
            byte[] images = barang.Images;
            MemoryStream msStream = new MemoryStream(images);
            pictureBoxBarang.Image = Image.FromStream(msStream);

            labelNamaBarang.Text = barang.Nama;
            labelPrice.Text = "Rp." + barang.Harga;
            labelKategori.Text = barang.Kategori.Nama;
            List<CabangBarang> listCabangBarang = CabangBarang.BacaData("B.Nama", barang.Nama);
            string branch = "Branch: \n";
            int count = 0;
            foreach (CabangBarang cabang in listCabangBarang)
            {
                count += 1;
                branch += cabang.Cabang.Nama + " ";
                if (count % 5 == 0)
                {
                    branch += "\n";
                }
            }
            labelBranch.Text = branch;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
